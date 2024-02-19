using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace REO
{
    public partial class Autorize : Form
    {
        public Autorize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UCNQHCK;Initial Catalog=REO;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Realtor WHERE login = '{textBox1.Text}' AND password = '{textBox2.Text}'",conn);
            int count = (int)cmd.ExecuteScalar();
            if(count > 0 ) { 
            
                var a = new Form1();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var a = new ClientForm();
            a.Show();
            this.Hide();
        }
    }
}
