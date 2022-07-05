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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT into PatientsTbl values('" + PatFname.Text+"','"+PatLname.Text+ "','" +PatEgn.Text + "','" +PatAge.Text + "','" +PatPhone.Text + "','" +PatAddress.Text + "','" +PatIllness.Text + "','" +PatAlergies.Text+"')";
            MyPatients Pat = new MyPatients();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Пациентът е добавен успешно!");
                populate();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        void populate()
        {
            MyPatients Pat = new MyPatients();
            string query = "SELECT PatId AS '№ пациент', PatFname AS 'Име', PatLname AS 'Фамилия', PatEgn AS 'ЕГН', PatAge AS 'Години', PatPhone AS 'Телефон',PatAddress AS 'Адрес', PatAlergies AS 'Алергии', PatIllness AS 'Заболявания' FROM PatientsTbl";

            DataSet ds = Pat.ShowPatient(query);
            PatientsDGV.DataSource = ds.Tables[0];
        }
        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalDbDataSet.PrescriptionsTbl' table. You can move, or remove it, as needed.
            this.prescriptionsTblTableAdapter.Fill(this.dentalDbDataSet.PrescriptionsTbl);
            populate();
            PatFname.Clear(); PatLname.Clear(); PatEgn.Clear(); PatAge.Clear(); PatPhone.Clear(); PatAddress.Clear(); PatAlergies.Clear(); PatIllness.Clear();
            button2.Visible = false; button3.Visible = false; button4.Visible = false;
            
        }
        int key = 0;
        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatFname.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatLname.Text = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatEgn.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatPhone.Text = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatAddress.Text = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
            PatAlergies.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
            PatIllness.Text = PatientsDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (PatFname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatients Pat = new MyPatients();
            if (key == 0)
            {
                MessageBox.Show("Изберете пациент!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да изтриете записа?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) 
                { 
                    try
                {
                    string query = "DELETE FROM PatientsTbl WHERE PatId=" + key + "";

                    Pat.DeletePatient(query);
                    MessageBox.Show("Пациентът е премахнат успешно!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatients Pat = new MyPatients();
            if (key == 0)
            {
                MessageBox.Show("Изберете пациент!");
            }
            else
            {
                try
                {

                    string query = "UPDATE PatientsTbl SET PatFname='" + PatFname.Text + "', PatLname='" + PatLname.Text + "', PatEgn='" + PatEgn.Text + "', PatAge='" + PatAge.Text + "', PatPhone='" + PatPhone.Text + "', PatAddress='" + PatAddress.Text + "',  PatIllness='" + PatIllness.Text + "', PatAlergies='" + PatAlergies.Text + "'WHERE PatId='" + key + "'";
                    Pat.UpdatePatient(query);
                    MessageBox.Show("Промените са записани успешно!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PatientsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = false; button2.Visible = true; button3.Visible = true; button4.Visible = true;
            button3.Text = "Запазване";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatFname.Clear(); PatLname.Clear(); PatEgn.Clear(); PatAge.Clear(); PatPhone.Clear(); PatAddress.Clear(); PatAlergies.Clear(); PatIllness.Clear();
            button1.Visible = true; button2.Visible = false; button3.Visible = false; button4.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
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


        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
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

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
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

        private void bunifuTileButton9_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void PatFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && (e.KeyChar < 'А' || e.KeyChar > 'я')  && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatPhone.MaxLength = 10;
        }

        private void PatEgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatEgn.MaxLength = 10;
        }

        private void PatAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatAge.MaxLength = 3;
        }

        private void PatIllness_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar != ' ')  e.KeyChar = '\0';
        }

        private void PatAlergies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar != ' ') e.KeyChar = '\0';
        }

        private void prescriptionsTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescriptionsTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dentalDbDataSet);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsuranceCheck insuranceCheck = new InsuranceCheck();
            insuranceCheck.Show();
        }
    }
}
