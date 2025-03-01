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
            DizajnDugmica();
            Raspored();
            Pozadina();
            Comboxovi();
           
        }

      

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(30, 144, 255);
        }


        private void Comboxovi()
        {
            foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
            {
                cmb.Font = new Font("Segoe UI", 12);
                cmb.BackColor = Color.White;
                cmb.ForeColor = Color.Black;
                cmb.FlatStyle = FlatStyle.Flat;
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            
        }

        private void Pozadina()
        {
            this.BackColor = Color.FromArgb(245, 245, 245); 

            label1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = false;
            
            label1.Height = 50;
        }

        private void Raspored()
        {
            TableLayoutPanel panelTop = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 4,
                RowCount = 2,
                Padding = new Padding(10),
                AutoSize = false,
                Width = this.Width - 20, 
                Height = 120, 
            };

           
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));

            
            panelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));



            this.Controls.Add(panelTop);
        }
        private void StilizujDugme(Button btn)
        {
            btn.BackColor = Color.FromArgb(76, 132, 255);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
        }

        private void DizajnDugmica()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                StilizujDugme(btn);
            }

        }


        private void UcitajPodatke()
        {
            cmbGodina.DataSource = _context.GodinaStudija.ToList();
            cmbGodina.SelectedIndex = 0;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

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
    }


}
