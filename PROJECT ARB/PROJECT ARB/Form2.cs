using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PROJECT_ARB
{
    public partial class Form2 : Form
    {                                              //Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = "system";
            string password = "123";
            string username1 = "sara";
            string password1 = "000";
            string username2 = "maryam";
            string password2 = "555";
            if ( textBox1.Text == "system" && textBox2.Text== "123")
            {
                MessageBox.Show("تم تسجيل الدخول كمسؤول");
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();

            }
             else if (textBox1.Text == "sara" && textBox2.Text == "000")
           // else if (textBox1.Text == "hadeel" && textBox2.Text == "000")
            {
                MessageBox.Show("تم تسجيل الدخول كمستخدم عادي");
                this.Hide();
                Form16 f16 = new Form16();
                f16.Show();

            }
            else if (textBox1.Text == "maryam" && textBox2.Text == "555")
            {
                MessageBox.Show("تم تسجيل الدخول كمستخدم عادي");
                this.Hide();
                Form17 f17 = new Form17();
                f17.Show();

            }


            /* OleDbDataAdapter oda = new OleDbDataAdapter("Select count(*) From login Where user_name='" + textBox1.Text + "' and pass= '" + textBox2.Text + "'", com);
             DataTable dt = new DataTable();
             oda.Fill(dt);

             if (dt.Rows[0][0].ToString()=="1")
             {
                 this.Hide();
                 Form3 f3 = new Form3();
                 f3.Show();
             }
             else
             {
                 MessageBox.Show("Please enter correct user and Password");
             }*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try {
                OleDbConnection com2 = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=lolo;Password=123;");
                com2.Open();
                MessageBox.Show("hello");
                com2.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    }

