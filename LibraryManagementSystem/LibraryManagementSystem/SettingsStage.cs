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
    public partial class SettingsStage : Form
    {
        private static SettingsStage instance;
        public SettingsStage()
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

            mainStage.setTheme1MainStage();
            usersStage.setTheme1UsersStage();
        }

        private void btnSetTheme2_Click(object sender, EventArgs e)
        {
            setTheme2SettingsStage();
            MainStage mainStage = MainStage.getInstance();
            UsersStage usersStage = UsersStage.getInstance();

            mainStage.setTheme2MainStage();
            usersStage.setTheme2UsersStage();
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
