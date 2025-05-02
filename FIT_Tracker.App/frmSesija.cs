using FIT_Timer.Data;
using FIT_Tracker.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Tracker.App
{
    public partial class frmSesija : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public  System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public  System.Windows.Forms.Timer timerclose = new System.Windows.Forms.Timer();
        public  FITContext _context = new FITContext();
        public  GodinaStudija? godina;
        public  Semestar? semestar;
        public  Predmet? predmet;

        public DateTime startTime;
        public TimeSpan trajanje;
        public bool Aktivna;



        public frmSesija(GodinaStudija? godina, Semestar? semestar, Predmet? predmet)
        {
            InitializeComponent();
            this.godina = godina;
            this.semestar = semestar;
            this.predmet = predmet;

            InitForma();

        }

        private void InitForma()
        {
           
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblPredmet.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblPredmet.ForeColor = Color.SteelBlue;
            lblPredmet.BackColor = Color.Transparent;

           
            trajanje = TimeSpan.Zero;
            startTime = DateTime.Now.Date;
            Aktivna = false;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            
            Button[] dugmici = { btnZapocni, button2, button3 };
            foreach (Button btn in dugmici)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.SteelBlue;
                btn.FlatAppearance.BorderSize = 1;
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            trajanje = trajanje.Add(TimeSpan.FromSeconds(1));
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            string vrijeme =
                trajanje.Hours > 0 ? $"{trajanje.Hours}h {trajanje.Minutes:D2}m {trajanje.Seconds:D2}s" :
                trajanje.Minutes > 0 ? $"{trajanje.Minutes:D2}m {trajanje.Seconds:D2}s" :
                $"{trajanje.Seconds:D2}s";

            lblTimer.Text = vrijeme;
            lblTimer.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblTimer.ForeColor = Aktivna ? Color.Red : Color.LightGray;
            lblTimer.BackColor = Color.SteelBlue;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void frmSesija_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = predmet?.Naziv;
            UpdateTimer();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            using var brush = new LinearGradientBrush(
                ClientRectangle,
                Color.White,
                Color.SteelBlue,
                LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        }


        private void btnZapocni_Click(object sender, EventArgs e)
        {
            if (!Aktivna)
            {
                startTime = DateTime.Now.Date;
                Aktivna = true;
                timer.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Aktivna)
            {
                Aktivna = false;
                timer.Stop();
            }
        }

        private void btnZapocni_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.FromArgb(70, Color.White);
            btn.ForeColor = Color.Black;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.White;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (Aktivna)
            {
                Aktivna = false;
                timer.Stop();
            }

            var nazivForma = new frmNazivSesije();

            if (nazivForma.ShowDialog() == DialogResult.OK)
            {
                SpremiSesiju(nazivForma.Naziv);
            }
            else
            {
                trajanje = TimeSpan.Zero;
                UpdateTimer();
                Task.Delay(1000).ContinueWith(t =>
                {
                    if (this.IsHandleCreated)
                        this.BeginInvoke((Action)(() => this.Close()));
                });
                return;
            }

            trajanje = TimeSpan.Zero;
            UpdateTimer();
            Task.Delay(1000).ContinueWith(t =>
            {
                if (this.IsHandleCreated)
                    this.BeginInvoke((Action)(() => this.Close()));
            });
        }

        private void SpremiSesiju(string naziv)
        {
            string trajanjeFormatted =
                 trajanje.Hours > 0 ? $"{trajanje.Hours}h {trajanje.Minutes:D2}m {trajanje.Seconds:D2}s" :
                 trajanje.Minutes > 0 ? $"{trajanje.Minutes}m {trajanje.Seconds:D2}s" :
                 $"{trajanje.Seconds}s";

            var nova = new Sesija
            {
                Naziv = naziv,
                PredmetId = predmet?.Id ?? 0,
                Trajanje = trajanjeFormatted,
                Start = startTime,
                Finish = DateTime.Now
            };

            _context.Sesije.Add(nova);
            _context.SaveChanges();

            var target = _context.Target.FirstOrDefault(t => t.PredmetId == predmet.Id);

            var trajanja = _context.Sesije
              .Where(x => x.PredmetId == predmet.Id)
              .AsEnumerable() 
              .Select(x => ParseTrajanje(x.Trajanje))
              .Where(x => x != null)
              .Select(x => x.Value)
              .ToList();

            TimeSpan ukupno = TimeSpan.FromSeconds(trajanja.Sum());
            target.TrenutnoVrijeme = ukupno;
            _context.SaveChanges();

            if (target.Ispunjen)
            {
                MessageBox.Show(" Ispunili ste target za ovaj predmet!\nSpremni ste za ispit! ", "Cilj postignut", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private int? ParseTrajanje(string trajanje)
        {
            if (string.IsNullOrWhiteSpace(trajanje)) return null;

            int h = 0, m = 0, s = 0;
            foreach (var part in trajanje.Split(' '))
            {
                if (part.EndsWith("h") && int.TryParse(part.TrimEnd('h'), out int hh)) h = hh;
                else if (part.EndsWith("m") && int.TryParse(part.TrimEnd('m'), out int mm)) m = mm;
                else if (part.EndsWith("s") && int.TryParse(part.TrimEnd('s'), out int ss)) s = ss;
            }

            return h * 3600 + m * 60 + s;
        }

        private void timerclose_Tick(object? sender, EventArgs e)
        {
            timerclose.Stop();
            this.Close();
        }
    }
}
