using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REO
{
    public partial class CheckProperty : Form
    {
        private string connection = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
        public CheckProperty()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void CheckProperty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Property". При необходимости она может быть перемещена или удалена.
            this.propertyTableAdapter.Fill(this.rEODataSet.Property);
            LoadDistrictsIntoComboBox();
        }
        private void LoadDistrictsIntoComboBox()
        {
       
            List<string> districtsList = new List<string>();
            districtsList.Add("Всі");
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                 
                    conn.Open();

                   
                    string query = "SELECT DISTINCT District FROM Property";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                    
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                          
                            while (reader.Read())
                            {
                                districtsList.Add(reader["District"].ToString());
                            }
                        }
                    }
                }

                // Заповнення ComboBox даними про райони
                comboBox1.DataSource = districtsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження районів: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string com = $"SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів',Property.owner_id, Property.img \r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.address LIKE '%{textBox1.Text}%'";

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string com;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    if(comboBox1.SelectedItem == "Всі")
                    {
                        com = $"SELECT  \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n";

                    }
                    else
                    {
                         com = $"SELECT \r\n    \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.district = '{comboBox1.SelectedItem}'";

                    }

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string com;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    if (comboBox2.SelectedItem == "Всі")
                    {
                        com = $"SELECT  \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n";

                    }
                    else
                    {
                        com = $"SELECT \r\n    \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.type = '{comboBox2.SelectedItem}'";

                    }

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string com = "SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE "; 
                    if (!string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text))
                    {
                        com += $"Property.price >= {int.Parse(textBox3.Text)}";
                    }
                    else if (string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                    {
                        com += $"Property.price <= {int.Parse(textBox4.Text)}";
                    }
                    else if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                    {
                        com += $"Property.price >= {int.Parse(textBox3.Text)} AND Property.price <= {int.Parse(textBox4.Text)}";
                    }

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string com = $"SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів'\r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.rooms = {textBox2.Text}";

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
