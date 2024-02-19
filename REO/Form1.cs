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
using System.Drawing.Printing;

using Excel = Microsoft.Office.Interop.Excel;
namespace REO
{
    public partial class Form1 : Form
    {
        private bool edit;
        private bool click = false;
        private string connection = "Server=DESKTOP-UCNQHCK;Database=REO;Integrated Security=true;";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
          
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
              
                MessageBox.Show("Столбцы не были сгенерированы.");
            }
            this.Width = 600;
          
        }
        int current = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.propertyTableAdapter.Fill(this.rEODataSet.Property);
            this.realtorTableAdapter.Fill(this.rEODataSet.Realtor);
            this.requirementTableAdapter.Fill(this.rEODataSet.Requirement);
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            this.contractTableAdapter.Fill(this.rEODataSet.Contract);
            label1.Text = "Поиск клиента";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible    = false;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientBindingSource;
            label1.Text = "Пошук клієнта";
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible    = false;
            label6.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            current = 1;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                MessageBox.Show("Столбцы не были сгенерированы.");
            }
            
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contractBindingSource;
            current = 4;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            label1.Text = "По клієнту";
            textBox1.Visible = true;
         
            textBox4.Visible = true;
            comboBox1.Visible = false;
            label2.Visible = false;
           
            label5.Visible = true;
            label5.Text = "По адресі";
            label1.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label4.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label10.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                MessageBox.Show("Столбцы не были сгенерированы.");
            }
        }

        private void requirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = requirementBindingSource;
            current = 5;
            textBox1.Visible = true;
            label1.Text = "По ПІБ клієнта";
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                MessageBox.Show("Столбцы не были сгенерированы.");
            }
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label11.Visible = false;
            label12.Visible = true;
            label13.Visible = true;
            dateTimePicker3.Visible = true;
            dateTimePicker4.Visible = true;

        }

        private void realtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= realtorBindingSource;
            label1.Text = "Пошук рієлтора";
            current = 3;
            textBox1.Visible = true;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                MessageBox.Show("Столбцы не были сгенерированы.");
            }
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей запис?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (current == 1)
                    {
                        clientTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        clientTableAdapter.Fill(rEODataSet.Client);
                    }
                    else if (current == 4)
                    {
                        contractTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        contractTableAdapter.Fill(rEODataSet.Contract);
                    }
                    else if (current == 5)
                    {
                        requirementTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        requirementTableAdapter.Fill(rEODataSet.Requirement);
                    }
                    else if (current == 3)
                    {
                        realtorTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        realtorTableAdapter.Fill(rEODataSet.Realtor);
                    }
                    else if (current == 2)
                    {
                        propertyTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        propertyTableAdapter.Fill(rEODataSet.Property);
                    }

                    this.propertyTableAdapter.Fill(this.rEODataSet.Property);
                    this.realtorTableAdapter.Fill(this.rEODataSet.Realtor);
                    this.requirementTableAdapter.Fill(this.rEODataSet.Requirement);
                    this.clientTableAdapter.Fill(this.rEODataSet.Client);
                    this.contractTableAdapter.Fill(this.rEODataSet.Contract);
                    rEODataSet.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(current == 1)
            {
                var f = new InsertClient();
                f.ShowDialog();
                
            }
            if(current == 4)
            {
                var f = new InsertContract();
                f.ShowDialog();
            }
            if(current == 2)
            {
                var k = new InsertProperty();
                k.ShowDialog();
            }
            if (current == 3)
            {
                var rea = new RealtorInsert();
                rea.ShowDialog();
            }
            this.propertyTableAdapter.Fill(this.rEODataSet.Property);
            this.realtorTableAdapter.Fill(this.rEODataSet.Realtor);
            this.requirementTableAdapter.Fill(this.rEODataSet.Requirement);
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            this.contractTableAdapter.Fill(this.rEODataSet.Contract);
            rEODataSet.AcceptChanges();
          
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(current == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string name = Convert.ToString(selectedRow.Cells[1].Value);
                string phone = Convert.ToString(selectedRow.Cells[2].Value);
                string email = Convert.ToString(selectedRow.Cells[3].Value);
                string address = Convert.ToString(selectedRow.Cells[4].Value);
                var a = new InsertClient(id, name, phone, email, address);
                a.ShowDialog();
       
            }
            else if(current == 4) {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                int cid = Convert.ToInt32(selectedRow.Cells[8].Value);
                    int rid = Convert.ToInt32(selectedRow.Cells[9].Value);
                    int pid = Convert.ToInt32(selectedRow.Cells[10].Value); 
                int price = Convert.ToInt32(selectedRow.Cells[4].Value);
                string condition = Convert.ToString(selectedRow.Cells[5].Value);
                string status = Convert.ToString(selectedRow.Cells[6].Value);
                string date = Convert.ToString(selectedRow.Cells[7].Value);

                var a = new InsertContract(id,cid,rid,pid, price, condition, status, date);
                a.ShowDialog();
       
            }
            else if(current == 2)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
          
                string type = Convert.ToString(selectedRow.Cells[2].Value);
                string district = Convert.ToString(selectedRow.Cells[3].Value);
                string address = Convert.ToString(selectedRow.Cells[4].Value);
                string region = Convert.ToString(selectedRow.Cells[5].Value);
                int rooms = Convert.ToInt32(selectedRow.Cells[6].Value);
                int square = Convert.ToInt32(selectedRow.Cells[7].Value);
                int price = Convert.ToInt32(selectedRow.Cells[8].Value);
                string description = Convert.ToString(selectedRow.Cells[9].Value);
                int floor = Convert.ToInt32(selectedRow.Cells[10].Value);
                int number_of_floors = Convert.ToInt32(selectedRow.Cells[11].Value);
                int owner_id = Convert.ToInt32(selectedRow.Cells[12].Value);
            byte[] img = (byte[])selectedRow.Cells[13].Value; 
                var updProperty = new InsertProperty(id, type, district, address, region, rooms, square, price, description, floor, number_of_floors,owner_id,img);
                updProperty.ShowDialog();
         

            }
            if(current == 3)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id  = Convert.ToInt32(selectedRow.Cells[0].Value);
                string login = Convert.ToString(selectedRow.Cells[1].Value);
                string password = Convert.ToString(selectedRow.Cells[2].Value);
                string name = Convert.ToString(selectedRow.Cells[3].Value);
                string email = Convert.ToString(selectedRow.Cells[4].Value);
                string phone = Convert.ToString(selectedRow.Cells[5].Value);
                var reupd = new RealtorInsert(id,login,password,name,email,phone);
                reupd.ShowDialog();
        
            }
            this.propertyTableAdapter.Fill(this.rEODataSet.Property);
            this.realtorTableAdapter.Fill(this.rEODataSet.Realtor);
            this.requirementTableAdapter.Fill(this.rEODataSet.Requirement);
            this.clientTableAdapter.Fill(this.rEODataSet.Client);
            this.contractTableAdapter.Fill(this.rEODataSet.Contract);
            rEODataSet.AcceptChanges();
        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = propertyBindingSource;
            label1.Text = "Пошук за адресою";
            label5.Text = "По району";
            current = 2;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                MessageBox.Show("Столбцы не были сгенерированы.");
            }
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            if (current == 1)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    client_id AS 'Номер клієнта', \r\n    name AS 'ПІБ', \r\n    phone AS 'Телефон', \r\n    email AS 'Електронная почта', \r\n    address AS 'Адрес' \r\nFROM Client WHERE name LIKE '%{textBox1.Text}%'";

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
          if(current == 2) {
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
            if (current == 3)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT realtor_id AS 'Номер рієлтора', login AS 'Логін', password AS 'Пароль', name AS 'ПІБ', email AS 'Електронна почта', phone AS 'Телефон' FROM dbo.Realtor\r\n WHERE name LIKE '%{textBox1.Text}%'";

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
            if(current == 4)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    Contract.contract_id AS 'Номер контракта',\r\n    Client.name AS 'ПІБ клиента',\r\n    Realtor.name AS 'ПІБ рієлтора',\r\n    Property.address AS 'Адреса обєкта',\r\n     Contract.price AS 'Цена',\r\n     Contract.condition AS 'Состояние',\r\n     Contract.status_contract AS 'Статус контракта',\r\n    Contract.date_formation AS 'Дата формирования',\r\nContract.client_id,\r\nContract.realtor_id, Contract.property_id\r\nFROM Contract\r\nJOIN Client ON Client.client_id = Contract.client_id\r\n JOIN Realtor ON  Realtor.realtor_id = Contract.realtor_id \r\nJOIN Property ON Property.property_id = Contract.property_id WHERE Client.name LIKE '%{textBox1.Text}%'";

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
            if(current == 5)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    Requirement.requirement_id AS 'Номер вимоги',\r\n    Client.name AS 'ПІБ клієнта',\r\n    Requirement.type_property AS 'Тип нерухомості',\r\n    Requirement.district AS 'Район',\r\n    Requirement.address AS 'Адреса',\r\n    Requirement.region AS 'Регіон',\r\n    Requirement.rooms AS 'Кількість кімнат',\r\n   Requirement.square AS 'Площа',\r\n    Requirement.price AS 'Ціна',\r\n    Requirement.description AS 'Опис',\r\n    Requirement.floor AS 'Поверх',\r\n    Requirement.number_of_floors AS 'Кількість поверхів',\r\n    Requirement.date_formation AS 'Дата формування',\r\n    Requirement.status_requirement AS 'Статус вимоги'\r\nFROM dbo.Requirement\r\nJOIN Client ON Client.client_id = Requirement.client_id WHERE Client.name LIKE '%{textBox1.Text}%'\r\n";

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

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stat = new Statistic();
            stat.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (current == 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник', \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів',Property.owner_id, Property.img FROM Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.district LIKE '%{textBox4.Text}%'";

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
            if (current == 4)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    Contract.contract_id AS 'Номер контракта',\r\n    Client.name AS 'ПІБ клиента',\r\n    Realtor.name AS 'ПІБ рієлтора',\r\n    Property.address AS 'Адреса обєкта',\r\n     Contract.price AS 'Цена',\r\n     Contract.condition AS 'Состояние',\r\n     Contract.status_contract AS 'Статус контракта',\r\n    Contract.date_formation AS 'Дата формирования',\r\nContract.client_id,\r\nContract.realtor_id, Contract.property_id\r\nFROM Contract\r\nJOIN Client ON Client.client_id = Contract.client_id\r\n JOIN Realtor ON  Realtor.realtor_id = Contract.realtor_id \r\nJOIN Property ON Property.property_id = Contract.property_id WHERE Property.address LIKE '%{textBox4.Text}%'";

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
            if (current == 5)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string com = $"SELECT \r\n    Requirement.requirement_id AS 'Номер вимоги',\r\n    Client.name AS 'ПІБ клієнта',\r\n    Requirement.type_property AS 'Тип нерухомості',\r\n    Requirement.district AS 'Район',\r\n    Requirement.address AS 'Адреса',\r\n    Requirement.region AS 'Регіон',\r\n    Requirement.rooms AS 'Кількість кімнат',\r\n   Requirement.square AS 'Площа',\r\n    Requirement.price AS 'Ціна',\r\n    Requirement.description AS 'Опис',\r\n    Requirement.floor AS 'Поверх',\r\n    Requirement.number_of_floors AS 'Кількість поверхів',\r\n    Requirement.date_formation AS 'Дата формування',\r\n    Requirement.status_requirement AS 'Статус вимоги'\r\nFROM dbo.Requirement\r\nJOIN Client ON Client.client_id = Requirement.client_id WHERE Requirement.district LIKE '%{textBox4.Text}%'\r\n";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current == 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        if(comboBox1.SelectedItem.ToString() == "Все")
                        {
                            string com = $"SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник',\r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів',Property.owner_id, Property.img \r\nFROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id";

                            SqlCommand cmd = new SqlCommand(com, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            string com = $"SELECT \r\n    Property.property_id AS 'Номер нерухомості', \r\n    Client.name AS 'Власник', \r\n  \r\n    Property.type AS 'Тип', \r\n    Property.district AS 'Район', \r\n    Property.address AS 'Адреса', \r\n    Property.region AS 'Регіон', \r\n    Property.rooms AS 'Кімнати', \r\n    Property.square AS 'Площа', \r\n    Property.price AS 'Ціна', \r\n    Property.description AS 'Опис', \r\n    Property.floor AS 'Поверх', \r\n    Property.number_of_floors AS 'Кількість поверхів',Property.owner_id, Property.img FROM dbo.Property\r\nJOIN Client ON Client.client_id = Property.owner_id\r\n WHERE Property.type = '{comboBox1.SelectedItem.ToString()}'";

                            SqlCommand cmd = new SqlCommand(com, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (current == 5)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        if (comboBox1.SelectedItem.ToString() == "Все")
                        {
                            string com = $"SELECT \r\n    Requirement.requirement_id AS 'Номер вимоги',\r\n    Client.name AS 'ПІБ клієнта',\r\n    Requirement.type_property AS 'Тип нерухомості',\r\n    Requirement.district AS 'Район',\r\n    Requirement.address AS 'Адреса',\r\n    Requirement.region AS 'Регіон',\r\n    Requirement.rooms AS 'Кількість кімнат',\r\n   Requirement.square AS 'Площа',\r\n    Requirement.price AS 'Ціна',\r\n    Requirement.description AS 'Опис',\r\n    Requirement.floor AS 'Поверх',\r\n    Requirement.number_of_floors AS 'Кількість поверхів',\r\n    Requirement.date_formation AS 'Дата формування',\r\n    Requirement.status_requirement AS 'Статус вимоги'\r\nFROM dbo.Requirement\r\nJOIN Client ON Client.client_id = Requirement.client_id\r\n";

                            SqlCommand cmd = new SqlCommand(com, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            string com = $"SELECT \r\n    Requirement.requirement_id AS 'Номер вимоги',\r\n    Client.name AS 'ПІБ клієнта',\r\n    Requirement.type_property AS 'Тип нерухомості',\r\n    Requirement.district AS 'Район',\r\n    Requirement.address AS 'Адреса',\r\n    Requirement.region AS 'Регіон',\r\n    Requirement.rooms AS 'Кількість кімнат',\r\n   Requirement.square AS 'Площа',\r\n    Requirement.price AS 'Ціна',\r\n    Requirement.description AS 'Опис',\r\n    Requirement.floor AS 'Поверх',\r\n    Requirement.number_of_floors AS 'Кількість поверхів',\r\n    Requirement.date_formation AS 'Дата формування',\r\n    Requirement.status_requirement AS 'Статус вимоги'\r\nFROM dbo.Requirement\r\nJOIN Client ON Client.client_id = Requirement.client_id WHERE Requirement.type_property = '{comboBox1.SelectedItem}'\r\n";

                            SqlCommand cmd = new SqlCommand(com, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current == 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();

                        string filter = "1=1"; // Початковий фільтр, який завжди буде істинним

                        // Формування умов для фільтрації на основі заповнених полів
                        if (!string.IsNullOrEmpty(comboBox1.SelectedItem?.ToString()))
                        {
                            filter += $" AND Property.type = '{comboBox1.SelectedItem}'";
                        }

                        if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int priceFrom))
                        {
                            filter += $" AND Property.price >= {priceFrom}";
                        }

                        if (!string.IsNullOrEmpty(textBox3.Text) && int.TryParse(textBox3.Text, out int priceTo))
                        {
                            filter += $" AND Property.price <= {priceTo}";
                        }

                        if (!string.IsNullOrEmpty(textBox6.Text) && int.TryParse(textBox6.Text, out int areaFrom))
                        {
                            filter += $" AND Property.square >= {areaFrom}";
                        }

                        if (!string.IsNullOrEmpty(textBox5.Text) && int.TryParse(textBox5.Text, out int areaTo))
                        {
                            filter += $" AND Property.square <= {areaTo}";
                        }

                        string query = $"SELECT Property.property_id AS 'Номер нерухомості', Client.name AS 'Власник', Property.type AS 'Тип', Property.district AS 'Район', Property.address AS 'Адреса', Property.region AS 'Регіон', Property.rooms AS 'Кімнати', Property.square AS 'Площа', Property.price AS 'Ціна', Property.description AS 'Опис', Property.floor AS 'Поверх', Property.number_of_floors AS 'Кількість поверхів', Property.owner_id, Property.img FROM dbo.Property JOIN Client ON Client.client_id = Property.owner_id WHERE {filter}";

                        SqlCommand cmd = new SqlCommand(query, conn);
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

            if (current == 4)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();

                        string com = $@"SELECT 
    Contract.contract_id AS 'Номер контракта',
    Client.name AS 'ПІБ клиента',
    Realtor.name AS 'ПІБ рієлтора',
    Property.address AS 'Адреса обєкта',
    Contract.price AS 'Цена',
    Contract.condition AS 'Состояние',
    Contract.status_contract AS 'Статус контракта',
    Contract.date_formation AS 'Дата формирования',
    Contract.client_id,
    Contract.realtor_id,
    Contract.property_id
FROM Contract
JOIN Client ON Client.client_id = Contract.client_id
JOIN Realtor ON Realtor.realtor_id = Contract.realtor_id
JOIN Property ON Property.property_id = Contract.property_id
WHERE Contract.date_formation BETWEEN '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}'
    AND Contract.price BETWEEN {int.Parse(textBox2.Text)} AND {int.Parse(textBox3.Text)}";


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
            if (current == 5)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                      
                            string com = $@"SELECT    Requirement.requirement_id AS 'Номер вимоги',
Client.name AS 'ПІБ клієнта',    Requirement.type_property AS 'Тип нерухомості',   Requirement.district AS 'Район',
Requirement.address AS 'Адреса',   Requirement.region AS 'Регіон',    Requirement.rooms AS 'Кількість кімнат',
Requirement.square AS 'Площа',    Requirement.price AS 'Ціна',   Requirement.description AS 'Опис',
Requirement.floor AS 'Поверх',    Requirement.number_of_floors AS 'Кількість поверхів',
Requirement.date_formation AS 'Дата формування',   Requirement.status_requirement AS 'Статус вимоги' 
FROM dbo.Requirement 
JOIN Client ON Client.client_id = Requirement.client_id
WHERE Requirement.date_formation BETWEEN '{dateTimePicker3.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker4.Value.ToString("yyyy-MM-dd")}' 
AND Requirement.price BETWEEN {int.Parse(textBox2.Text)} AND {int.Parse(textBox3.Text)}";

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

        private void filtresToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            if (!click)
            {
                this.Width = 810;
                click = true;
            }
         else if(click)
            {
                this.Width = 600;
                click = false;
            }
           
        }
   
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (current == 2)
            {
                Excel.Application cApp = new Excel.Application();
                cApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)cApp.ActiveSheet;

                for (int j = 1; j < dataGridView1.Columns.Count - 2; j++)
                {
                    worksheet.Cells[1, j] = dataGridView1.Columns[j].HeaderText;
                    worksheet.Columns[j].ColumnWidth = 15;
                    
                }
                Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView1.Columns.Count - 2]];
                headerRange.Font.Size = 16;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        worksheet.Cells[i + 2, j] = dataGridView1[j, i].Value?.ToString();
                    }
                }

                cApp.Visible = true;
            }

            if (current == 4)
            {
                Excel.Application cApp = new Excel.Application();
                cApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)cApp.ActiveSheet;
                for (int j = 1; j <= dataGridView1.Columns.Count - 3; j++)
                {
                    worksheet.Cells[1, j] = dataGridView1.Columns[j - 1].HeaderText;
                    worksheet.Columns[j].ColumnWidth = 17;
                }
                Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView1.Columns.Count - 3]];
                headerRange.Font.Size = 16;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 1; j <= dataGridView1.Columns.Count - 3; j++)
                    {
                        worksheet.Cells[i + 2, j] = dataGridView1[j - 1, i].Value?.ToString();
                    }
                }

                cApp.Visible = true;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
           
          
            comboBox1.SelectedItem = "Все";
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 50, y = 50;

            // Печать заголовка "Property Report"
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            e.Graphics.DrawString("Property Report", titleFont, Brushes.Black, x, y);
            y += 30; // Увеличиваем координату y для следующего элемента

            // Печать содержимого DataGridView
            Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, x, y);
        }
    }
}
