using FIT_Tracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Tracker.App
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            using (var context = new FITContext())
            {

                var sesije = context.Predmeti.ToList();

                if (sesije.Count > 0)
                {
                    MessageBox.Show("Baza je uspešno učitana!");
                }
                else
                {
                    MessageBox.Show("Baza je prazna.");
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
