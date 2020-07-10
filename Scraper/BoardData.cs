using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraper
{
    class BoardData
    {
        public string 비고 { get; set; }
        public string 제목 { get; set; }
        public string 시간 { get; set; }
        public string URL { get; set; }

        public bool Hot { get; set; }
        public bool Pop { get; set; }
        public bool Closed { get; set; }

        public BoardData(string bigo, string title, string url = null, string time = null, bool hot = false, bool pop = false, bool closed = false)
        {
            비고 = bigo;
            제목 = title;
            시간 = time;
            URL = url;
            Hot = hot;
            Pop = pop;
            Closed = closed;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} - {3}", Closed ? "[종결]" : Hot ? "[핫]" : Pop ? "[인기]" : "", 제목, 시간, URL);
        }
    }
}
