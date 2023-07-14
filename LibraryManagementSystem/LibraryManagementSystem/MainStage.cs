using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainStage : Form
    {
        private static MainStage instance;
        public MainStage()
        {
            InitializeComponent();
        }

        private void MainStage_Load(object sender, EventArgs e)
        {
           
        }

        public void setLblWelcome(String name)
        {
            this.lblWelcome.Text = "Welcome " + name;
        }

        public static MainStage getInstance()
        {
            if (instance == null)
                instance = new MainStage();

            return instance;
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
    }
}
