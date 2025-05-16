namespace FIT_Tracker.App
{
    partial class frmSveSesije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSveSesije = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Start = new DataGridViewTextBoxColumn();
            Finish = new DataGridViewTextBoxColumn();
            Trajanje = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSveSesije).BeginInit();
            SuspendLayout();
            // 
            // dgvSveSesije
            // 
            dgvSveSesije.AllowUserToAddRows = false;
            dgvSveSesije.AllowUserToDeleteRows = false;
            dgvSveSesije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSveSesije.Columns.AddRange(new DataGridViewColumn[] { Naziv, Predmet, Start, Finish, Trajanje });
            dgvSveSesije.Location = new Point(23, 36);
            dgvSveSesije.Name = "dgvSveSesije";
            dgvSveSesije.ReadOnly = true;
            dgvSveSesije.Size = new Size(861, 458);
            dgvSveSesije.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Start
            // 
            Start.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Start.DataPropertyName = "Start";
            Start.HeaderText = "Start";
            Start.Name = "Start";
            Start.ReadOnly = true;
            // 
            // Finish
            // 
            Finish.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Finish.DataPropertyName = "Finish";
            Finish.HeaderText = "Finish";
            Finish.Name = "Finish";
            Finish.ReadOnly = true;
            // 
            // Trajanje
            // 
            Trajanje.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Trajanje.DataPropertyName = "Trajanje";
            Trajanje.HeaderText = "Trajanje";
            Trajanje.Name = "Trajanje";
            Trajanje.ReadOnly = true;
            // 
            // frmSveSesije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 522);
            Controls.Add(dgvSveSesije);
            Name = "frmSveSesije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sve sesije";
            Load += frmSveSesije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSveSesije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSveSesije;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Finish;
        private DataGridViewTextBoxColumn Trajanje;
    }
}