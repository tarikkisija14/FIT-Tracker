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
    public partial class frmPregledTargeta : Form
    {
        private FITContext _context = new FITContext();

        public frmPregledTargeta()
        {
            InitializeComponent();
        }
        private void frmPregledTargeta_Load(object sender, EventArgs e)
        {
            InitGrid();
            UcitajPodatke();
            Redovi();
        }

        private void Redovi()
        {
            foreach (DataGridViewRow row in dgvTargeti.Rows)
            {
                if (row.Cells["Ispunjen"].Value?.ToString() == "DA")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240); 
                }
            }
        }

        private void UcitajPodatke()
        {
          var targeti = _context.Target
          .Include(t => t.Predmet)
          .ToList()
          .Select(t => new
          {
              Predmet = t.Predmet.Naziv,
              Cilj = $"{t.Cilj.TotalHours}h",
              Trenutno = $"{t.TrenutnoVrijeme.TotalHours:F1}h",
              Procenat = $"{t.Procenti:F1}%",
              Ispunjen = t.Ispunjen ? "DA" : "NE"
          })
          .ToList();

            dgvTargeti.DataSource = targeti;
        }

        private void InitGrid()
        {
            dgvTargeti.BorderStyle = BorderStyle.None;
            dgvTargeti.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvTargeti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTargeti.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvTargeti.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvTargeti.BackgroundColor = Color.White;
            dgvTargeti.EnableHeadersVisualStyles = false;
            dgvTargeti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTargeti.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvTargeti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTargeti.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTargeti.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTargeti.RowTemplate.Height = 28;
            
            dgvTargeti.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTargeti.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTargeti.DefaultCellStyle.Padding = new Padding(5);
        }
    }


    
}
