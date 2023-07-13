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

        private void btnBooks_MouseHover(object sender, EventArgs e)
        {
            this.btnBooks.BackColor = Color.DarkGray;
        }

        private void btnBooks_MouseLeave(object sender, EventArgs e)
        {
            this.btnBooks.BackColor = Color.Gainsboro;
        }
    }
}
