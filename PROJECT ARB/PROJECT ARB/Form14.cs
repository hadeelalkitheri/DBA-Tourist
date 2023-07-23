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
    public partial class Form14 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL_HAD;User ID=system;Password=h123;");
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            /* if ( textBox1.Text =="" || textBox2.Text == "")
             {
                 MessageBox.Show("Please Enter User Name and Password");
             }
             else
             {
                 try
                 {
                     OleDbCommand cmd;
                     cmd = new OleDbCommand("update login set pass='" + textBox2.Text + "' where user_name= '" + textBox1.Text + "' ", com);
                     com.Open();
                     cmd.ExecuteNonQuery();
                     com.Close();
                     OleDbDataAdapter Da;
                     Da = new OleDbDataAdapter("select * from login", com);
                     DataTable dt = new DataTable();
                     Da.Fill(dt);
                     Form3 f3 = new Form3();
                     f3.ShowDialog();
                     this.Hide();

                 }
                 catch(Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com.Open();
            string createQuery = "CREATE USER \"" + textBox1.Text + "\"" + "IDENTIFIED BY \"" + textBox2.Text + "\"";
            OleDbCommand command = new OleDbCommand(createQuery, com);
            command.ExecuteNonQuery();
            MessageBox.Show("user was successfully created");
            com.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            com.Open();
            string username = textBox1.Text;

            List<string> privileges = new List<string>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string privilege = checkedListBox1.CheckedItems[i].ToString();
                privileges.Add(privilege);
            }

            string str = String.Join(",", privileges);

            string Query = "GRANT " + str + " ON " + textBox3.Text + " TO \"" + username + "\"";
            MessageBox.Show(Query);
            OleDbCommand cm = new OleDbCommand(Query, com);
            cm.ExecuteNonQuery();

            MessageBox.Show("The user's privilege were successfully set");
            com.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
