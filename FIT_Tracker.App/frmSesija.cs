using FIT_Timer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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
        private int sekunde;
        private System.Windows.Forms.Timer timerclose = new System.Windows.Forms.Timer();

        public frmSesija(GodinaStudija? godina, Semestar? semestar, Predmet? predmet)
        {
            InitializeComponent();
            this.godina = godina;
            this.semestar = semestar;
            this.predmet = predmet;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            sekunde = 0;
            Aktivna = false;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            sekunde++;
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            int minute = sekunde / 60;
            int preostalo = sekunde % 60;
            lblTimer.Text = string.Format("{0:D2}:{1:D2}", minute, preostalo);
        }

        private void frmSesija_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = $"{predmet.Naziv}";
            sekunde = 0; 
            UpdateTimer(); 

        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            if (!Aktivna)
            {
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (Aktivna)
            {
                Aktivna = false;
                timer.Stop();
            }
            sekunde = 0;
            UpdateTimer();
            timerclose.Interval = 1000; 
            timerclose.Tick += timerclose_Tick;
            timerclose.Start();
        }

        private void timerclose_Tick(object? sender, EventArgs e)
        {
            timerclose.Stop();

           
            this.Close();
        }
    }
}
