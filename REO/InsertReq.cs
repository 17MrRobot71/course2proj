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
    public partial class InsertReq : Form
    {
        int id =5;
        public InsertReq()
        {
            InitializeComponent();
        }

        private void InsertReq_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Requirement". При необходимости она может быть перемещена или удалена.
            this.requirementTableAdapter.Fill(this.rEODataSet.Requirement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.rEODataSet.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientTableAdapter.InsertQuery(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            rEODataSet.AcceptChanges();
            clientTableAdapter.Fill(rEODataSet.Client);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Підтвердіть дію!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string con = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                // Предположим, что ожидаемый формат даты в SQL: "yyyy-MM-dd HH:mm:ss"
                string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                // Используем formattedDate в запросе SQL
                SqlCommand cmd = new SqlCommand($@"INSERT INTO Requirement(client_id, type_property, district, address, region, rooms, square, price, description, floor, number_of_floors, date_formation, status_requirement) 
VALUES({1}, '{comboBox2.SelectedItem}', '{textBox13.Text}', '{textBox12.Text}', '{textBox6.Text}', {int.Parse(textBox15.Text)}, {int.Parse(textBox14.Text)}, {int.Parse(textBox17.Text)}, '{textBox16.Text}', {int.Parse(textBox11.Text)}, {int.Parse(textBox5.Text)}, '{formattedDate}', '{textBox7.Text}')", connection);

                cmd.ExecuteNonQuery();
                rEODataSet.AcceptChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           




        }
    }
}
