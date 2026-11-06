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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            //string[] userName = { "ch", "da", "ka" };
            //string[] password = { "ch", "da", "ka" };
            //bool t = false;
            //for (int i = 0; i < userName.Length; i++) {
            //    if(userName[i] == txtName.Text)
            //    {
            //        t= true;
            //        break;                    
            //    }

            //}
            //if (t == true) {
            //    var fm = new frmMain();
            //    fm.Show();
            //   this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Login Failed");
            //}

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var fm = new frmRegister();
            fm.TopLevel = false;

            //var main = new frmMainUI();
            var main = Application.OpenForms["frmMainUI"] as frmMainUI;
            main.panel3.Controls.Add(fm);
            fm.Show();            

            this.Close();

        }
    }
}
