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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Tracker.App
{
    public partial class frmSesija : Form
    {
        private GodinaStudija? godina;
        private Semestar? semestar;
        private Predmet? predmet;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool Aktivna;
        private TimeSpan trajanje; 
        private System.Windows.Forms.Timer timerclose = new System.Windows.Forms.Timer();
        FITContext _context = new FITContext();
        private DateTime startTime;

        public frmSesija(GodinaStudija? godina, Semestar? semestar, Predmet? predmet)
        {
            InitializeComponent();
            this.godina = godina;
            this.semestar = semestar;
            this.predmet = predmet;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            trajanje = TimeSpan.Zero; 
            Aktivna = false;
            startTime = DateTime.Now.Date;


        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            trajanje = trajanje.Add(TimeSpan.FromSeconds(1)); 
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            if (trajanje.Hours > 0)
            {
                lblTimer.Text = string.Format("{0}h {1:D2}m {2:D2}s", trajanje.Hours, trajanje.Minutes, trajanje.Seconds);
            }
            else if (trajanje.Minutes > 0)
            {
                lblTimer.Text = string.Format("{0:D2}m {1:D2}s", trajanje.Minutes, trajanje.Seconds);
            }
            else
            {
                lblTimer.Text = string.Format("{0:D2}s", trajanje.Seconds);
            }
        }

        private void frmSesija_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = $"{predmet.Naziv}";
            trajanje = TimeSpan.Zero; 
            UpdateTimer();
           
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(30, 144, 255),
                Color.FromArgb(0, 0, 139),  
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
            btnZapocni.BackColor = Color.RoyalBlue;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnZapocni.BackColor = Color.DodgerBlue;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (Aktivna)
            {
                Aktivna = false;
                timer.Stop();
            }

            frmNazivSesije nazivform=new frmNazivSesije();

            if(nazivform.ShowDialog() == DialogResult.OK)
            {
                SpremiSesiju(nazivform.Naziv);
            }
            else
            {
                trajanje = TimeSpan.Zero; 
                UpdateTimer();
                Task.Delay(1000).ContinueWith(_ => this.Invoke((Action)(() => this.Close())));
                return;
            }


            trajanje = TimeSpan.Zero;
            UpdateTimer();
            Task.Delay(1000).ContinueWith(_ => this.Invoke((Action)(() => this.Close())));
        }

        private void SpremiSesiju(string naziv)
        {
            string trajanjeFormatted;

            if (trajanje.Hours > 0)
                trajanjeFormatted = $"{trajanje.Hours}h {trajanje.Minutes:D2}m {trajanje.Seconds:D2}s";
            else if (trajanje.Minutes > 0)
                trajanjeFormatted = $"{trajanje.Minutes}m {trajanje.Seconds:D2}s";
            else
                trajanjeFormatted = $"{trajanje.Seconds}s";

            var nova = new Sesija
            {
                Naziv = naziv,
                PredmetId = predmet.Id,
                Trajanje = trajanjeFormatted,
                Start = startTime,
                Finish = DateTime.Now
            };

            _context.Sesije.Add(nova);
            _context.SaveChanges();
        }


        private void timerclose_Tick(object? sender, EventArgs e)
        {
            timerclose.Stop();

           
            this.Close();
        }
    }
}
