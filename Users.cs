using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();

            this.PatEgn.DropDownStyle = ComboBoxStyle.DropDown;
            this.PatEgn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.PatEgn.AutoCompleteSource = AutoCompleteSource.ListItems;
            pictureBox2.SendToBack(); pictureBox2.BackColor = Color.Transparent;
            textBox1.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            Xrays xrays = new Xrays();
            xrays.Show();
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

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar != ' ') e.KeyChar = '\0';
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar != ' ') e.KeyChar = '\0';
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
           // textBox38.MaxLength = 10;
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            //textBox38.MaxLength = 20;
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ':';
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalDbDataSet.PatientsTbl' table. You can move, or remove it, as needed.
            this.patientsTblTableAdapter.Fill(this.dentalDbDataSet.PatientsTbl);

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(panel3.Width, panel3.Height))
            {
                if (patFname.Text != "" && patLname.Text != "" && patAddress.Text != "" && DentistFname.Text != "" && DentistLname.Text != "" && Nzok.Text != "" && AmbList.Text != "" && Date.Text != "" && Time.Text != "" && patIllness.Text != "" && patAlergies.Text != "" && Diagnosis.Text != "" && ToothNum.Text != "" && Intervention.Text != "")
                {
                    panel3.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(@"Status/" + PatEgn.Text + "_" + Date.Text + ".jpeg");
                    MessageBox.Show("Амбулаторният лист е създаден успешно!");
                }
                else MessageBox.Show("Моля попълнете всички полета!");
                
            }
        }

        private void Dentist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textBox37_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatEgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatEgn.MaxLength = 10;
        }

        private void patIllness_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar == ' ') e.KeyChar = '\0';
        }

        private void patAlergies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar == ' ') e.KeyChar = '\0';
        }
    }
}
