using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REO
{
    public partial class InsertProperty : Form
    {
        private bool edit = false;

        int id;
        
        string type;
        string district;
        string address;
        string region;
        int rooms;
        int square;
        int price;
        string description;
        int floor;
        int number_of_floors;
        int owner_id;
        byte[] imageBytes;

public InsertProperty()
        {
            InitializeComponent();

           
        }
        public InsertProperty(int id,string type,string district,string address,string region,int rooms,int square,int price,string description,int floor,int number_of_floors,int owner_id, byte[] img )
        {
            InitializeComponent();
            edit = true;
            this.id = id;
            this.owner_id = owner_id;
            this.type = type;
            this.district = district;
            this.address = address;
            this.region = region;
            this.rooms = rooms;
            this.square = square;
            this.price = price;
            this.description = description;
            this.floor = floor;
            this.number_of_floors = number_of_floors;
         imageBytes = img;
            comboBox2.SelectedItem = type;
            textBox3.Text = district;
            textBox5.Text = address;
            textBox6.Text = region;
            textBox7.Text = rooms.ToString();
            textBox8.Text = square.ToString();
            textBox9.Text = price.ToString();
            textBox10.Text = description;
            textBox11.Text = floor.ToString();
            textBox2.Text = number_of_floors.ToString();
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Создаем изображение из потока
                Image image = Image.FromStream(ms);

                // Устанавливаем изображение в PictureBox
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Установка режима отображения изображения
            }

        }
        private void InsertProperty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rEODataSet.Property". При необходимости она может быть перемещена или удалена.
            this.propertyTableAdapter1.Fill(this.rEODataSet.Property);
            comboBox1.SelectedValue = owner_id;
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!edit)
            {

            try
            {
                int clientID = int.Parse(comboBox1.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Ви впевнені, що хочете виконати зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    string type = comboBox2.SelectedItem as string;
             

                int value7, value8, value9, value11, value2;
                    byte[] imageBytes;

                    // Преобразуем изображение в массив байтов
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Используйте нужный формат (JPEG, PNG и т.д.)
                        imageBytes = ms.ToArray();
                    }

                    propertyTableAdapter1.InsertQuery(
                            clientID,
                            imageBytes,
                            type,
                            textBox3.Text,
                            textBox5.Text,
                            textBox6.Text,
                            Convert.ToInt32(textBox7.Text),
                            Convert.ToInt32(textBox8.Text),
                            Convert.ToInt32(textBox9.Text),
                            textBox10.Text,
                            Convert.ToInt32(textBox11.Text),
                            Convert.ToInt32(textBox2.Text)
                        );
                    
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
            else
            {
                try
{
                    DialogResult result = MessageBox.Show("Ви впевнені, що хочете виконати зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    byte[] imageBytes;

                // Преобразуем изображение в массив байтов
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); 
                    imageBytes = ms.ToArray();
                }
                propertyTableAdapter1.UpdateQuery(int.Parse(comboBox1.SelectedValue.ToString()),imageBytes,
                    comboBox2.SelectedItem as string, 
                    textBox3.Text,
                    textBox5.Text,
                    textBox6.Text,
                   Convert.ToInt32(textBox7.Text),
                     Convert.ToInt32(textBox8.Text),
                     Convert.ToInt32(textBox9.Text),
                    textBox10.Text,
                      Convert.ToInt32(textBox11.Text),
                   Convert.ToInt32(textBox2.Text), id);
                edit = false;
                    // Your existing code block causing the exception
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Log or display the exception message for further investigation
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }

            this.Close();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                fd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


                if (fd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
      
                        pictureBox1.Image = Image.FromFile(fd.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Установка режима отображения изображения

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              

                int currentPrice = int.Parse(textBox9.Text);
                string district = textBox3.Text;
                string type = comboBox2.SelectedItem.ToString();
                int rooms = int.Parse(textBox7.Text);
                int square = int.Parse(textBox8.Text);

                var a = new Automatize(type, district, rooms, square, currentPrice);
                a.ShowDialog();
                if (PRC.r)
                {
                    textBox9.Text = PRC.prc.ToString();
                    PRC.r = false;  
                }
             
              
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
       


    }
}
