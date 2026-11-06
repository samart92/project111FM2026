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
    public partial class frmMainUI : Form
    {
        public frmMainUI()
        {
            InitializeComponent();
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmLogin loginForm = new frmLogin();
            loginForm.TopLevel = false;
            panel3.Controls.Add(loginForm);
            loginForm.Show();
        }
    }
}
