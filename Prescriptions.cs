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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            FillTreatments();

            button2.Visible = false; button4.Visible = false;

            this.PatEgn.DropDownStyle = ComboBoxStyle.DropDown;
            this.PatEgn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.PatEgn.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да напуснете приложението?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        void populate()
        {
            MyPatients Pat = new MyPatients();
            string query = "SELECT PrescId AS '№ рецепта', PatFname AS 'Име', PatLname AS 'Фамилия', PatEgn AS 'ЕГН', TreatName AS 'Лечение', Medicines AS 'Медикаменти' FROM PrescriptionsTbl";

            DataSet ds = Pat.ShowPatient(query);
            PrescriptionsDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT into PrescriptionsTbl values('" + PatFname.Text + "','" + PatLname.Text + "','" + PatEgn.Text + "','" + Treatment.Text + "','" + PatMed.Text + "')";
            MyPatients Pat = new MyPatients();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Рецептата е добавена успешно!");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PatFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalDbDataSet.PrescriptionsTbl' table. You can move, or remove it, as needed.
            this.prescriptionsTblTableAdapter.Fill(this.dentalDbDataSet.PrescriptionsTbl);
            // TODO: This line of code loads data into the 'dentalDbDataSet.PatientsTbl' table. You can move, or remove it, as needed.
            this.patientsTblTableAdapter.Fill(this.dentalDbDataSet.PatientsTbl);
            FillTreatments();
            populate();
        }

        private void PatEgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
            PatEgn.MaxLength = 10;
        }

        private void PatFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void PatMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 8 && e.KeyChar != ' ') e.KeyChar = '\0';
        }

        int key = 0;
 

        private void button4_Click(object sender, EventArgs e)
        {
            PatFname.Text = ""; PatLname.Text = ""; PatEgn.Text = ""; PatMed.Text = "";
            PatFname.Enabled = true; PatLname.Enabled = true; PatEgn.Enabled = true; PatMed.Enabled = true; Treatment.Enabled = true;
            button4.Visible = false; button2.Visible = false; button1.Visible = true; 

        }

        private void PrescriptionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatFname.Text = PrescriptionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatLname.Text = PrescriptionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatEgn.Text = PrescriptionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Treatment.Text = PrescriptionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatMed.Text = PrescriptionsDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (PatFname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatients Pat = new MyPatients();
            if (key == 0)
            {
                MessageBox.Show("Изберете рецепта!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да изтриете записа?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM PrescriptionsTbl WHERE PrescId=" + key + "";

                        Pat.DeletePatient(query);
                        MessageBox.Show("Рецептата е премахната успешно!");
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

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PrescriptionsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PatFname.Enabled = false; PatLname.Enabled = false; PatEgn.Enabled = false; PatMed.Enabled = false; Treatment.Enabled = false;
            button1.Visible = false; button2.Visible = true; button4.Visible = true;
        }
    }
}
