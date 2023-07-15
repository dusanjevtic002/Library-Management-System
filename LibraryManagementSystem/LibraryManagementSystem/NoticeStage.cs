using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class NoticeStage : Form
    {
        private static NoticeStage instance;
        private NoticeStage()
        {
            InitializeComponent();
            adjustRTBLargeArea();
            adjustRadioButtons();
            fillCBoxCategory();
        }

        private void fillCBoxCategory()
        {
            this.cBoxCategory.Items.Add("Discounts");
            this.cBoxCategory.Items.Add("Events");
            this.cBoxCategory.Items.Add("Remainders");
            this.cBoxCategory.Items.Add("New Arrivals");
            this.cBoxCategory.SelectedIndex = 0;
            this.cBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void adjustRTBLargeArea()
        {
            this.rTBoxLargeArea.ReadOnly = true;
            this.rTBoxLargeArea.Enabled = false;
        }

        private void adjustRadioButtons()
        {
            this.rButtonIncludeDate.Checked = true;
            this.rButtonExcludeDate.Checked = false;
        }

        public void setTheme1NoticeStage()
        {
            this.panelHeaderNotice.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblCategory.ForeColor = Color.Black;
            this.lblContanctInfo.ForeColor = Color.Black;
            this.lblDescription.ForeColor = Color.Black;
            this.lblEndDate.ForeColor = Color.Black;
            this.lblInfo.ForeColor = Color.Black;
            this.lblNotice.ForeColor = Color.Black;
            this.lblStartDate.ForeColor = Color.Black;
            this.lblTitle.ForeColor = Color.Black;
            this.rButtonExcludeDate.ForeColor = Color.Black;
            this.rButtonIncludeDate.ForeColor = Color.Black;
        }

        public void setTheme2NoticeStage()
        {
            this.panelHeaderNotice.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblCategory.ForeColor = Color.White;
            this.lblContanctInfo.ForeColor = Color.White;
            this.lblDescription.ForeColor = Color.White;
            this.lblEndDate.ForeColor = Color.White;
            this.lblInfo.ForeColor = Color.White;
            this.lblNotice.ForeColor = Color.White;
            this.lblStartDate.ForeColor = Color.White;
            this.lblTitle.ForeColor = Color.White;
            this.rButtonExcludeDate.ForeColor = Color.White;
            this.rButtonIncludeDate.ForeColor = Color.White;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtBoxTitle.Text = "";
            this.cBoxCategory.SelectedIndex = 0;
            this.dtpStartDate.Value = DateTime.Now;
            this.dtpEndDate.Value = DateTime.Now;
            this.rButtonIncludeDate.Checked = true;
            this.rButtonExcludeDate.Checked = false;
            this.txtBoxContactInfo.Text = "";
            this.rTBoxDescription.Text = "";
            this.rTBoxLargeArea.Text = "";
        }

        private void rButtonExcludeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonExcludeDate.Checked)
            {
                dtpEndDate.Enabled = false;
                rButtonIncludeDate.Checked = false;
            }

            else
                dtpEndDate.Enabled = true;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.rTBoxLargeArea.Clear();
            this.rTBoxLargeArea.Text += "*******************************************************************************************\n";
            this.rTBoxLargeArea.Text += "*****************************              Library                **********************************\n";
            this.rTBoxLargeArea.Text += "*******************************************************************************************\n\n";

            this.rTBoxLargeArea.Text += "Title: " + this.txtBoxTitle.Text + "\n\n";
            this.rTBoxLargeArea.Text += "Category: " + this.cBoxCategory.Text + "\n\n";
            this.rTBoxLargeArea.Text += "Start date: " + this.dtpStartDate.Value.ToString() + "\n\n";

            if (rButtonIncludeDate.Checked)
                this.rTBoxLargeArea.Text += "End date: " + this.dtpEndDate.Value.ToString() + "\n\n";

            else
                this.rTBoxLargeArea.Text += "End date: until further notice\n\n";

            this.rTBoxLargeArea.Text += "Contact information: " + this.txtBoxContactInfo.Text + "\n\n";
            this.rTBoxLargeArea.Text += "Description: " + this.rTBoxDescription.Text + "\n\n\n\n";
            this.rTBoxLargeArea.Text += "Signature: ";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rTBoxLargeArea.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           this.printPreviewDialog1.Document = printDocument1;
            adjustPrintDialog();

           this.printPreviewDialog1.Show();
        }

        private void adjustPrintDialog()
        {
            this.printPreviewDialog1.Width = 1200;
            this.printPreviewDialog1.Height = 750;
        }

        public static NoticeStage getInstance()
        {
            if (instance == null)
                instance = new NoticeStage();

            return instance;
        }

        private void NoticeStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
