using FIT_Timer.Data;
using FIT_Tracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Tracker.App
{
    public partial class frmNotifikacije : Form
    {
        private System.Windows.Forms.Timer timerNotifikacija;
        FITContext db = new FITContext();
        private NotifyIcon notifyIcon;
        public frmNotifikacije()
        {
            InitializeComponent();
            UcitajNotifikacije();

            timerNotifikacija = new System.Windows.Forms.Timer();
            timerNotifikacija.Interval = 10000;
            timerNotifikacija.Tick += TimerNotifikacija_Tick;
            timerNotifikacija.Start();

            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Information;
        }

        private void TimerNotifikacija_Tick(object? sender, EventArgs e)
        {
            ProvjeriNotifikacije();
        }

        private void ProvjeriNotifikacije()
        {
            var sada = DateTime.Now;
            var neprocitaneNotifikacije = db.Notifikacija
           .Where(x => x.VrijemeNotifikacije <= sada && !x.isRead)
           .ToList();

            foreach (var notifikacija in neprocitaneNotifikacije)
            {
                SystemSounds.Exclamation.Play();
                notifyIcon.BalloonTipTitle = "Notifikacija";
                notifyIcon.BalloonTipText = notifikacija.Poruka;
                notifyIcon.ShowBalloonTip(5000);

                MessageBox.Show(notifikacija.Poruka, "Notifikacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notifikacija.isRead = true;
            }
            db.SaveChanges();

        }

        private void UcitajNotifikacije()
        {
            lstNotifikacije.Items.Clear();
            var db = new FITContext();
            var notifikacije = db.Notifikacija
                 .OrderByDescending(n => n.VrijemeNotifikacije)
                 .ToList();

            foreach (var notifikacija in notifikacije)
            {
                lstNotifikacije.Items.Add($"{notifikacija.Id}: {notifikacija.Poruka} ({notifikacija.VrijemeNotifikacije})");
            }
        }

        private void lstNotifikacije_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(200, btn.BackColor);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(255, btn.BackColor);
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var db = new FITContext();

            if (db.Notifikacija.Any())
            {
                db.Notifikacija.RemoveRange(db.Notifikacija);
                db.SaveChanges();
                UcitajNotifikacije();
            }
            else
            {
                MessageBox.Show("Lista notifikacija je već prazna!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNovaNotifikacija novaNotifikacijaForm = new frmNovaNotifikacija();
            if (novaNotifikacijaForm.ShowDialog() == DialogResult.OK)
            {
                var notifikacija = new Notifikacija
                {
                    Poruka = novaNotifikacijaForm.Poruka,
                    VrijemeNotifikacije = novaNotifikacijaForm.Vrijeme,
                    isRead = false
                };

                db.Notifikacija.Add(notifikacija);
                db.SaveChanges();
                UcitajNotifikacije();
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lstNotifikacije.SelectedIndex != -1)
            {
                string selectedItem = lstNotifikacije.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(':')[0]);

                var db = new FITContext();

                var notifikacija = db.Notifikacija.Find(id);
                if (notifikacija != null)
                {
                    db.Notifikacija.Remove(notifikacija);
                    db.SaveChanges();
                }


                UcitajNotifikacije();
            }
            else
            {
                MessageBox.Show("Odaberi notifikaciju za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNotifikacije_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotifikacije.Checked)
                timerNotifikacija.Stop();     
            else
                timerNotifikacija.Start();    
        }
    }
}
