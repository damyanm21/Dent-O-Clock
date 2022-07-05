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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            this.PatEgn.DropDownStyle = ComboBoxStyle.DropDown;
            this.PatEgn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.PatEgn.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalDbDataSet.PatientsTbl' table. You can move, or remove it, as needed.
            this.patientsTblTableAdapter.Fill(this.dentalDbDataSet.PatientsTbl);

            

        }

        private void PatEgn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(panel3.Width, panel3.Height))
            {
                    panel3.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                    bmp.Save(@"StatusArchives/" + PatEgn.Text + "_last_dental_status" + ".bmp");
                    MessageBox.Show("Амбулаторният лист е създаден успешно!");

            }
        }

        private void PatEgn_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void PatEgn_Click(object sender, EventArgs e)
        {

        }

        private void PatEgn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatEgn.SelectedIndex == 0)
            {
                Bitmap image = new Bitmap(@"Status/8204054352_17.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 1)
            {
                Bitmap image = new Bitmap(@"Status/8811123355_17.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 2)
            {
                Bitmap image = new Bitmap(@"Status/8902093324_18.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 3)
            {
                Bitmap image = new Bitmap(@"Status/9103061234_17.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 4)
            {
                Bitmap image = new Bitmap(@"Status/9211049553_17.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 5)
            {
                Bitmap image = new Bitmap(@"Status/9412213344_16.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 6)
            {
                Bitmap image = new Bitmap(@"Status/9811323245_16.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 7)
            {
                Bitmap image = new Bitmap(@"Status/9812323123_15.01.2022.bmp");
                pictureBox1.Image = image;
            }
            if (PatEgn.SelectedIndex == 8)
            {
                Bitmap image = new Bitmap(@"Status/9902061132_17.01.2022.bmp");
                pictureBox1.Image = image;
            }
        }
    }
}
