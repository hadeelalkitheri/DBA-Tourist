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
    public partial class Form4 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "select max(id_client)+1 from client"; 
            object myValue = cmd.ExecuteScalar();
            textBox1.Text = myValue.ToString();
            com.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dd = dateTimePicker1.Value.Day.ToString() + '/' + dateTimePicker1.Value.Month.ToString() + '/' + dateTimePicker1.Value.Year.ToString();
            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "insert into client values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dd + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            com.Close();
            MessageBox.Show("Insert Your Data Is Done");
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f = new Form16();
            f.Show();
            this.Hide();
        }
    }


        

    }

