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
    public partial class frmSveSesije : Form
    {

        FITContext _context = new FITContext();
        public frmSveSesije()
        {
            InitializeComponent();
            dgvSveSesije.AutoGenerateColumns = false;
        }

        private void frmSveSesije_Load(object sender, EventArgs e)
        {
            UcitajSve();
            InitGrid();
        }

        private void InitGrid()
        {
             
        
            dgvSveSesije.BorderStyle = BorderStyle.None;
            dgvSveSesije.BackgroundColor = Color.White;
            dgvSveSesije.EnableHeadersVisualStyles = false;
          
            dgvSveSesije.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSveSesije.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSveSesije.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSveSesije.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSveSesije.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            dgvSveSesije.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSveSesije.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvSveSesije.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSveSesije.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
           
            dgvSveSesije.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSveSesije.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSveSesije.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
          
            
            dgvSveSesije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSveSesije.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


        
        }

        private void UcitajSve()
        {
            var svesesije = _context.Sesije.Include(x=>x.Predmet).ToList();
            dgvSveSesije.DataSource = null;
            dgvSveSesije.DataSource = svesesije;
        }
    }
}
