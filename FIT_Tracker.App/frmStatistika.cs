using FIT_Timer.Data;
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
    public partial class frmStatistika : Form
    {
        FITContext _context = new FITContext();
        public string TrajanjeFormatirano { get; set; }

        public frmStatistika()
        {
            InitializeComponent();
            dgvSesijePredmet.AutoGenerateColumns = false;
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();

        }

        private void UcitajSesijePredmet()
        {
            var predmet = cmbPredmet.SelectedItem as Predmet ?? new Predmet();
            if (predmet != null)
            {
                var sesije = _context.Sesije.Where(x => x.PredmetId == predmet.Id).ToList();

               


                dgvSesijePredmet.DataSource = null;
                dgvSesijePredmet.DataSource = sesije;

            }

        }

        private void UcitajPodatke()
        {
            cmbGodina.DataSource = _context.GodinaStudija.ToList();
            cmbGodina.SelectedIndex = 0;
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var godina = cmbGodina.SelectedItem as GodinaStudija ?? new GodinaStudija();
            if (godina != null)
            {

                cmbSemestar.DataSource = _context.Semestri
                    .Where(x => x.GodinaStudijaId == godina.Id)
                    .ToList();
            }
            cmbSemestar.SelectedIndex = 0;
        }

        private void cmbSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {

            var semestar = cmbSemestar.SelectedItem as Semestar ?? new Semestar();
            if (semestar != null)
            {

                cmbPredmet.DataSource = _context.Predmeti.Where(x => x.SemestarId == semestar.Id).ToList();
            }
            cmbPredmet.SelectedIndex = 0;
        }

        private void cmbPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajSesijePredmet();
        }

        


    }
}
