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
    public partial class Treatments : Form
    {
        public Treatments()
        {
            InitializeComponent();
            button3.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyPatients Pat = new MyPatients();
            if (key == 0)
            {
                MessageBox.Show("Изберете лечение!");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM TreatmentsTbl WHERE TreatId=" + key + "";

                    Pat.DeletePatient(query);
                    MessageBox.Show("Лечението е премахнато успешно!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT into TreatmentsTbl values('" + TreatName.Text + "','" + TreatPrice.Text + "','" + TreatDesc.Text + "')";
            MyPatients Pat = new MyPatients();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Лечението е добавено успешно!");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            TreatName.Text = ""; TreatPrice.Text = ""; TreatDesc.Text = "";
        }

        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TreatName.Clear(); TreatPrice.Clear(); TreatDesc.Clear();
            button2.Visible = true; button1.Visible = false; button4.Visible = false; button3.Visible = false;
        }

        void populate()
        {
            MyPatients Pat = new MyPatients();
            string query = "SELECT TreatId AS '№ рецепта', TreatName AS 'Лечение', TreatPrice AS 'Цена (лв.)', TreatDesc AS 'Описание' FROM TreatmentsTbl";

            DataSet ds = Pat.ShowPatient(query);
             TreatmentsDGV.DataSource = ds.Tables[0];
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            populate();
            button1.Hide(); button4.Hide();
        }

        private void TreatmentsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = false; button1.Visible = true; button4.Visible = true;
            
            button1.Show(); button4.Show();
        }

        

        private void TreatmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Visible = true;
            TreatName.Text = TreatmentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatPrice.Text = TreatmentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatDesc.Text = TreatmentsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (TreatName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreatmentsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
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

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Dispose();
        }

        private void TreatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar == ' ') e.KeyChar = '\0';
        }

        private void TreatDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar == ' ') e.KeyChar = '\0';
        }

        private void TreatPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
            TreatPrice.MaxLength = 8;
        }

        private void button3_Click_1(object sender, EventArgs e)
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

                    string query = "UPDATE TreatmentsTbl SET TreatName='" + TreatName.Text + "', TreatPrice='" + TreatPrice.Text + "', TreatDesc='" + TreatDesc.Text + "'WHERE TreatId='" + key + "'";
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
