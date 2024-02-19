using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REO
{
  
    public partial class RealtorInsert : Form
    {
        bool edit = false;
        int id;
        string login;
        string password;
        string name;
        string email;
        string phone;
        public RealtorInsert()
        {
            InitializeComponent();
        }
        public RealtorInsert(int id,string login,string password,string name,string email,string phone) {
            InitializeComponent();
            edit = true;
            this.id = id;
            this.login = login;
            this.password = password;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.edit = true;
            this.Name = name;
           
            textBox4.Text = login;
            textBox5.Text = password;
            textBox1.Text = name;
            textBox2.Text = email;
            textBox3.Text = phone;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Підтвердіть дію!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!edit)
                {
                    realtorTableAdapter1.InsertQuery(textBox4.Text, textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                }
                else if (edit)
                {
                    realtorTableAdapter1.UpdateQuery(textBox4.Text, textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, id);
                    edit = false;
                    MessageBox.Show("Рієлтор зареєстрован!");
                    Close();
                }
                Close();
            }
        }
    }
}
