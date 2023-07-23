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
    public partial class Form7 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "insert into services values ('" + textBox1.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Your Data Is Done");
            com.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "select max(id_service)+1 from services";
            object myValue = cmd.ExecuteScalar();
            textBox1.Text = myValue.ToString();
            com.Close();
        }
    }
}
