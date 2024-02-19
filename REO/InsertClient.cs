using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace REO
{
    public partial class InsertClient : Form
    {
        private bool edit = false;
        int id;
        string name;
        string phone;
        string email;
        string address;
        public InsertClient()
        {
            InitializeComponent();
        }
        public InsertClient(int id,string name,string phone,string email,string address)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            edit = true;
           
        }
        private void InsertClient_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = phone;
            textBox3.Text = email;
            textBox4.Text = address;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Підтвердіть дію!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!edit)
                {
                    clientTableAdapter1.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                }
                else
                {
                    clientTableAdapter1.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);
                    edit = false;
                }
                this.Close();
            }
        }

      
    }
}
