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
        }

        private void UcitajSve()
        {
            var svesesije = _context.Sesije.Include(x=>x.Predmet).ToList();
            dgvSveSesije.DataSource = null;
            dgvSveSesije.DataSource = svesesije;
        }
    }
}
