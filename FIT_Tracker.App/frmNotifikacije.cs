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
    public partial class frmNotifikacije : Form
    {
        public frmNotifikacije()
        {
            InitializeComponent();
            
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
            if (lstNotifikacije.Items.Count > 0)
            {
                lstNotifikacije.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lista notifikacija je već prazna!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nova = Microsoft.VisualBasic.Interaction.InputBox("Unesi novu notifikaciju:", "Dodaj Notifikaciju", "");
            if (!string.IsNullOrWhiteSpace(nova))
            {
                lstNotifikacije.Items.Add(nova);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lstNotifikacije.SelectedIndex != -1)
            {
                lstNotifikacije.Items.RemoveAt(lstNotifikacije.SelectedIndex);
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
    }
}
