using FIT_Timer.Data;
using FIT_Tracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FIT_Tracker.App
{
    public partial class frmGlavna : Form
    {



        FITContext _context = new FITContext();
        public frmGlavna()
        {
            InitializeComponent();


        }



        private void frmGlavna_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            Tooltips();


        }

        private void Tooltips()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(pictureBox2, "Zapocni sesiju");
            tooltip.SetToolTip(pictureBox3, "Statistika");
            tooltip.SetToolTip(pictureBox4, "Dodaj Target");
            tooltip.SetToolTip(pictureBox5, "Dodaj obavijest");
            tooltip.SetToolTip(pictureBox6, "Info");

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

        private void button1_Click(object sender, EventArgs e)
        {
            var godina = cmbGodina.SelectedItem as GodinaStudija;
            var semestar = cmbSemestar.SelectedItem as Semestar;
            var predmet = cmbPredmet.SelectedItem as Predmet;

            new frmSesija(godina, semestar, predmet).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmStatistika().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var godina = cmbGodina.SelectedItem as GodinaStudija;
            var semestar = cmbSemestar.SelectedItem as Semestar;
            var predmet = cmbPredmet.SelectedItem as Predmet;

            new frmSesija(godina, semestar, predmet).ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new frmStatistika().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new frmNotifikacije().ShowDialog();
        }




        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new frmTarget().ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }
    }


}
