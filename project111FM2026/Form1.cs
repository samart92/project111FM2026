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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string input = txtInput.Text;
            //string test = "hello";
            ////or declare the variables style
            //var input = txtInput.Text;
            //var test = "hello";

            //if (input == test)
            //{
            //    lblInfor.Text = "Show information";
            //}
            //else
            //{
            //    lblInfor.Text = "";
            //}

            //for clear all controls in flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            if (txtInput.Text == "Admin")
            {
                //10
                for (int i = 0; i < 10; i++)
                {
                    var btn = new Button();
                    btn.Text = "Button " + i;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            else
            {
                //5
                
                for (int i = 0; i < 5; i++)
                {
                    var btn = new Button();
                    btn.Text = "Button " + i;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < 10; i++)
            //{
            //    var btn = new Button();
            //    btn.Text = "Button " + i;
            //    //btn.Text = $"Button {i}";
            //    flowLayoutPanel1.Controls.Add(btn);

            //}
        }
    }
}
