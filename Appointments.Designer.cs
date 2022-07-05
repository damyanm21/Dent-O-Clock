
namespace DentalClinic
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.ComboBox();
            this.PatFname = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Treatment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Time);
            this.panel3.Controls.Add(this.PatFname);
            this.panel3.Controls.Add(this.PatPhone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.PatLname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.Date);
            this.panel3.Controls.Add(this.Treatment);
            this.panel3.Location = new System.Drawing.Point(277, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 297);
            this.panel3.TabIndex = 1;
            // 
            // Time
            // 
            this.Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Time.FormattingEnabled = true;
            this.Time.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.Time.Location = new System.Drawing.Point(719, 149);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(176, 32);
            this.Time.TabIndex = 45;
            // 
            // PatFname
            // 
            this.PatFname.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatFname.Location = new System.Drawing.Point(224, 38);
            this.PatFname.Name = "PatFname";
            this.PatFname.Size = new System.Drawing.Size(197, 33);
            this.PatFname.TabIndex = 44;
            this.PatFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatFname_KeyPress);
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatPhone.Location = new System.Drawing.Point(224, 146);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(197, 33);
            this.PatPhone.TabIndex = 43;
            this.PatPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatPhone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(96, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Телефон:";
            // 
            // PatLname
            // 
            this.PatLname.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatLname.Location = new System.Drawing.Point(224, 92);
            this.PatLname.Name = "PatLname";
            this.PatLname.Size = new System.Drawing.Size(197, 33);
            this.PatLname.TabIndex = 41;
            this.PatLname.TextChanged += new System.EventHandler(this.PatLname_TextChanged);
            this.PatLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatLname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(96, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Фамилия:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(596, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "Час:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(596, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Дата:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label10.Location = new System.Drawing.Point(596, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Лечение:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label9.Location = new System.Drawing.Point(96, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Име:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(455, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 52);
            this.button2.TabIndex = 28;
            this.button2.Text = "Добавяне";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(719, 92);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(239, 33);
            this.Date.TabIndex = 25;
            // 
            // Treatment
            // 
            this.Treatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Treatment.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Treatment.FormattingEnabled = true;
            this.Treatment.Location = new System.Drawing.Point(719, 32);
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(338, 32);
            this.Treatment.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(345, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 32);
            this.label8.TabIndex = 31;
            this.label8.Text = "Записване на час";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.bunifuTileButton7);
            this.panel1.Controls.Add(this.bunifuTileButton9);
            this.panel1.Controls.Add(this.bunifuTileButton5);
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton6);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.bunifuTileButton8);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 700);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton7.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton7.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 18;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 36;
            this.bunifuTileButton7.LabelText = "Статус";
            this.bunifuTileButton7.Location = new System.Drawing.Point(139, 506);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton7.TabIndex = 28;
            this.bunifuTileButton7.Click += new System.EventHandler(this.bunifuTileButton7_Click);
            // 
            // bunifuTileButton9
            // 
            this.bunifuTileButton9.BackColor = System.Drawing.Color.LightSlateGray;
            this.bunifuTileButton9.color = System.Drawing.Color.LightSlateGray;
            this.bunifuTileButton9.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton9.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton9.Image")));
            this.bunifuTileButton9.ImagePosition = 19;
            this.bunifuTileButton9.ImageZoom = 50;
            this.bunifuTileButton9.LabelPosition = 38;
            this.bunifuTileButton9.LabelText = "Изход";
            this.bunifuTileButton9.Location = new System.Drawing.Point(5, 641);
            this.bunifuTileButton9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuTileButton9.Name = "bunifuTileButton9";
            this.bunifuTileButton9.Size = new System.Drawing.Size(264, 57);
            this.bunifuTileButton9.TabIndex = 30;
            this.bunifuTileButton9.Click += new System.EventHandler(this.bunifuTileButton9_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton5.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 18;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 36;
            this.bunifuTileButton5.LabelText = "Чат";
            this.bunifuTileButton5.Location = new System.Drawing.Point(5, 506);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton5.TabIndex = 29;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton4.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 18;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 36;
            this.bunifuTileButton4.LabelText = "Предписания";
            this.bunifuTileButton4.Location = new System.Drawing.Point(139, 238);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton4.TabIndex = 25;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton6.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 18;
            this.bunifuTileButton6.ImageZoom = 50;
            this.bunifuTileButton6.LabelPosition = 36;
            this.bunifuTileButton6.LabelText = "Плащания";
            this.bunifuTileButton6.Location = new System.Drawing.Point(139, 372);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton6.TabIndex = 27;
            this.bunifuTileButton6.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton3.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 18;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 36;
            this.bunifuTileButton3.LabelText = "Лечения";
            this.bunifuTileButton3.Location = new System.Drawing.Point(5, 238);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton3.TabIndex = 24;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton8.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton8.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 18;
            this.bunifuTileButton8.ImageZoom = 50;
            this.bunifuTileButton8.LabelPosition = 36;
            this.bunifuTileButton8.LabelText = "X-ray снимки";
            this.bunifuTileButton8.Location = new System.Drawing.Point(5, 372);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton8.TabIndex = 26;
            this.bunifuTileButton8.Click += new System.EventHandler(this.bunifuTileButton8_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton2.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.LightCyan;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 18;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 36;
            this.bunifuTileButton2.LabelText = "Пациенти";
            this.bunifuTileButton2.Location = new System.Drawing.Point(139, 104);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton2.TabIndex = 24;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 18;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 36;
            this.bunifuTileButton1.LabelText = "Часове";
            this.bunifuTileButton1.Location = new System.Drawing.Point(5, 104);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(130, 130);
            this.bunifuTileButton1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 100);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(88, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dent O\'Clock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dental Clinic Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(69, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.SteelBlue;
            this.button4.Location = new System.Drawing.Point(650, 639);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 52);
            this.button4.TabIndex = 57;
            this.button4.Text = "Нов час";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(878, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 52);
            this.button1.TabIndex = 55;
            this.button1.Text = "Изтриване";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.AllowUserToResizeColumns = false;
            this.AppointmentsDGV.AllowUserToResizeRows = false;
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDGV.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AppointmentsDGV.Location = new System.Drawing.Point(349, 405);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.RowHeadersWidth = 51;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(935, 212);
            this.AppointmentsDGV.TabIndex = 58;
            this.AppointmentsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDGV_CellClick);
            this.AppointmentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(1375, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 30);
            this.label6.TabIndex = 59;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.bunifuMaterialTextbox2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Enabled = false;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(720, 364);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(205, 38);
            this.bunifuMaterialTextbox2.TabIndex = 60;
            this.bunifuMaterialTextbox2.Text = "Записани часове:";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(1340, -8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 40);
            this.label7.TabIndex = 61;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AppointmentsDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Treatment;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.TextBox PatLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatFname;
        private System.Windows.Forms.ComboBox Time;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label7;
    }
}