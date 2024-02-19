using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REO
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }
        string connection = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string com = $"SELECT Realtor.name AS 'ПІБ рієлтора', COUNT(Contract.contract_id) AS 'Кількість договорів укладених рієлтором',SUM(Contract.price) AS 'Сума оформлених контрактів'" +
                        $"FROM Contract\r\nJOIN Realtor ON Contract.realtor_id = Realtor.realtor_id\r\nGROUP BY Realtor.name\r\nORDER BY COUNT(Contract.contract_id) DESC, SUM(Contract.price) DESC;\r\n";

                    SqlCommand cmd = new SqlCommand(com, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string com = @"SELECT Realtor.name AS 'ПІБ рієлтора',
                                   AVG(Contract.price) AS 'Середня вартість укладених договорів'
                           FROM Contract
                           JOIN Realtor ON Contract.realtor_id = Realtor.realtor_id
                           WHERE Contract.date_formation BETWEEN @StartDate AND @EndDate
                           GROUP BY Realtor.name
                           ORDER BY AVG(Contract.price) DESC";

                    SqlCommand cmd = new SqlCommand(com, conn);
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string selectedType = comboBox1.SelectedItem.ToString();
                    string com = @"SELECT district AS 'Район', type AS 'Тип нерухомості', AVG(price) AS 'Середня ціна'
                       FROM Property
                       WHERE type = @selectedType
                       GROUP BY district, type";

                    SqlCommand cmd = new SqlCommand(com, conn);
                    cmd.Parameters.AddWithValue("@selectedType", selectedType);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                
                    string com = @"SELECT Client.name AS 'ПІБ Клієнта', COUNT(Requirement.requirement_id) AS 'Кількість вимог'
FROM Client
LEFT JOIN Requirement ON Client.client_id = Requirement.client_id

GROUP BY Client.name
ORDER BY COUNT(Requirement.requirement_id) DESC;
";

                    SqlCommand cmd = new SqlCommand(com, conn);
          


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string com = @"SELECT Property.district AS 'Район',COUNT(Contract.contract_id) AS 'Кількість проданої нерухомості'
 FROM Property
LEFT JOIN Contract ON Property.property_id = Contract.property_id GROUP BY Property.district ORDER BY COUNT(Contract.contract_id) DESC";

                    SqlCommand cmd = new SqlCommand(com, conn);



                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}











