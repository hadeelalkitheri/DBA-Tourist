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
    public partial class Form8 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9 ();
            f9.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "insert into living values ('" + textBox2.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Your Data Is Done");
            com.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
