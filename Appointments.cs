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

namespace DentalClinic
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
            button4.Visible = false; button1.Visible = false;
        }
        ConnectionString MyCon = new ConnectionString();
        private void FillTreatments()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TreatName FROM TreatmentsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Treatment", typeof(string));
            dt.Load(rdr);
            Treatment.ValueMember = "TreatName";
            Treatment.DataSource = dt;
            Con.Close();
        }

        void populate()
        {
            MyPatients Pat = new MyPatients();
            string query = "SELECT AppId AS '№ на час',  PatFname AS 'Име', PatLname AS 'Фамилия', Phone AS 'Телефон', Treatment AS 'Лечение',  AppDate AS 'Дата', AppTime AS 'Час' FROM AppointmentsTbl";

            DataSet ds = Pat.ShowPatient(query);
            AppointmentsDGV.DataSource = ds.Tables[0];
        }
        int key = 0;
        private void AppointmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatFname.Text = AppointmentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatLname.Text = AppointmentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = AppointmentsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (PatFname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AppointmentsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        private void button1_Click(object sender, EventArgs e)
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
                        string query = "DELETE FROM AppointmentsTbl WHERE AppId=" + key + "";

                        Pat.DeletePatient(query);
                        MessageBox.Show("Часът е премахнат успешно!");
                        populate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {

                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT into AppointmentsTbl values('" + PatFname.Text + "','" + PatLname.Text + "','" + PatPhone.Text + "','" + Treatment.Text + "','" + Date.Text + "','" + Time.Text + "')";
            MyPatients Pat = new MyPatients();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Часът е записан успешно!");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            PatFname.Text = ""; PatLname.Text = ""; PatPhone.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false; button1.Visible = false;
            FillTreatments();
            PatFname.Clear(); PatLname.Clear(); PatPhone.Clear(); PatPhone.Clear(); Time.Text = "Изберете час";
            button2.Show();
            PatFname.Enabled = true; PatLname.Enabled = true; PatPhone.Enabled = true; Treatment.Enabled = true;
            Date.Enabled = true; Time.Enabled = true; button2.Visible = true;
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            FillTreatments();
            populate();
            PatFname.Clear(); PatLname.Clear(); PatPhone.Clear(); PatPhone.Clear();
        }

        private void AppointmentsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PatFname.Enabled = false; PatLname.Enabled = false; PatPhone.Enabled = false; Treatment.Enabled = false;
            Date.Enabled = false; Time.Enabled = false; button2.Visible = false; button4.Visible = true; button1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Dispose();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            Xrays xrays = new Xrays();
            xrays.Show();
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

        private void PatPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatPhone.MaxLength = 10;
        }

        private void PatFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatLname_TextChanged(object sender, EventArgs e)
        {
        }

        private void PatLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
