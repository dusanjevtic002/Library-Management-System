using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SettingsStage : Form
    {
        private static SettingsStage instance;
        private SettingsStage()
        {
            InitializeComponent();
        }


        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        private void btnSetTheme1_Click(object sender, EventArgs e)
        {
            setTheme1SettingsStage();
            MainStage mainStage = MainStage.getInstance();
            UsersStage usersStage = UsersStage.getInstance();
            NoticeStage noticeStage = NoticeStage.getInstance();
            FaqsStage faqsStage = FaqsStage.getInstance();
            BooksStage booksStage = BooksStage.getInstance();


            mainStage.setTheme1MainStage();
            usersStage.setTheme1UsersStage();
            noticeStage.setTheme1NoticeStage();
            faqsStage.setTheme1FaqsStage();
            booksStage.setTheme1BooksStage();
        }

        private void btnSetTheme2_Click(object sender, EventArgs e)
        {
            setTheme2SettingsStage();
            MainStage mainStage = MainStage.getInstance();
            UsersStage usersStage = UsersStage.getInstance();
            NoticeStage noticeStage = NoticeStage.getInstance();
            FaqsStage faqsStage = FaqsStage.getInstance();
            BooksStage booksStage = BooksStage.getInstance();

            mainStage.setTheme2MainStage();
            usersStage.setTheme2UsersStage();
            noticeStage.setTheme2NoticeStage();
            faqsStage.setTheme2FaqsStage();
            booksStage.setTheme2BooksStage();
        }

        private void setTheme1SettingsStage()
        {
            this.panelHeaderSettings.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblSettings.ForeColor = Color.Black;
        }

        private void setTheme2SettingsStage()
        {
            this.panelHeaderSettings.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblSettings.ForeColor = Color.White;
        }


        public static SettingsStage getInstance()
        {
            if (instance == null)
                instance = new SettingsStage();

            return instance;
        }

        private void SettingsStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
