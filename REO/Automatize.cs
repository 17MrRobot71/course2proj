using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REO
{
    public partial class Automatize : Form
    {
        string type;
        string district;
        int rooms;
        int square;
        int price;
       decimal curr;
        public Automatize(string type, string district, int rooms, int square,int price)
        {
            InitializeComponent();
            this.type = type;
            this.district = district;
            this.rooms = rooms;
            this.square = square;
            this.price = price;
        }

        private void Automatize_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {

                int averagePrice = Convert.ToInt32(GetAveragePrice(type, district, rooms, square));
                curr = averagePrice;
                textBox1.Text = averagePrice.ToString();
                textBox2.Text = price.ToString();
                textBox3.Text = Math.Abs(averagePrice - price).ToString();

                // Очистити попередні серії перед додаванням нових
                chart1.Series.Clear();
               

                chart1.Size = new Size(400, 300);
                this.Controls.Add(chart1);

                Series series = new Series();
                Series series2 = new Series();
                series.ChartType = SeriesChartType.Column;
                series.Name = "Рекомендована ціна";
                series2.Name = "Ваша ціна";
                series.Points.AddXY("Рекомендована ціна", (double)averagePrice);
                series2.Points.AddXY("Ваша ціна", (double)price);

                chart1.Series.Add(series);
                chart1.Series.Add(series2);
                if (averagePrice != 0)
                    {
                        if (price > averagePrice + averagePrice*0.1M)
                        {
                            MessageBox.Show("Ціна виявилася занадто високою. Рекомендована ціна: " + averagePrice.ToString());
                        }
                        else if (price < averagePrice - averagePrice * 0.1M)
                        {
                            MessageBox.Show("Ціна виявилася занадто низькою. Рекомендована ціна: " + averagePrice.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Ціна відповідає середній.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Немає даних для порівняння в цьому районі");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            
           

        }
        private decimal GetAveragePrice(string type, string district, int rooms, int square)
        {
            int minSquare = square - 5;
            int maxSquare = square + 5;
            string conn = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(conn);
            string queryString = "SELECT AVG(price) AS average_price FROM Property WHERE type = @type AND district = @district AND rooms = @rooms AND square BETWEEN @minSquare AND @maxSquare;";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@district", district);
            command.Parameters.AddWithValue("@rooms", rooms);
            command.Parameters.AddWithValue("@minSquare", minSquare);
            command.Parameters.AddWithValue("@maxSquare", maxSquare);

            decimal averagePrice = 0;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    averagePrice = Convert.ToDecimal(result);
                }
                else
                {

                    queryString = "SELECT AVG(price) AS average_price FROM Property WHERE type = @type AND rooms = @rooms AND square BETWEEN @minSquare AND @maxSquare;";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@rooms", rooms);
                    command.Parameters.AddWithValue("@minSquare", minSquare);
                    command.Parameters.AddWithValue("@maxSquare", maxSquare);

                    result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        averagePrice = Convert.ToDecimal(result);
                    }
                    MessageBox.Show("В цьому районі не було знайдено подібної нерухомості! Проводиться пошук по всіх районах");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return averagePrice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Підтвердіть дію!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PRC.prc = curr;
                PRC.r = true;
                this.Close();
            }
        }

        private decimal GetMedianPrice(string type, string district, int rooms, int square)
        {
            int minSquare = square - 5;
            int maxSquare = square + 5;
            string conn = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(conn);
            string queryString = "SELECT price FROM Property WHERE type = @type AND district = @district AND rooms = @rooms AND square BETWEEN @minSquare AND @maxSquare;";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@district", district);
            command.Parameters.AddWithValue("@rooms", rooms);
            command.Parameters.AddWithValue("@minSquare", minSquare);
            command.Parameters.AddWithValue("@maxSquare", maxSquare);

            List<decimal> prices = new List<decimal>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    decimal price = Convert.ToDecimal(reader["price"]);
                    prices.Add(price);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            // Обчислення медіани
            decimal medianPrice = CalculateMedian(prices);
            return medianPrice;
        }

        // Функція для обчислення медіани
        private decimal CalculateMedian(List<decimal> prices)
        {
            prices.Sort();
            int count = prices.Count;
            if (count % 2 == 0)
            {
                int middle = count / 2;
                decimal median = (prices[middle - 1] + prices[middle]) / 2.0M;
                return median;
            }
            else
            {
                return prices[count / 2];
            }
        }

    }
}
