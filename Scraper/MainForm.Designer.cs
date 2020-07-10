namespace Scraper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.texBox = new System.Windows.Forms.RichTextBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDeleteKeyword = new System.Windows.Forms.Button();
            this.cbbPage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOriginList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1014, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "스크랩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texBox
            // 
            this.texBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texBox.Location = new System.Drawing.Point(12, 12);
            this.texBox.Name = "texBox";
            this.texBox.Size = new System.Drawing.Size(985, 85);
            this.texBox.TabIndex = 2;
            this.texBox.Text = "";
            // 
            // dataGV
            // 
            this.dataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 149);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowTemplate.Height = 23;
            this.dataGV.Size = new System.Drawing.Size(985, 501);
            this.dataGV.TabIndex = 3;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Location = new System.Drawing.Point(1014, 165);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 21);
            this.txtKeyword.TabIndex = 4;
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKeyword.Location = new System.Drawing.Point(1011, 196);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(103, 26);
            this.btnAddKeyword.TabIndex = 0;
            this.btnAddKeyword.Text = "키워드 추가";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(1014, 228);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 256);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnDeleteKeyword
            // 
            this.btnDeleteKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteKeyword.Location = new System.Drawing.Point(1011, 490);
            this.btnDeleteKeyword.Name = "btnDeleteKeyword";
            this.btnDeleteKeyword.Size = new System.Drawing.Size(103, 26);
            this.btnDeleteKeyword.TabIndex = 0;
            this.btnDeleteKeyword.Text = "키워드 삭제";
            this.btnDeleteKeyword.UseVisualStyleBackColor = true;
            this.btnDeleteKeyword.Click += new System.EventHandler(this.btnDeleteKeyword_Click);
            // 
            // cbbPage
            // 
            this.cbbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPage.FormattingEnabled = true;
            this.cbbPage.Location = new System.Drawing.Point(1017, 103);
            this.cbbPage.Name = "cbbPage";
            this.cbbPage.Size = new System.Drawing.Size(97, 20);
            this.cbbPage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "페이지까지";
            // 
            // ccbCategory
            // 
            this.ccbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ccbCategory.FormattingEnabled = true;
            this.ccbCategory.Location = new System.Drawing.Point(1014, 8);
            this.ccbCategory.Name = "ccbCategory";
            this.ccbCategory.Size = new System.Drawing.Size(103, 20);
            this.ccbCategory.TabIndex = 8;
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(13, 116);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(354, 21);
            this.txtSearchWord.TabIndex = 9;
            this.txtSearchWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchWord_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOriginList
            // 
            this.btnOriginList.Location = new System.Drawing.Point(455, 115);
            this.btnOriginList.Name = "btnOriginList";
            this.btnOriginList.Size = new System.Drawing.Size(75, 23);
            this.btnOriginList.TabIndex = 10;
            this.btnOriginList.Text = "초기화";
            this.btnOriginList.UseVisualStyleBackColor = true;
            this.btnOriginList.Click += new System.EventHandler(this.btnOriginList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 674);
            this.Controls.Add(this.btnOriginList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchWord);
            this.Controls.Add(this.ccbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.texBox);
            this.Controls.Add(this.btnDeleteKeyword);
            this.Controls.Add(this.btnAddKeyword);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox texBox;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDeleteKeyword;
        private System.Windows.Forms.ComboBox cbbPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbCategory;
        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOriginList;
    }
}

