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
            dgvSesijeSedmica.AutoGenerateColumns = false;
            dgvSesijeMjesec.AutoGenerateColumns = false;
            //dgvSveSesije.AutoGenerateColumns = false;
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajSedmicnePodatke();
            UcitajMjesecnePodatke();
            UcitajSveSesije();
            PostaviAnchorZaKontrole();
            PrikaziProsjekSedmica();
            PrikaziUkupnoSedmica();
            PrikaziProsjekMjesec();
            PrikaziUkupnoMjesec();
            InitGrid();

        }

        private void InitGrid()
        {
            StilizirajGrid(dgvSesijePredmet);
            StilizirajGrid(dgvSesijeMjesec);
            StilizirajGrid(dgvSesijeSedmica);
        }

        private void StilizirajGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void PrikaziUkupnoMjesec()
        {
            DateTime danas = DateTime.Now;
            int trenutniMjesec = danas.Month;
            int trenutnaGodina = danas.Year;

            var mjesecneSesije = _context.Sesije
                .Where(x => x.Start.Month == trenutniMjesec && x.Start.Year == trenutnaGodina)
                .ToList();

            var trajanja = mjesecneSesije
                .Select(x => ParseTrajanje(x.Trajanje))
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .ToList();

            if (trajanja.Count > 0)
            {
                int ukupnoSekundi = trajanja.Sum();
                int sati = ukupnoSekundi / 3600;
                int minute = (ukupnoSekundi % 3600) / 60;
                int sekunde = ukupnoSekundi % 60;

                if (sati > 0)
                    lblMjesecUkupno.Text = $"Ukupno vrijeme (mjesec): {sati}h {minute:D2}m {sekunde:D2}s";
                else if (minute > 0)
                    lblMjesecUkupno.Text = $"Ukupno vrijeme (mjesec): {minute}m {sekunde:D2}s";
                else
                    lblMjesecUkupno.Text = $"Ukupno vrijeme (mjesec): {sekunde}s";
            }
            else
            {
                lblMjesecUkupno.Text = "Nema podataka za ovaj mjesec.";
            }
        }

        private void PrikaziProsjekMjesec()
        {
            DateTime danas = DateTime.Now;
            int trenutniMjesec = danas.Month;
            int trenutnaGodina = danas.Year;

            var mjesecneSesije = _context.Sesije
                .Where(x => x.Start.Month == trenutniMjesec && x.Start.Year == trenutnaGodina)
                .ToList();

            var trajanja = mjesecneSesije
                .Select(x => ParseTrajanje(x.Trajanje))
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .ToList();

            if (trajanja.Count > 0)
            {
                double prosjecnoTrajanje = trajanja.Average();
                int minute = (int)(prosjecnoTrajanje / 60);
                int sekunde = (int)(prosjecnoTrajanje % 60);

                if (minute > 0)
                    lblMjesec.Text = $"Prosječno vrijeme (mjesec): {minute}m {sekunde:D2}s";
                else
                    lblMjesec.Text = $"Prosječno vrijeme (mjesec): {sekunde}s";
            }
            else
            {
                lblMjesec.Text = "Nema podataka za ovaj mjesec.";
            }
        }

        private void PrikaziUkupnoSedmica()
        {
            DateTime danas = DateTime.Now;
            DateTime pocetakSedmice = danas.AddDays(-(int)danas.DayOfWeek + 1); // Pon

            var sedmicneSesije = _context.Sesije
                .Where(x => x.Start >= pocetakSedmice && x.Start <= danas)
                .ToList();

            var trajanja = sedmicneSesije
                .Select(x => ParseTrajanje(x.Trajanje))
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .ToList();

            if (trajanja.Count > 0)
            {
                int ukupnoSekundi = trajanja.Sum();
                int sati = ukupnoSekundi / 3600;
                int minute = (ukupnoSekundi % 3600) / 60;
                int sekunde = ukupnoSekundi % 60;

                if (sati > 0)
                    lblSedmicnoUkupno.Text = $"Ukupno vrijeme (sedmica): {sati}h {minute:D2}m {sekunde:D2}s";
                else if (minute > 0)
                    lblSedmicnoUkupno.Text = $"Ukupno vrijeme (sedmica): {minute}m {sekunde:D2}s";
                else
                    lblSedmicnoUkupno.Text = $"Ukupno vrijeme (sedmica): {sekunde}s";
            }
            else
            {
                lblSedmicnoUkupno.Text = "Nema podataka za ovu sedmicu.";
            }
        }

        private void PrikaziProsjekSedmica()
        {
            DateTime danas = DateTime.Now;
            DateTime pocetakSedmice = danas.AddDays(-(int)danas.DayOfWeek + 1); // Pon

            var sedmicneSesije = _context.Sesije
                .Where(x => x.Start >= pocetakSedmice && x.Start <= danas)
                .ToList();

            var trajanja = sedmicneSesije
                .Select(x => ParseTrajanje(x.Trajanje))
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .ToList();

            if (trajanja.Count > 0)
            {
                double prosjecnoTrajanje = trajanja.Average();
                int minute = (int)(prosjecnoTrajanje / 60);
                int sekunde = (int)(prosjecnoTrajanje % 60);

                if (minute > 0)
                    lblSedmicno.Text = $"Prosječno vrijeme (sedmica): {minute}m {sekunde:D2}s";
                else
                    lblSedmicno.Text = $"Prosječno vrijeme (sedmica): {sekunde}s";
            }
            else
            {
                lblSedmicno.Text = "Nema podataka za ovu sedmicu.";
            }
        }

        private void PostaviAnchorZaKontrole()
        {
            dgvSesijePredmet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbGodina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSemestar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPredmet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        }


        private void UcitajSveSesije()
        {
            var svesesije = _context.Sesije.ToList();
            //dgvSveSesije.DataSource = null;
            //dgvSveSesije.DataSource = svesesije;
        }

        private void UcitajMjesecnePodatke()
        {
            DateTime danas = DateTime.Now;
            int trenutniMjesec = danas.Month;
            int trenutnaGodina = danas.Year;

            var mjesecneSesije = _context.Sesije
                .Where(x => x.Start.Month == trenutniMjesec && x.Start.Year == trenutnaGodina)
                .ToList();

            dgvSesijeMjesec.DataSource = null;
            dgvSesijeMjesec.DataSource = mjesecneSesije;
        }

        private void UcitajSedmicnePodatke()
        {
            DateTime danas = DateTime.Now;
            int diff = (7 + (danas.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime pocetakSedmice = danas.AddDays(-diff).Date;

            var sedmicneSesije = _context.Sesije
                .Where(x => x.Start >= pocetakSedmice && x.Start <= danas)
                .ToList();

            dgvSesijeSedmica.DataSource = null;
            dgvSesijeSedmica.DataSource = sedmicneSesije;
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
            PrikaziProsjekPredmet();
            PrikaziUkupno();
        }

        private void PrikaziUkupno()
        {
            var predmet = cmbPredmet.SelectedItem as Predmet;
            if (predmet != null)
            {
                var sesije = _context.Sesije.Where(x => x.PredmetId == predmet.Id).ToList();

                var trajanja = sesije
                    .Select(x => ParseTrajanje(x.Trajanje))
                    .Where(x => x.HasValue)
                    .Select(x => x.Value)
                    .ToList();

                if (trajanja.Count > 0)
                {
                    int ukupnoSekundi = trajanja.Sum();
                    int sati = ukupnoSekundi / 3600;
                    int minute = (ukupnoSekundi % 3600) / 60;
                    int sekunde = ukupnoSekundi % 60;

                    if (sati > 0)
                        lblUkupnoPredmet.Text = $"Ukupno vrijeme: {sati}h {minute:D2}m {sekunde:D2}s";
                    else if (minute > 0)
                        lblUkupnoPredmet.Text = $"Ukupno vrijeme: {minute}m {sekunde:D2}s";
                    else
                        lblUkupnoPredmet.Text = $"Ukupno vrijeme: {sekunde}s";
                }
                else
                {
                    lblUkupnoPredmet.Text = "Nema podataka za ovaj predmet.";
                }
            }
        }

        private void PrikaziProsjekPredmet()
        {
            var predmet = cmbPredmet.SelectedItem as Predmet;
            if (predmet != null)
            {
                var sesije = _context.Sesije.Where(x => x.PredmetId == predmet.Id).ToList();

                var trajanja = sesije
                .Select(x => ParseTrajanje(x.Trajanje))
                .Where(x => x.HasValue)
                .Select(x => x.Value)
                .ToList();

                if (trajanja.Count > 0)
                {
                    double prosjecnoTrajanje = trajanja.Average();
                    int minute = (int)(prosjecnoTrajanje / 60);
                    int sekunde = (int)(prosjecnoTrajanje % 60);

                    if (minute > 0)
                        lblPredmet.Text = $"Prosječno vrijeme: {minute}m {sekunde:D2}s";
                    else
                        lblPredmet.Text = $"Prosječno vrijeme: {sekunde}s";
                }
                else
                {
                    lblPredmet.Text = "Nema podataka za ovaj predmet.";
                }


            }
        }

        private int? ParseTrajanje(string trajanje)
        {
            if (string.IsNullOrWhiteSpace(trajanje))
                return null;

            int ukupnoSekundi = 0;
            int sati = 0, minute = 0, sekunde = 0;

            var parts = trajanje.Split(' ');

            foreach (var part in parts)
            {
                if (part.EndsWith("h") && int.TryParse(part.TrimEnd('h'), out int h))
                    sati = h;
                else if (part.EndsWith("m") && int.TryParse(part.TrimEnd('m'), out int m))
                    minute = m;
                else if (part.EndsWith("s") && int.TryParse(part.TrimEnd('s'), out int s))
                    sekunde = s;
            }

            ukupnoSekundi = (sati * 3600) + (minute * 60) + sekunde;
            return ukupnoSekundi;
        }


        private void btnSve_Click(object sender, EventArgs e)
        {
            new frmSveSesije().ShowDialog();
        }

        private void lblPredmet_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPregledTargeta().ShowDialog();
        }
    }
}
