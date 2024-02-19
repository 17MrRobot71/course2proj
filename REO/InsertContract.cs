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
    public partial class InsertContract : Form
    {
        private bool edit = false;
        int conid;
        int cid;
        int rid;
        int pid;
        int price;
        string condition;
        string status;
        string date;
        public InsertContract()
        {
            InitializeComponent();

        }
        public InsertContract(int conid,int cid,int rid,int pid,int price,string condition,string status,string date)
        {
            InitializeComponent();
            edit = true;
            this.conid = conid;
            this.cid = cid;
            this.rid = rid;
            this.pid = pid;
            this.price = price;
            this.condition = condition;
            this.status = status;
            this.date = date;
           
            comboBox1.SelectedValue = cid;
            comboBox2.SelectedValue = rid;
                comboBox3.SelectedValue = pid;
            textBox4.Text = price.ToString();
            textBox5.Text = condition.ToString();
           textBox6.Text = status.ToString();
            textBox7.Text = date.ToString();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Підтвердіть дію!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!edit)
                {

                    int clientID = int.Parse(comboBox1.SelectedValue.ToString());
                    int realtorID = int.Parse(comboBox2.SelectedValue.ToString());
                    int propertyID = int.Parse(comboBox3.SelectedValue.ToString());
                    int price = int.Parse(textBox4.Text);
                    string condition = textBox5.Text;
                    string statusContract = textBox6.Text;
                    string dateFormation = textBox7.Text;



                    // Вставляем данные в таблицу через ваш объект TableAdapter (предполагается, что он называется contractTableAdapter1)
                    contractTableAdapter1.InsertQuery(clientID, realtorID, propertyID, price, condition, statusContract, dateFormation);

                }
                else
                {
                    contractTableAdapter1.UpdateQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), int.Parse(comboBox3.SelectedValue.ToString()),
                        int.Parse(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, conid);
                    edit = false;
                }
                this.Close();
            }
        }

        private void InsertContract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Property". При необходимости она может быть перемещена или удалена.
            this.propertyTableAdapter.Fill(this.rEODataSet.Property);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Realtor". При необходимости она может быть перемещена или удалена.
            this.realtorTableAdapter.Fill(this.rEODataSet.Realtor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            comboBox1.SelectedValue = cid;
            comboBox2.SelectedValue = rid;
            comboBox3.SelectedValue = pid;

        }
    }
}
