using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Xrays : Form
    {
        public Xrays()
        {
            InitializeComponent();

            this.PatEgn.DropDownStyle = ComboBoxStyle.DropDown;
            this.PatEgn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.PatEgn.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        string photograph;
        byte[] binaryphoto;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Моля изберете рентгенова снимка.";
            if(file.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(file.OpenFile());
                photograph = file.FileName;
                FileStream fs = new FileStream(photograph, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Dispose();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Dispose();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Treatments treatments = new Treatments();
            treatments.Show();
            this.Dispose();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            prescriptions.Show();
            this.Dispose();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Dispose();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.Show();
            this.Dispose();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Xrays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalDbDataSet1.PatientsTbl' table. You can move, or remove it, as needed.
            this.patientsTblTableAdapter.Fill(this.dentalDbDataSet1.PatientsTbl);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PatEgn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatEgn.SelectedIndex == 0)
            {
                Bitmap image = new Bitmap(@"X-rays/36854a6a2c93f7a6041bdce82d5d7fb1.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 1)
            {
                Bitmap image = new Bitmap(@"X-rays/bigstock-X-ray-Of-The-Oral-Cavity-With-421866614.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 2)
            {
                Bitmap image = new Bitmap(@"X-rays/Dental_X-rays11.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 3)
            {
                Bitmap image = new Bitmap(@"X-rays/dental-xray-2-825x550.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 4)
            {
                Bitmap image = new Bitmap(@"X-rays/imageedit_3_9676207307.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 5)
            {
                Bitmap image = new Bitmap(@"X-rays/images.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 6)
            {
                Bitmap image = new Bitmap(@"X-rays/pediatric-dental-x-rays1.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 7)
            {
                Bitmap image = new Bitmap(@"X-rays/pediatric-dental-x-rays.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 8)
            {
                Bitmap image = new Bitmap(@"X-rays/pediatric-dental-x-rays1.jpg");
                pictureBox2.Image = image;
            }
            if (PatEgn.SelectedIndex == 9)
            {
                Bitmap image = new Bitmap(@"X-rays/The-Science-of-Modern-Dental-X-Rays.jpg");
                pictureBox2.Image = image;
            }
        }
    }
}
