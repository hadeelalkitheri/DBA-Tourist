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
    public partial class Form13 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");
        public Form13()
        {
            InitializeComponent();
        }

       
      
        private void button2_Click(object sender, EventArgs e)
        {
            com.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = com;
            cmd.CommandText = "delete client Where id_client ='" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            com.Close();

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from client", com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Data deleted sucessfully ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand("Select * from client where id_client ='" + textBox1.Text +"'", com);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            com.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["phone_num"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["country"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {

                com.Open();
                OleDbCommand cmd = new OleDbCommand("update client set name='" + textBox2.Text + "',phone_num='" + textBox4.Text + "',country='" + textBox5.Text + "' Where id_client='" + textBox1.Text + "' ",com);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from client ", com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Data updated sucessfully ");
                com.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["phone_num"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["country"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }
    }
}
