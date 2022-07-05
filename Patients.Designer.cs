
namespace DentalClinic
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.prescriptionsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentalDbDataSet = new DentalClinic.DentalDbDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.prescriptionsTblTableAdapter = new DentalClinic.DentalDbDataSetTableAdapters.PrescriptionsTblTableAdapter();
            this.tableAdapterManager = new DentalClinic.DentalDbDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PatFname = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatLname = new System.Windows.Forms.TextBox();
            this.PatEgn = new System.Windows.Forms.TextBox();
            this.PatAlergies = new System.Windows.Forms.TextBox();
            this.PatIllness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prescriptionsTblBindingSource
            // 
            this.prescriptionsTblBindingSource.DataMember = "PrescriptionsTbl";
            this.prescriptionsTblBindingSource.DataSource = this.dentalDbDataSet;
            // 
            // dentalDbDataSet
            // 
            this.dentalDbDataSet.DataSetName = "DentalDbDataSet";
            this.dentalDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.SteelBlue;
            this.button4.Location = new System.Drawing.Point(503, 641);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 52);
            this.button4.TabIndex = 51;
            this.button4.Text = "Нов Пациент";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(763, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 52);
            this.button2.TabIndex = 49;
            this.button2.Text = "Изтриване";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(342, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Пациенти";
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
            this.panel1.TabIndex = 24;
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
            this.bunifuTileButton9.Click += new System.EventHandler(this.bunifuTileButton9_Click_1);
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
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton2.color = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.SkyBlue;
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
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.AliceBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.LightCyan;
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
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
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
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.bunifuMaterialTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(725, 382);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(230, 38);
            this.bunifuMaterialTextbox1.TabIndex = 22;
            this.bunifuMaterialTextbox1.Text = "Записани пациенти:";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.AllowUserToAddRows = false;
            this.PatientsDGV.AllowUserToDeleteRows = false;
            this.PatientsDGV.AllowUserToResizeColumns = false;
            this.PatientsDGV.AllowUserToResizeRows = false;
            this.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PatientsDGV.Location = new System.Drawing.Point(292, 424);
            this.PatientsDGV.MultiSelect = false;
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.ReadOnly = true;
            this.PatientsDGV.RowHeadersWidth = 51;
            this.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.Size = new System.Drawing.Size(1081, 212);
            this.PatientsDGV.TabIndex = 25;
            this.PatientsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellClick);
            this.PatientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(1375, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 30);
            this.label13.TabIndex = 60;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // prescriptionsTblTableAdapter
            // 
            this.prescriptionsTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientsTblTableAdapter = null;
            this.tableAdapterManager.PrescriptionsTblTableAdapter = this.prescriptionsTblTableAdapter;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TreatmentsTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DentalClinic.DentalDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(438, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Добавяне";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label9.Location = new System.Drawing.Point(88, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Име:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label10.Location = new System.Drawing.Point(89, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Телефон:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(88, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "ЕГН:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(607, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "Алергии:";
            // 
            // PatFname
            // 
            this.PatFname.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatFname.Location = new System.Drawing.Point(237, 3);
            this.PatFname.Name = "PatFname";
            this.PatFname.Size = new System.Drawing.Size(197, 33);
            this.PatFname.TabIndex = 38;
            this.PatFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatFname_KeyPress);
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatPhone.Location = new System.Drawing.Point(237, 195);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(197, 33);
            this.PatPhone.TabIndex = 39;
            this.PatPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatPhone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(88, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Фамилия:";
            // 
            // PatLname
            // 
            this.PatLname.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatLname.Location = new System.Drawing.Point(237, 51);
            this.PatLname.Name = "PatLname";
            this.PatLname.Size = new System.Drawing.Size(197, 33);
            this.PatLname.TabIndex = 41;
            this.PatLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatLname_KeyPress);
            // 
            // PatEgn
            // 
            this.PatEgn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatEgn.Location = new System.Drawing.Point(237, 99);
            this.PatEgn.Name = "PatEgn";
            this.PatEgn.Size = new System.Drawing.Size(197, 33);
            this.PatEgn.TabIndex = 42;
            this.PatEgn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatEgn_KeyPress);
            // 
            // PatAlergies
            // 
            this.PatAlergies.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatAlergies.Location = new System.Drawing.Point(778, 195);
            this.PatAlergies.Multiline = true;
            this.PatAlergies.Name = "PatAlergies";
            this.PatAlergies.Size = new System.Drawing.Size(243, 76);
            this.PatAlergies.TabIndex = 44;
            this.PatAlergies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatAlergies_KeyPress);
            // 
            // PatIllness
            // 
            this.PatIllness.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatIllness.Location = new System.Drawing.Point(778, 104);
            this.PatIllness.Multiline = true;
            this.PatIllness.Name = "PatIllness";
            this.PatIllness.Size = new System.Drawing.Size(243, 76);
            this.PatIllness.TabIndex = 45;
            this.PatIllness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatIllness_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(607, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Заболявания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(89, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Възраст:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(438, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 52);
            this.button3.TabIndex = 50;
            this.button3.Text = "Редактиране";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatAge
            // 
            this.PatAge.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatAge.Location = new System.Drawing.Point(237, 147);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(87, 33);
            this.PatAge.TabIndex = 43;
            this.PatAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatAge_KeyPress);
            // 
            // PatAddress
            // 
            this.PatAddress.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatAddress.Location = new System.Drawing.Point(778, 10);
            this.PatAddress.Multiline = true;
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(243, 74);
            this.PatAddress.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(607, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Адрес:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.PatAddress);
            this.panel3.Controls.Add(this.PatAge);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PatIllness);
            this.panel3.Controls.Add(this.PatAlergies);
            this.panel3.Controls.Add(this.PatEgn);
            this.panel3.Controls.Add(this.PatLname);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.PatPhone);
            this.panel3.Controls.Add(this.PatFname);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(277, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 317);
            this.panel3.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label14.Location = new System.Drawing.Point(1340, -8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 40);
            this.label14.TabIndex = 62;
            this.label14.Text = "-";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1043, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(273, 52);
            this.button5.TabIndex = 63;
            this.button5.Text = "Проверка на осигуровки";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.DataGridView PatientsDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private DentalDbDataSet dentalDbDataSet;
        private System.Windows.Forms.BindingSource prescriptionsTblBindingSource;
        private DentalDbDataSetTableAdapters.PrescriptionsTblTableAdapter prescriptionsTblTableAdapter;
        private DentalDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatFname;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatLname;
        private System.Windows.Forms.TextBox PatEgn;
        private System.Windows.Forms.TextBox PatAlergies;
        private System.Windows.Forms.TextBox PatIllness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
    }
}