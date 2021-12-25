
namespace Chinese_Citation_Generator
{
    partial class App
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.label_BookExt = new System.Windows.Forms.Label();
            this.bookExt = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.journalIssue = new System.Windows.Forms.TextBox();
            this.journalYearlabel = new System.Windows.Forms.Label();
            this.journalYear = new System.Windows.Forms.TextBox();
            this.checkbox_SelectedEssays = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.articleFootnote = new System.Windows.Forms.TextBox();
            this.lockEssay = new System.Windows.Forms.CheckBox();
            this.clearEssayButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.articlePage = new System.Windows.Forms.TextBox();
            this.deleteSelectedRow = new System.Windows.Forms.Button();
            this.secondAuthorLabel = new System.Windows.Forms.Label();
            this.bookPageLabel = new System.Windows.Forms.Label();
            this.bookFootnote = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.secondAuthor = new System.Windows.Forms.TextBox();
            this.lockBook = new System.Windows.Forms.CheckBox();
            this.clearBookButton = new System.Windows.Forms.Button();
            this.articleReference = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.articleTotalPage = new System.Windows.Forms.TextBox();
            this.journalVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.journalTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.articleTitle = new System.Windows.Forms.TextBox();
            this.articleAuthor = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.checkBox_BookEdition = new System.Windows.Forms.CheckBox();
            this.bookReference = new System.Windows.Forms.TextBox();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.bookPage = new System.Windows.Forms.TextBox();
            this.publishYear = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publishPlaceLabel = new System.Windows.Forms.Label();
            this.publishPlace = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label_BookExt
            // 
            resources.ApplyResources(this.label_BookExt, "label_BookExt");
            this.label_BookExt.Name = "label_BookExt";
            // 
            // bookExt
            // 
            resources.ApplyResources(this.bookExt, "bookExt");
            this.bookExt.Name = "bookExt";
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.Name = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // journalIssue
            // 
            resources.ApplyResources(this.journalIssue, "journalIssue");
            this.journalIssue.Name = "journalIssue";
            this.journalIssue.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // journalYearlabel
            // 
            resources.ApplyResources(this.journalYearlabel, "journalYearlabel");
            this.journalYearlabel.Name = "journalYearlabel";
            // 
            // journalYear
            // 
            resources.ApplyResources(this.journalYear, "journalYear");
            this.journalYear.Name = "journalYear";
            this.journalYear.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // checkbox_SelectedEssays
            // 
            resources.ApplyResources(this.checkbox_SelectedEssays, "checkbox_SelectedEssays");
            this.checkbox_SelectedEssays.Name = "checkbox_SelectedEssays";
            this.checkbox_SelectedEssays.UseVisualStyleBackColor = true;
            this.checkbox_SelectedEssays.CheckedChanged += new System.EventHandler(this.checkbox_SelectedEssays_CheckedChanged);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // articleFootnote
            // 
            resources.ApplyResources(this.articleFootnote, "articleFootnote");
            this.articleFootnote.Name = "articleFootnote";
            this.articleFootnote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArticleFootnote_MouseClick);
            // 
            // lockEssay
            // 
            resources.ApplyResources(this.lockEssay, "lockEssay");
            this.lockEssay.Name = "lockEssay";
            this.lockEssay.UseVisualStyleBackColor = true;
            this.lockEssay.CheckedChanged += new System.EventHandler(this.lockssay_CheckedChanged);
            // 
            // clearEssayButton
            // 
            resources.ApplyResources(this.clearEssayButton, "clearEssayButton");
            this.clearEssayButton.Name = "clearEssayButton";
            this.clearEssayButton.UseVisualStyleBackColor = true;
            this.clearEssayButton.MouseCaptureChanged += new System.EventHandler(this.ClearEssayButton_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // articlePage
            // 
            resources.ApplyResources(this.articlePage, "articlePage");
            this.articlePage.Name = "articlePage";
            this.articlePage.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // deleteSelectedRow
            // 
            resources.ApplyResources(this.deleteSelectedRow, "deleteSelectedRow");
            this.deleteSelectedRow.Name = "deleteSelectedRow";
            this.deleteSelectedRow.UseVisualStyleBackColor = true;
            this.deleteSelectedRow.Click += new System.EventHandler(this.DeleteSelectedRow_Click);
            // 
            // secondAuthorLabel
            // 
            resources.ApplyResources(this.secondAuthorLabel, "secondAuthorLabel");
            this.secondAuthorLabel.Name = "secondAuthorLabel";
            // 
            // bookPageLabel
            // 
            resources.ApplyResources(this.bookPageLabel, "bookPageLabel");
            this.bookPageLabel.Name = "bookPageLabel";
            // 
            // bookFootnote
            // 
            resources.ApplyResources(this.bookFootnote, "bookFootnote");
            this.bookFootnote.Name = "bookFootnote";
            this.bookFootnote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookFootnote_MouseClick);
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.Name = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // secondAuthor
            // 
            resources.ApplyResources(this.secondAuthor, "secondAuthor");
            this.secondAuthor.Name = "secondAuthor";
            // 
            // lockBook
            // 
            resources.ApplyResources(this.lockBook, "lockBook");
            this.lockBook.Name = "lockBook";
            this.lockBook.UseVisualStyleBackColor = true;
            this.lockBook.CheckedChanged += new System.EventHandler(this.BookFix_CheckedChanged);
            // 
            // clearBookButton
            // 
            resources.ApplyResources(this.clearBookButton, "clearBookButton");
            this.clearBookButton.Name = "clearBookButton";
            this.clearBookButton.UseVisualStyleBackColor = true;
            this.clearBookButton.Click += new System.EventHandler(this.ClearBook_Click);
            // 
            // articleReference
            // 
            resources.ApplyResources(this.articleReference, "articleReference");
            this.articleReference.Name = "articleReference";
            this.articleReference.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArticleReference_MouseClick);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // articleTotalPage
            // 
            resources.ApplyResources(this.articleTotalPage, "articleTotalPage");
            this.articleTotalPage.Name = "articleTotalPage";
            this.articleTotalPage.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // journalVolume
            // 
            resources.ApplyResources(this.journalVolume, "journalVolume");
            this.journalVolume.Name = "journalVolume";
            this.journalVolume.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // journalTitle
            // 
            resources.ApplyResources(this.journalTitle, "journalTitle");
            this.journalTitle.Name = "journalTitle";
            this.journalTitle.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // articleTitle
            // 
            resources.ApplyResources(this.articleTitle, "articleTitle");
            this.articleTitle.Name = "articleTitle";
            this.articleTitle.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // articleAuthor
            // 
            resources.ApplyResources(this.articleAuthor, "articleAuthor");
            this.articleAuthor.Name = "articleAuthor";
            this.articleAuthor.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            // 
            // addBookButton
            // 
            resources.ApplyResources(this.addBookButton, "addBookButton");
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // checkBox_BookEdition
            // 
            resources.ApplyResources(this.checkBox_BookEdition, "checkBox_BookEdition");
            this.checkBox_BookEdition.Name = "checkBox_BookEdition";
            this.checkBox_BookEdition.UseVisualStyleBackColor = true;
            this.checkBox_BookEdition.CheckedChanged += new System.EventHandler(this.checkBox_BookEdition_CheckedChanged);
            // 
            // bookReference
            // 
            resources.ApplyResources(this.bookReference, "bookReference");
            this.bookReference.Name = "bookReference";
            this.bookReference.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookReference_MouseClick);
            // 
            // publishYearLabel
            // 
            resources.ApplyResources(this.publishYearLabel, "publishYearLabel");
            this.publishYearLabel.Name = "publishYearLabel";
            // 
            // bookPage
            // 
            resources.ApplyResources(this.bookPage, "bookPage");
            this.bookPage.Name = "bookPage";
            this.bookPage.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // publishYear
            // 
            resources.ApplyResources(this.publishYear, "publishYear");
            this.publishYear.Name = "publishYear";
            this.publishYear.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // publisher
            // 
            resources.ApplyResources(this.publisher, "publisher");
            this.publisher.Name = "publisher";
            this.publisher.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // publisherLabel
            // 
            resources.ApplyResources(this.publisherLabel, "publisherLabel");
            this.publisherLabel.Name = "publisherLabel";
            // 
            // publishPlaceLabel
            // 
            resources.ApplyResources(this.publishPlaceLabel, "publishPlaceLabel");
            this.publishPlaceLabel.Name = "publishPlaceLabel";
            // 
            // publishPlace
            // 
            resources.ApplyResources(this.publishPlace, "publishPlace");
            this.publishPlace.Name = "publishPlace";
            this.publishPlace.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // bookNameLabel
            // 
            resources.ApplyResources(this.bookNameLabel, "bookNameLabel");
            this.bookNameLabel.Name = "bookNameLabel";
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
            // 
            // BookName
            // 
            resources.ApplyResources(this.BookName, "BookName");
            this.BookName.Name = "BookName";
            this.BookName.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // author
            // 
            resources.ApplyResources(this.author, "author");
            this.author.Name = "author";
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.table, "table");
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 24;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_BookExt);
            this.Controls.Add(this.bookExt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.journalIssue);
            this.Controls.Add(this.journalYearlabel);
            this.Controls.Add(this.journalYear);
            this.Controls.Add(this.checkbox_SelectedEssays);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.articleFootnote);
            this.Controls.Add(this.lockEssay);
            this.Controls.Add(this.clearEssayButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.articlePage);
            this.Controls.Add(this.deleteSelectedRow);
            this.Controls.Add(this.secondAuthorLabel);
            this.Controls.Add(this.bookPageLabel);
            this.Controls.Add(this.bookFootnote);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.secondAuthor);
            this.Controls.Add(this.lockBook);
            this.Controls.Add(this.clearBookButton);
            this.Controls.Add(this.articleReference);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.articleTotalPage);
            this.Controls.Add(this.journalVolume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.journalTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.articleTitle);
            this.Controls.Add(this.articleAuthor);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.checkBox_BookEdition);
            this.Controls.Add(this.bookReference);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.bookPage);
            this.Controls.Add(this.publishYear);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.publishPlaceLabel);
            this.Controls.Add(this.publishPlace);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.author);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.TextChanged += new System.EventHandler(this.ArticleAuthor_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BookExt;
        private System.Windows.Forms.TextBox bookExt;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox journalIssue;
        private System.Windows.Forms.Label journalYearlabel;
        private System.Windows.Forms.TextBox journalYear;
        private System.Windows.Forms.CheckBox checkbox_SelectedEssays;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox articleFootnote;
        private System.Windows.Forms.CheckBox lockEssay;
        private System.Windows.Forms.Button clearEssayButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox articlePage;
        private System.Windows.Forms.Button deleteSelectedRow;
        private System.Windows.Forms.Label secondAuthorLabel;
        private System.Windows.Forms.Label bookPageLabel;
        private System.Windows.Forms.TextBox bookFootnote;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox secondAuthor;
        private System.Windows.Forms.CheckBox lockBook;
        private System.Windows.Forms.Button clearBookButton;
        private System.Windows.Forms.TextBox articleReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox articleTotalPage;
        private System.Windows.Forms.TextBox journalVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox journalTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox articleTitle;
        private System.Windows.Forms.TextBox articleAuthor;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.CheckBox checkBox_BookEdition;
        private System.Windows.Forms.TextBox bookReference;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.TextBox bookPage;
        private System.Windows.Forms.TextBox publishYear;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label publishPlaceLabel;
        private System.Windows.Forms.TextBox publishPlace;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.DataGridView table;
    }
}

