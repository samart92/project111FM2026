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
    public partial class frmTestuserlist : Form
    {
        public frmTestuserlist()
        {
            InitializeComponent();
        }

        private void frmTestuserlist_Load(object sender, EventArgs e)
        {
            //var con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=db111MF;Integrated Security=True;Encrypt=False");
            var con = new SqlConnection(Properties.Settings.Default.Dbconnection);
                var sql = "SELECT * FROM tbuser";
                var com = new SqlCommand(sql, con);
                var da = new SqlDataAdapter(com);
                var dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
