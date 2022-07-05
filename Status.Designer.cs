namespace DentalClinic
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.label8 = new System.Windows.Forms.Label();
            this.patientsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentalDbDataSet = new DentalClinic.DentalDbDataSet();
            this.dentalDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.patientsTblTableAdapter = new DentalClinic.DentalDbDataSetTableAdapters.PatientsTblTableAdapter();
            this.tableAdapterManager = new DentalClinic.DentalDbDataSetTableAdapters.TableAdapterManager();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PatEgn = new System.Windows.Forms.ComboBox();
            this.patientsTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSetBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(388, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 32);
            this.label8.TabIndex = 44;
            this.label8.Text = "Архив на амбулаторни листи";
            // 
            // patientsTblBindingSource
            // 
            this.patientsTblBindingSource.DataMember = "PatientsTbl";
            this.patientsTblBindingSource.DataSource = this.dentalDbDataSet;
            // 
            // dentalDbDataSet
            // 
            this.dentalDbDataSet.DataSetName = "DentalDbDataSet";
            this.dentalDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentalDbDataSetBindingSource
            // 
            this.dentalDbDataSetBindingSource.DataSource = this.dentalDbDataSet;
            this.dentalDbDataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(1077, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 40);
            this.label3.TabIndex = 65;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(1112, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 30);
            this.label6.TabIndex = 64;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(347, 654);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 41);
            this.button3.TabIndex = 104;
            this.button3.Text = "Споделяне";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(671, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 105;
            this.button1.Text = "Изтегляне";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // patientsTblTableAdapter
            // 
            this.patientsTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientsTblTableAdapter = this.patientsTblTableAdapter;
            this.tableAdapterManager.PrescriptionsTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TreatmentsTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DentalClinic.DentalDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label18.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label18.Location = new System.Drawing.Point(403, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 24);
            this.label18.TabIndex = 121;
            this.label18.Text = "ЕГН:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.PatEgn);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(12, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 561);
            this.panel3.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DentalClinic.Properties.Resources._9812323123_15_01_2022;
            this.pictureBox1.Location = new System.Drawing.Point(3, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 516);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // PatEgn
            // 
            this.PatEgn.DataSource = this.patientsTblBindingSource;
            this.PatEgn.DisplayMember = "PatEgn";
            this.PatEgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatEgn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PatEgn.FormattingEnabled = true;
            this.PatEgn.Location = new System.Drawing.Point(459, 3);
            this.PatEgn.Name = "PatEgn";
            this.PatEgn.Size = new System.Drawing.Size(197, 32);
            this.PatEgn.TabIndex = 122;
            this.PatEgn.ValueMember = "PatEgn";
            this.PatEgn.SelectedIndexChanged += new System.EventHandler(this.PatEgn_SelectedIndexChanged);
            this.PatEgn.SelectedValueChanged += new System.EventHandler(this.PatEgn_SelectedValueChanged);
            this.PatEgn.Click += new System.EventHandler(this.PatEgn_Click);
            // 
            // patientsTblBindingSource1
            // 
            this.patientsTblBindingSource1.DataMember = "PatientsTbl";
            this.patientsTblBindingSource1.DataSource = this.dentalDbDataSetBindingSource;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "9812323123_1111111111111.jpeg");
            this.imageList1.Images.SetKeyName(1, "9812323123_15.01.2022.bmp");
            this.imageList1.Images.SetKeyName(2, "9811323245_16.01.2022.bmp");
            this.imageList1.Images.SetKeyName(3, "9412213344_16.01.2022.bmp");
            this.imageList1.Images.SetKeyName(4, "8811123355_17.01.2022.bmp");
            this.imageList1.Images.SetKeyName(5, "9103061234_17.01.2022.bmp");
            this.imageList1.Images.SetKeyName(6, "9902061132_17.01.2022.bmp");
            this.imageList1.Images.SetKeyName(7, "9211049553_17.01.2022.bmp");
            this.imageList1.Images.SetKeyName(8, "8204054352_17.01.2022.bmp");
            this.imageList1.Images.SetKeyName(9, "8902093324_18.01.2022.bmp");
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1140, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalDbDataSetBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dentalDbDataSetBindingSource;
        private DentalDbDataSet dentalDbDataSet;
        private System.Windows.Forms.BindingSource patientsTblBindingSource;
        private DentalDbDataSetTableAdapters.PatientsTblTableAdapter patientsTblTableAdapter;
        private DentalDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox PatEgn;
        private System.Windows.Forms.BindingSource patientsTblBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}