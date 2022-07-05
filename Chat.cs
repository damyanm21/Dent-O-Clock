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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            chromiumWebBrowser1.Load("web.skype.com");
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

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
