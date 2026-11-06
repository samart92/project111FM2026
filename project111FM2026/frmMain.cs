using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project111FM2026
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tesingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var flogin= new frmLogin();
            flogin.TopLevel = false;
            panel1.Controls.Add(flogin);
            flogin.Show();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
                UCMessageBox msg = new UCMessageBox();
            msg.label1.Text = "បាន login រួចរាល់ ";
            panel1.Controls.Add(msg);

        }
    }
}
