using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinese_Citation_Generator
{
    public partial class App : Form
    {
        DataTable dt = new DataTable();
        public string path = Directory.GetCurrentDirectory();
        public string pathFileName = "\\ChiReference.csv";
        public void LoadTableHeader()
        {
            dt.Columns.Add("作者", typeof(string));
            dt.Columns.Add("書名", typeof(string));
            dt.Columns.Add("出版地點", typeof(string));
            dt.Columns.Add("出版社", typeof(string));
            dt.Columns.Add("出版年份", typeof(string));
            table.DataSource = dt;
        }

        public App()
        {
            InitializeComponent();
        }

        private void author_TextChanged(object sender, EventArgs e)
        {
            if (lockBook.Checked != true)
                if (author.Text != "" && BookName.Text != "" && publisher.Text != ""
                 && publishPlace.Text != "" && publishYear.Text != "")
                    bookReference.Text = author.Text + "：《" + BookName.Text + "》。"
                    + publishPlace.Text + "：" + publisher.Text + "，" + publishYear.Text + "年。";

            //Footnote
            if (lockBook.Checked != true) //If the box is not fixe
                //Check if all info is entered.
                if (author.Text != "" && BookName.Text != "" && publisher.Text != ""
                 && publishPlace.Text != "" && publishYear.Text != "" && bookPage.Text != "")
                    //do the gathering
                    bookFootnote.Text = author.Text + "：《" + BookName.Text + "》（"
                    + publishPlace.Text + "：" + publisher.Text + "，"
                    + publishYear.Text + "年），頁" + bookPage.Text + "。";
        }

        private void ClearBook_Click(object sender, EventArgs e)
        {
            ClearBook();
        }

        private void BookFix_CheckedChanged(object sender, EventArgs e)
        {
            if (lockBook.Checked == true)
            {
                bookReference.ReadOnly = true;
                bookFootnote.ReadOnly = true;
            }
            else
            {
                bookReference.ReadOnly = false;
                bookFootnote.ReadOnly = false;
            }
        }
        private void BookAdd_Click(object sender, EventArgs e)
        {
            //table.Rows.Add(author.Text, BookName.Text, publishPlace.Text, publisher.Text, publishYear.Text);
            DataRow row = dt.NewRow();
            row["作者"] = author.Text;
            row["書名"] = BookName.Text;
            row["出版地點"] = publishPlace.Text;
            row["出版社"] = publisher.Text;
            row["出版年份"] = publishYear.Text;
            //dt.Rows.Add(author.Text, BookName.Text, publishPlace.Text, publisher.Text, publishYear.Text);
            dt.Rows.Add(row);
            table.DataSource = dt;
        }

        private void DeleteSelectedRow_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0 && this.table.SelectedRows[0].Index != this.table.Rows.Count - 1)
            {
                this.table.Rows.RemoveAt(this.table.SelectedRows[0].Index);
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://iss.lib.hkbu.edu.hk.lib-ezproxy.hkbu.edu.hk/honprohandbook/chinese.pdf");
        }

        private void BookReference_MouseClick(object sender, MouseEventArgs e)
        {
            if (bookReference.Text != "")
            {
                Clipboard.SetText(bookReference.Text);
                bookReference.SelectAll();
            }
        }

        private void BookFootnote_MouseClick(object sender, MouseEventArgs e)
        {
            if (bookFootnote.Text != "")
            {
                Clipboard.SetText(bookFootnote.Text);
                bookFootnote.SelectAll();
            }
        }

        private void checkbox_SelectedEssays_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SelectedEssays.Checked)
            {
                bookExt.Visible = true;
                label_BookExt.Visible = true;
                label_BookExt.Text = "論集名";
                checkBox_BookEdition.Enabled = false;
            }
            else
            {
                bookExt.Visible = false;
                label_BookExt.Visible = false;
                checkBox_BookEdition.Enabled = true;
            }
        }

        private void ArticleAuthor_TextChanged(object sender, EventArgs e)
        {
            if (articleAuthor.Text != "" && articleTitle.Text != "" && articlePage.Text != "" &&
                journalVolume.Text != "" && journalYear.Text != "" && journalTitle.Text != "")

                articleFootnote.Text = articleAuthor.Text + "：〈" + articleTitle.Text + "〉，《" + journalTitle.Text
                + "》，總第" + journalVolume.Text + "期（" + journalYear.Text + "年），頁" + articlePage.Text + "。";


            else if (articleAuthor.Text != "" && articleTitle.Text != "" && articlePage.Text != "" &&
                journalIssue.Text != "" && journalYear.Text != "" && journalTitle.Text != "")

                articleFootnote.Text = articleAuthor.Text + "：〈" + articleTitle.Text + "〉，《" + journalTitle.Text + "》，"
                    + journalYear.Text + "年第" + journalIssue.Text + "期，頁" + articlePage.Text + "。";

            if (articleAuthor.Text != "" && articleTitle.Text != "" && articleTotalPage.Text != "" &&
               journalVolume.Text != "" && journalYear.Text != "" && journalTitle.Text != "")

                articleReference.Text = articleAuthor.Text + "：〈" + articleTitle.Text + "〉，《" + journalTitle.Text
                + "》第" + journalVolume.Text + "期（" + journalYear.Text + "年），頁" + articleTotalPage.Text.Replace('-', '–') + "。";


            else if (articleAuthor.Text != "" && articleTitle.Text != "" && articleTotalPage.Text != "" &&
                      journalIssue.Text != "" && journalYear.Text != "" && journalTitle.Text != "")

                articleReference.Text = articleAuthor.Text + "：〈" + articleTitle.Text + "〉，《" + journalTitle.Text + "》，"
                    + journalYear.Text + "年，第" + journalIssue.Text + "期，頁" + articleTotalPage.Text.Replace('-', '–') + "。";
        }

        private void ArticleFootnote_MouseClick(object sender, MouseEventArgs e)
        {
            if (articleFootnote.Text != "")
            {
                Clipboard.SetText(articleFootnote.Text);
                articleFootnote.SelectAll();
            }
        }

        private void ClearEssayButton_Click(object sender, EventArgs e)
        {
            articlePage.Text = "";
            articleAuthor.Text = "";
            articleTitle.Text = "";
            journalTitle.Text = "";
            journalIssue.Text = "";
            journalVolume.Text = "";
            journalYear.Text = "";
        }

        private void ArticleReference_MouseClick(object sender, MouseEventArgs e)
        {
            if (articleReference.Text != "")
            {
                Clipboard.SetText(articleReference.Text);
                articleReference.SelectAll();
            }
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = table.Rows[e.RowIndex];
                if (dgvRow.Cells[0].Value != null || dgvRow.Cells[0].Value != "")
                {
                    author.Text = dgvRow.Cells[0].Value.ToString();
                    BookName.Text = dgvRow.Cells[1].Value.ToString();
                    publishPlace.Text = dgvRow.Cells[2].Value.ToString();
                    publisher.Text = dgvRow.Cells[3].Value.ToString();
                    publishYear.Text = dgvRow.Cells[4].Value.ToString();

                    if (author.Text != "" && BookName.Text != "" && publisher.Text != ""
                     && publishPlace.Text != "" && publishYear.Text != "")
                        bookReference.Text = author.Text + "：《" + BookName.Text + "》。"
                        + publishPlace.Text + "：" + publisher.Text + "，" + publishYear.Text + "年。";
                    else ClearBook();
                }
            }
        }

        private void CheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        public void ClearBook()
        {
            author.Text = "";
            BookName.Text = "";
            publishPlace.Text = "";
            publisher.Text = "";
            publishYear.Text = "";
            bookReference.Text = "";
            bookPage.Text = "";
            bookFootnote.Text = "";
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FileName = pathFileName;
            //saveFileDialog1.DefaultExt = ".csv";
            saveFileDialog1.InitialDirectory = path;

            DialogResult result = saveFileDialog1.ShowDialog();
            if (string.IsNullOrWhiteSpace(saveFileDialog1.FileName)) return;
            if (result == DialogResult.OK)
            {
                StreamWriter export = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                export.WriteLine(bookReferenceHeader);
                for (int i = 0; i < table.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        export.Write("{0},", table.Rows[i].Cells[j].Value.ToString());
                    }
                    export.WriteLine();
                }
                export.Close();
            }
        }

        public string bookReferenceHeader = "作者,書名,出版地點,出版社,出版年份";

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.FileName = pathFileName;
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            //openFileDialog1.ShowHelp = true;
            DialogResult result = openFileDialog1.ShowDialog();
            //If cancel
            if (string.IsNullOrWhiteSpace(openFileDialog1.FileName)) return;
            if (result == DialogResult.Cancel) return;
            CheckImportFile(openFileDialog1.FileName, false);
        }

        //Check whether the imported file is valid or not.
        public void CheckImportFile(string fileName, bool initialize)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            if (lines.Length <= 1)
                if (initialize) return;
                else { MessageBox.Show("讀取的檔案沒有任何內容。", "錯誤"); return; }

            if (lines[0] != bookReferenceHeader)
                if (initialize) return;
                else { MessageBox.Show("讀取的檔案格式不正確。", "錯誤"); return; }

            LoadFile(fileName, lines);
        }

        public void LoadFile(string fileName, string[] lines)
        {
            //string[] lines = System.IO.File.ReadAllLines(fileName);

            pathFileName = Path.GetFileName(fileName);
            //renew the DataTable
            dt = new DataTable();
            //first line to create header
            string firstLine = lines[0];
            string[] headerLabels = firstLine.Split(',');
            foreach (string headerWord in headerLabels)
            {
                dt.Columns.Add(new DataColumn(headerWord));
            }
            //For Data
            for (int i = 1; i < lines.Length; i++)
            {
                string[] dataWords = lines[i].Split(',');
                DataRow dr = dt.NewRow();
                int columnIndex = 0;
                foreach (string headerWord in headerLabels)
                {
                    dr[headerWord] = dataWords[columnIndex++];
                }
                dt.Rows.Add(dr);
            }

            if (dt.Rows.Count > 0)
            {
                table.DataSource = dt;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("你確定要清空引用書目表嗎？", "警告", MessageBoxButtons.YesNo))
            {
                dt = new DataTable();
                LoadTableHeader();
            }
        }

        private void checkBox_BookEdition_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BookEdition.Checked)
            {
                bookExt.Visible = true;
                label_BookExt.Visible = true;
                label_BookExt.Text = "版本";
                checkbox_SelectedEssays.Enabled = false;
            }
            else
            {
                bookExt.Visible = false;
                label_BookExt.Visible = false;
                checkbox_SelectedEssays.Enabled = true;
            }
        }

        private void lockssay_CheckedChanged(object sender, EventArgs e)
        {
            if (lockBook.Checked == true)
            {
                articleReference.ReadOnly = true;
                articleReference.ReadOnly = true;
            }
            else
            {
                articleReference.ReadOnly = false;
                articleReference.ReadOnly = false;
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
            //Load DataTables Column
            LoadTableHeader();

            //Autoload Saved DataTable
            if (File.Exists(path + pathFileName)) CheckImportFile(path + pathFileName, true);
        }
    }
}
