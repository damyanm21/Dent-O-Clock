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
    public partial class InsuranceCheck : Form
    {
        public InsuranceCheck()
        {
            InitializeComponent();
            chromiumWebBrowser1.Load("https://portal.nra.bg/home.html#/goto:rep.HealthStatus.home");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
