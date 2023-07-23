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
 
    public partial class Form1 : Form
    {
        OleDbConnection com = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=SYSTEM;Password=o;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 hh = new Form2();
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value += 4;
            else
            {
                timer1.Enabled = false;
                this.Hide();
                hh.Show();
                
            }
        }
    }
}
