using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scraper
{
    public partial class MainForm : Form
    {
        List<BoardData> _list = new List<BoardData>();

        public MainForm()
        {
            InitializeComponent();

            InitializeComboBox();
            InitializeDataGridView();
        }

        private void InitializeComboBox()
        {
            for(int i = 1; i < 101; i++)
                cbbPage.Items.Add(i);

            ccbCategory.Items.Add("해외");
            ccbCategory.Items.Add("국내");

            cbbPage.SelectedIndex = 2;
            ccbCategory.SelectedIndex = 0;
        }

        private void InitializeDataGridView()
        {
            dataGV.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGV.MultiSelect = false;
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGV.CellDoubleClick += DataGV_CellDoubleClick;
        }

        // 스케쥴러 등록용
        public void SearchAndSendMessage(int pageCount = 3, bool isOversee = true)
        {
            PageScraping(pageCount, isOversee);

            // 키워드파일 검색
            List<string> keywords = GetKeywords();
            List<BoardData> results = new List<BoardData>();

            foreach(var keyword in keywords)
                results.AddRange(_list.Where(x => x.제목.ToLower().Contains(keyword.Trim().ToLower())).ToList());

            results = results.GroupBy(x => x).Select(x => x.Key).ToList();

            // 메시지 전송
            foreach (var message in results)
                TelegramHelper.SendMessageByTelegramBot(message.ToString());
            
        }

        private List<string> GetKeywords()
        {
            return TextFileHelper.GetListFromText(TextFileHelper.ReadFile("keywords.txt"), ',');
        }

        private void PageScrapAndBinding()
        {
            int endPage = 1;
            int.TryParse(cbbPage.SelectedItem.ToString(), out endPage);

            bool isOversee = false;
            if ("해외".Equals(ccbCategory.SelectedItem.ToString()))
                isOversee = true;

            PageScraping(endPage, isOversee);

            dataGV.DataSource = _list;
            dataGV.Refresh();
        }

        private List<BoardData> PageScraping(int endPage, bool isOversee)
        {
            // 국내
            string url = @"http://www.ppomppu.co.kr/zboard/zboard.php?id=ppomppu";

            // 해외
            if (isOversee)
                url = @"http://www.ppomppu.co.kr/zboard/zboard.php?id=ppomppu4";

            int page = 1;
           
            _list = null;
            _list = new List<BoardData>();

            while (page <= endPage)
            {
                if (page > 1)
                    url = string.Format("{0}&page={1}", url, page);

                // 조회
                var result = Task.Run<string>(async () => await Scraping.RequestHttpClient(url, Method.GET, null));
                result.Wait();
                var text = result.Result;
                texBox.Text = text;

                _list.AddRange(GetTitelLIst(text));

                page++;
            }

            return _list;
        }

        #region HTML 구문분석

        /// <summary>
        /// 제목 추출
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private List<BoardData> GetTitelLIst(string text)
        {
            const string hot_icon2 = "/images/menu/not_icon2.jpg";    // hot
            const string pop_icon2 = "/images/menu/pop_icon2.jpg";    // 인기

            // 제목
            const string startText = "<font class=list_title>";
            const string startText_closed = "<font color=#ACACAC>";
            const string endText = "</font>";

            // 등록시간
            const string startTime = "<td nowrap class='eng list_vspace' colspan=2  title=";
            const string endTime = "<nobr class='eng list_vspace'>";


            // 상세페이지 url
            const string startUrl = "<a href=";
            
            //
            string temp = text;
            string urlTemp = string.Empty;

            string bigo = string.Empty;

            bool hot = false;
            bool pop = false;
            bool closed = false;

            List<BoardData> titleList = new List<BoardData>();
            while (temp.IndexOf(startText) > 0 || temp.IndexOf(startText_closed) > 0)
            {
                hot = pop = closed = false;
                bigo = string.Empty;

                int startTextIndex = temp.IndexOf(startText);
                int closedTextIndex = temp.IndexOf(startText_closed);

                string searchText = startText;
                if (startTextIndex < 0 || (closedTextIndex > 0 && closedTextIndex < startTextIndex))
                {
                    closed = true;
                    searchText = startText_closed;
                }

                // url
                urlTemp = temp.Substring(0, temp.IndexOf(searchText) - 4);

                // 인기. 핫 확인
                if (urlTemp.IndexOf(hot_icon2) > 0)
                    hot = true;
                else if (urlTemp.IndexOf(pop_icon2) > 0)
                    pop = true;

                // 바로가기 URL만 남김
                urlTemp = urlTemp.Substring(urlTemp.LastIndexOf(startUrl) + startUrl.Length + 1);

                //
                bigo = string.Format("{0}{1}", closed ? "<종결>" : "", hot ? "[핫]" : pop ? "[인기]" : "");

                // 제목/시간
                temp = temp.Substring(temp.IndexOf(searchText) + searchText.Length);
                titleList.Add(new BoardData(bigo
                                            , temp.Substring(0, temp.IndexOf(endText))
                                            , string.Format("{0}{1}", @"http://www.ppomppu.co.kr/zboard/", urlTemp)
                                            , temp.Substring(temp.IndexOf(startTime) + startTime.Length + 1, (temp.IndexOf(endTime) - 3) - (temp.IndexOf(startTime) + startTime.Length + 1))
                                            , hot, pop, closed));
            }

            return titleList;
        }

        #endregion

        #region 이벤트
        private void DataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV.SelectedRows.Count == 0)
                return;

            var selectedRow = dataGV.SelectedRows[0];
            var url = selectedRow.Cells["URL"].Value.ToString();

            System.Diagnostics.Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageScrapAndBinding();
        }

        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            if (string.IsNullOrWhiteSpace(keyword))
                return;

            richTextBox1.AppendText(keyword);
            txtKeyword.Text = string.Empty;
        }

        private void btnDeleteKeyword_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearchWord.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                dataGV.DataSource = _list;
                return;
            }

            var searchList = _list.Where(x => x.제목.ToLower().Contains(searchText.ToLower())).ToList();
            dataGV.DataSource = searchList;
        }

        private void btnOriginList_Click(object sender, EventArgs e)
        {
            txtSearchWord.Text = string.Empty;
            btnSearch.PerformClick();
        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        #endregion
    }

}
