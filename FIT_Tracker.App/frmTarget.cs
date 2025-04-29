using FIT_Timer.Data;
using FIT_Tracker.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmTarget : Form
    {

        FITContext _context = new FITContext();

        public frmTarget()
        {
            InitializeComponent();
        }



        private void frmTarget_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "Dodaj Target za Predmet";
            this.BackColor = Color.WhiteSmoke;

            btnSnimi.Text = "Snimi Target";
            btnSnimi.BackColor = Color.SteelBlue;
            btnSnimi.ForeColor = Color.White;
            btnSnimi.FlatStyle = FlatStyle.Flat;
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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmet.SelectedItem as Predmet;
            if (predmet != null && BrojSati.Value > 0)
            {
                var postoji = _context.Target.Any(x => x.PredmetId == predmet.Id);

                if (postoji)
                {
                    MessageBox.Show("Target za ovaj predmet već postoji.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var target = new Target
                {
                    PredmetId = predmet.Id,
                    Cilj = TimeSpan.FromHours((double)BrojSati.Value),
                    TrenutnoVrijeme = TimeSpan.Zero,
                    DatumPostavljanja = DateTime.Now,
                    Ispunjen = false
                };

                _context.Target.Add(target);
                _context.SaveChanges();

                MessageBox.Show("Target uspješno dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();



            }
            else
            {
                MessageBox.Show("Odaberite predmet i unesite validan broj sati.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPregledTargeta().ShowDialog();
        }
    }
}
