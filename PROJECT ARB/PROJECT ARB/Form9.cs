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
    public partial class Form9 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dd = dateTimePicker1.Value.Day.ToString() + '/' + dateTimePicker1.Value.Month.ToString() + '/' + dateTimePicker1.Value.Year.ToString();
            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "insert into directs values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dd + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Your Data Is Done");
            com.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
