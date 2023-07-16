using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainStage : Form
    {
        private static MainStage instance;
        private MainStage()
        {
            InitializeComponent();
        }

        public void setLblWelcome(String name)
        {
            this.lblWelcome.Text = "Welcome " + name;
        }  

        private void MainStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersStage uStage = UsersStage.getInstance();
            uStage.Show();
        }

        public void setTheme1MainStage()
        {
            this.panelHeader.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.panelLeftDock.BackColor = Color.FromArgb(29, 30, 32);
            this.lblLMS.ForeColor = Color.Black;
            this.lblWelcome.ForeColor = Color.Black;
        }

        public void setTheme2MainStage()
        {
            this.panelHeader.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.panelLeftDock.BackColor = Color.FromArgb(50, 49, 71);
            this.lblLMS.ForeColor = Color.White;
            this.lblWelcome.ForeColor = Color.White;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsStage settingsStage = SettingsStage.getInstance();
            settingsStage.Show();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeStage noticeStage = NoticeStage.getInstance();
            noticeStage.Show();
        }

        private void btnFaqs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaqsStage faqsStage = FaqsStage.getInstance();
            faqsStage.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksStage booksStage = BooksStage.getInstance();
            this.Hide();
            booksStage.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionsStage transactionsStage = TransactionsStage.getInstance();
            transactionsStage.Show();
        }

        public static MainStage getInstance()
        {
            if (instance == null)
                instance = new MainStage();

            return instance;
        }
    }
}
