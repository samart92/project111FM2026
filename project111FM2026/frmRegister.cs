using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project111FM2026
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //var myconstring = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=db111MF;Integrated Security=True;Encrypt=False";
            var con = new SqlConnection(Properties.Settings.Default.Dbconnection);
            var str = $"INSERT INTO tbUser(username,password,email,phone) values('{txtUserName.Text}','{txtPassword.Text}','{txtEmail.Text}','{txtPhone.Text}')";
            var cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //MessageBox.Show("User Registered Successfully");

            var fm = new frmTestuserlist();
            fm.Show();





          


        }


    }
}
