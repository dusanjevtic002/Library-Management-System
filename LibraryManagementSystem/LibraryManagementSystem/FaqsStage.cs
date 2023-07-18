using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FaqsStage : Form
    {
        private static FaqsStage instance;
        private static String fileName = "faqs.txt";
        private FaqsStage()
        {
            InitializeComponent();
            loadTxtFile();
            adjustDataGrid();
        }

        private void adjustDataGrid()
        {
            this.dgvAllQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void setTheme1FaqsStage()
        {
            this.panelHeaderFaqs.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblInfo.ForeColor = Color.Black;
            this.lblAddQuestion.ForeColor = Color.Black;
            this.lblAnswer.ForeColor = Color.Black;
            this.lblFaqs.ForeColor = Color.Black;
            this.lblTitleOfQuestion.ForeColor = Color.Black;
        }

        public void setTheme2FaqsStage()
        {
            this.panelHeaderFaqs.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblInfo.ForeColor = Color.White;
            this.lblAddQuestion.ForeColor = Color.White;
            this.lblAnswer.ForeColor = Color.White;
            this.lblFaqs.ForeColor = Color.White;
            this.lblTitleOfQuestion.ForeColor = Color.White;
        }

        private void loadTxtFile()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Question");
            dataTable.Columns.Add("Answer");

            try
            {
                String[] lines = File.ReadAllLines(fileName);
                
                for(int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    DataRow rowToAdd = dataTable.NewRow();
                    rowToAdd["Question"] = elements[0];
                    rowToAdd["Answer"] = elements[1];

                    dataTable.Rows.Add(rowToAdd);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            this.dgvAllQuestions.DataSource = dataTable;
            this.dgvAllQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrWhiteSpace(txtBoxTitleOfQuestion.Text) || (String.IsNullOrWhiteSpace(rTBoxAnswer.Text)))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                String question = this.txtBoxTitleOfQuestion.Text;
                String answer = this.rTBoxAnswer.Text;

                try
                {
                    StreamWriter faqsFile = File.AppendText(fileName);
                    faqsFile.WriteLine(question + "," + answer);
                    faqsFile.Close();

                    loadTxtFile();
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvAllQuestions.SelectedRows[0];
            String question = selectedRow.Cells["Question"].Value.ToString();
            String answer = selectedRow.Cells["Answer"].Value.ToString();

            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String line = lines[i];

                    String[] elements = line.Split(',');
                    String questionToCheck = elements[0];
                    String answerToCheck = elements[1];

                    if(questionToCheck.Equals(question) && answerToCheck.Equals(answer))
                    {
                        lines[i] = this.txtBoxTitleOfQuestion.Text + "," + this.rTBoxAnswer.Text;
                        File.WriteAllLines(fileName, lines);
                        break;
                    }
                }
                
                loadTxtFile();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvAllQuestions.SelectedRows[0];
            String question = selectedRow.Cells["Question"].Value.ToString();
            String answer = selectedRow.Cells["Answer"].Value.ToString();

            try
            {
                String[] lines = File.ReadAllLines(fileName);
                List<String> newLines = new List<String>();

                for(int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    //Ako je uslov ispunjen znaci da sam naisao na liniju koju necu da brisem i nju cu dodati u novi sadrzaj, ako sam naisao na tu liniju preskacem je
                    if (!(elements[0].Equals(question) && elements[1].Equals(answer)))
                        newLines.Add(lines[i]);
                }

                File.WriteAllLines(fileName, newLines);
                loadTxtFile();
            }


            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvAllQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAllQuestions.Rows[e.RowIndex];
                this.txtBoxTitleOfQuestion.Text = row.Cells["Question"].Value.ToString();
                this.rTBoxAnswer.Text = row.Cells["Answer"].Value.ToString();
            }
        }

        private void FaqsStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private String fillPrintDocument()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*******************************************************************************************\n");
            sb.Append("*********************              Frequently asked questions                **************************\n");
            sb.Append("*******************************************************************************************\n\n");

            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    sb.Append(i + ". Question: " + elements[0] + "\n");
                    sb.Append("    Answer: " + elements[1] + "\n\n");
                }
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return sb.ToString();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(fillPrintDocument(), new Font("Microsoft Sans Serif", 18, FontStyle.Regular), Brushes.Black, new Point(10, 10));

        }

        private void adjustPrintDialog()
        {
            this.printPreviewDialog.Width = 1200;
            this.printPreviewDialog.Height = 750;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Document = printDocument;
            adjustPrintDialog();

            this.printPreviewDialog.Show();
        }

        public static FaqsStage getInstance()
        {
            if (instance == null)
                instance = new FaqsStage();

            return instance;
        }
    }
}
