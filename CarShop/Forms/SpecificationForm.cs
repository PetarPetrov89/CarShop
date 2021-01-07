using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShop.Services;

namespace CarShop
{
    public partial class SpecificationForm : Form, IComands
    {
        public SpecificationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mbusa.com/vcm/MB/DigitalAssets/pdfmb/ownersmanual/2008_ml320_ml350_ml550_ml63.pdf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bmwusa.com/vehicles/x-models/x5/sports-activity-vehicle/overview.html");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.toyota.com/owners/resources/warranty-owners-manuals/rav4/2020");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://my.dacia.co.uk/content/carfiles/33/duster.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }

        public void Back()
        {
            MainForm b = new MainForm();
            b.Show();
            this.Hide();
        }        
    }
}
