namespace REO
{
    partial class CheckProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rEODataSet = new REO.REODataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableAdapter = new REO.REODataSetTableAdapters.PropertyTableAdapter();
            this.номерНерухомостіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.власникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регіонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кімнатиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поверхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПоверхівDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientTableAdapter1 = new REO.REODataSetTableAdapters.ClientTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEODataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rEODataSet;
            this.bindingSource1.Position = 0;
            // 
            // rEODataSet
            // 
            this.rEODataSet.DataSetName = "REODataSet";
            this.rEODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерНерухомостіDataGridViewTextBoxColumn,
            this.власникDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.адресаDataGridViewTextBoxColumn,
            this.регіонDataGridViewTextBoxColumn,
            this.кімнатиDataGridViewTextBoxColumn,
            this.площаDataGridViewTextBoxColumn,
            this.цінаDataGridViewTextBoxColumn,
            this.описDataGridViewTextBoxColumn,
            this.поверхDataGridViewTextBoxColumn,
            this.кількістьПоверхівDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.propertyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 305);
            this.dataGridView1.TabIndex = 1;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            this.propertyBindingSource.DataSource = this.bindingSource1;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // номерНерухомостіDataGridViewTextBoxColumn
            // 
            this.номерНерухомостіDataGridViewTextBoxColumn.DataPropertyName = "Номер нерухомості";
            this.номерНерухомостіDataGridViewTextBoxColumn.HeaderText = "Номер нерухомості";
            this.номерНерухомостіDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерНерухомостіDataGridViewTextBoxColumn.Name = "номерНерухомостіDataGridViewTextBoxColumn";
            this.номерНерухомостіDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерНерухомостіDataGridViewTextBoxColumn.Width = 125;
            // 
            // власникDataGridViewTextBoxColumn
            // 
            this.власникDataGridViewTextBoxColumn.DataPropertyName = "Власник";
            this.власникDataGridViewTextBoxColumn.HeaderText = "Власник";
            this.власникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.власникDataGridViewTextBoxColumn.Name = "власникDataGridViewTextBoxColumn";
            this.власникDataGridViewTextBoxColumn.Width = 125;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            this.районDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресаDataGridViewTextBoxColumn
            // 
            this.адресаDataGridViewTextBoxColumn.DataPropertyName = "Адреса";
            this.адресаDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.адресаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресаDataGridViewTextBoxColumn.Name = "адресаDataGridViewTextBoxColumn";
            this.адресаDataGridViewTextBoxColumn.Width = 125;
            // 
            // регіонDataGridViewTextBoxColumn
            // 
            this.регіонDataGridViewTextBoxColumn.DataPropertyName = "Регіон";
            this.регіонDataGridViewTextBoxColumn.HeaderText = "Регіон";
            this.регіонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регіонDataGridViewTextBoxColumn.Name = "регіонDataGridViewTextBoxColumn";
            this.регіонDataGridViewTextBoxColumn.Width = 125;
            // 
            // кімнатиDataGridViewTextBoxColumn
            // 
            this.кімнатиDataGridViewTextBoxColumn.DataPropertyName = "Кімнати";
            this.кімнатиDataGridViewTextBoxColumn.HeaderText = "Кімнати";
            this.кімнатиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кімнатиDataGridViewTextBoxColumn.Name = "кімнатиDataGridViewTextBoxColumn";
            this.кімнатиDataGridViewTextBoxColumn.Width = 125;
            // 
            // площаDataGridViewTextBoxColumn
            // 
            this.площаDataGridViewTextBoxColumn.DataPropertyName = "Площа";
            this.площаDataGridViewTextBoxColumn.HeaderText = "Площа";
            this.площаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.площаDataGridViewTextBoxColumn.Name = "площаDataGridViewTextBoxColumn";
            this.площаDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаDataGridViewTextBoxColumn
            // 
            this.цінаDataGridViewTextBoxColumn.DataPropertyName = "Ціна";
            this.цінаDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.цінаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаDataGridViewTextBoxColumn.Name = "цінаDataGridViewTextBoxColumn";
            this.цінаDataGridViewTextBoxColumn.Width = 125;
            // 
            // описDataGridViewTextBoxColumn
            // 
            this.описDataGridViewTextBoxColumn.DataPropertyName = "Опис";
            this.описDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.описDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описDataGridViewTextBoxColumn.Name = "описDataGridViewTextBoxColumn";
            this.описDataGridViewTextBoxColumn.Width = 125;
            // 
            // поверхDataGridViewTextBoxColumn
            // 
            this.поверхDataGridViewTextBoxColumn.DataPropertyName = "Поверх";
            this.поверхDataGridViewTextBoxColumn.HeaderText = "Поверх";
            this.поверхDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.поверхDataGridViewTextBoxColumn.Name = "поверхDataGridViewTextBoxColumn";
            this.поверхDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьПоверхівDataGridViewTextBoxColumn
            // 
            this.кількістьПоверхівDataGridViewTextBoxColumn.DataPropertyName = "Кількість поверхів";
            this.кількістьПоверхівDataGridViewTextBoxColumn.HeaderText = "Кількість поверхів";
            this.кількістьПоверхівDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьПоверхівDataGridViewTextBoxColumn.Name = "кількістьПоверхівDataGridViewTextBoxColumn";
            this.кількістьПоверхівDataGridViewTextBoxColumn.Width = 125;
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "owner_id";
            this.owneridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.Width = 125;
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.MinimumWidth = 6;
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(12, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 148);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Всі"});
            this.comboBox1.Location = new System.Drawing.Point(21, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пошук за адресою";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пошук за районом";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Всі",
            "Квартира",
            "Дім"});
            this.comboBox2.Location = new System.Drawing.Point(320, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(316, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пошук за типом";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пошук за кількістю кімнат";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(604, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(604, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(654, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пошук за ціною";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(701, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "До";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Фільтрувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CheckProperty";
            this.Text = "CheckProperty";
            this.Load += new System.EventHandler(this.CheckProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEODataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private REODataSet rEODataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private REODataSetTableAdapters.PropertyTableAdapter propertyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНерухомостіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn власникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регіонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кімнатиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поверхDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПоверхівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owneridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private REODataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}