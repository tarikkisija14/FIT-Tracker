namespace FIT_Tracker.App
{
    partial class frmStatistika
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbPredmet = new ComboBox();
            cmbSemestar = new ComboBox();
            cmbGodina = new ComboBox();
            dgvSesijePredmet = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Start = new DataGridViewTextBoxColumn();
            Finish = new DataGridViewTextBoxColumn();
            Trajanje = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label5 = new Label();
            dgvSesijeSedmica = new DataGridView();
            NazivSedmica = new DataGridViewTextBoxColumn();
            PredmetSedmica = new DataGridViewTextBoxColumn();
            StartSedmica = new DataGridViewTextBoxColumn();
            FinishSedmica = new DataGridViewTextBoxColumn();
            TrajanjeSedmica = new DataGridViewTextBoxColumn();
            label6 = new Label();
            dgvSesijeGodina = new DataGridView();
            NazivMjesec = new DataGridViewTextBoxColumn();
            PredmetMjesec = new DataGridViewTextBoxColumn();
            StartMjesec = new DataGridViewTextBoxColumn();
            FinishMjesec = new DataGridViewTextBoxColumn();
            TrajanjeMjesec = new DataGridViewTextBoxColumn();
            lblMjesecno = new Label();
            lbl_Mjesec = new Label();
            lblPredmet = new Label();
            label7 = new Label();
            dataGridView4 = new DataGridView();
            NazivSve = new DataGridViewTextBoxColumn();
            PredmetSve = new DataGridViewTextBoxColumn();
            StartSve = new DataGridViewTextBoxColumn();
            FinishSve = new DataGridViewTextBoxColumn();
            TrajanjeSve = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSesijePredmet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeSedmica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeGodina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 63);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Predmet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 63);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Semestar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 63);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "Godina studija";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(271, 80);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(340, 23);
            cmbPredmet.TabIndex = 9;
            cmbPredmet.SelectedIndexChanged += cmbPredmet_SelectedIndexChanged;
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(182, 81);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(83, 23);
            cmbSemestar.TabIndex = 8;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbGodina
            // 
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(40, 81);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(136, 23);
            cmbGodina.TabIndex = 7;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // dgvSesijePredmet
            // 
            dgvSesijePredmet.AllowUserToAddRows = false;
            dgvSesijePredmet.AllowUserToDeleteRows = false;
            dgvSesijePredmet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijePredmet.Columns.AddRange(new DataGridViewColumn[] { Naziv, Start, Finish, Trajanje });
            dgvSesijePredmet.Location = new Point(40, 119);
            dgvSesijePredmet.Name = "dgvSesijePredmet";
            dgvSesijePredmet.ReadOnly = true;
            dgvSesijePredmet.Size = new Size(571, 150);
            dgvSesijePredmet.TabIndex = 13;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Start
            // 
            Start.DataPropertyName = "Start";
            Start.HeaderText = "Start";
            Start.Name = "Start";
            Start.ReadOnly = true;
            // 
            // Finish
            // 
            Finish.DataPropertyName = "Finish";
            Finish.HeaderText = "Finish";
            Finish.Name = "Finish";
            Finish.ReadOnly = true;
            // 
            // Trajanje
            // 
            Trajanje.DataPropertyName = "Trajanje";
            Trajanje.HeaderText = "Trajanje";
            Trajanje.Name = "Trajanje";
            Trajanje.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 14;
            label1.Text = "Sesije po predmetu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(40, 290);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 15;
            label5.Text = "Sesije ove sedmice";
            // 
            // dgvSesijeSedmica
            // 
            dgvSesijeSedmica.AllowUserToAddRows = false;
            dgvSesijeSedmica.AllowUserToDeleteRows = false;
            dgvSesijeSedmica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijeSedmica.Columns.AddRange(new DataGridViewColumn[] { NazivSedmica, PredmetSedmica, StartSedmica, FinishSedmica, TrajanjeSedmica });
            dgvSesijeSedmica.Location = new Point(40, 314);
            dgvSesijeSedmica.Name = "dgvSesijeSedmica";
            dgvSesijeSedmica.ReadOnly = true;
            dgvSesijeSedmica.Size = new Size(571, 150);
            dgvSesijeSedmica.TabIndex = 16;
            // 
            // NazivSedmica
            // 
            NazivSedmica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivSedmica.HeaderText = "Naziv";
            NazivSedmica.Name = "NazivSedmica";
            NazivSedmica.ReadOnly = true;
            // 
            // PredmetSedmica
            // 
            PredmetSedmica.HeaderText = "Predmet";
            PredmetSedmica.Name = "PredmetSedmica";
            PredmetSedmica.ReadOnly = true;
            // 
            // StartSedmica
            // 
            StartSedmica.HeaderText = "Start";
            StartSedmica.Name = "StartSedmica";
            StartSedmica.ReadOnly = true;
            // 
            // FinishSedmica
            // 
            FinishSedmica.HeaderText = "Finish";
            FinishSedmica.Name = "FinishSedmica";
            FinishSedmica.ReadOnly = true;
            // 
            // TrajanjeSedmica
            // 
            TrajanjeSedmica.HeaderText = "Trajanje";
            TrajanjeSedmica.Name = "TrajanjeSedmica";
            TrajanjeSedmica.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(40, 490);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
            label6.TabIndex = 17;
            label6.Text = "Sesije ovaj mjesec";
            // 
            // dgvSesijeGodina
            // 
            dgvSesijeGodina.AllowUserToAddRows = false;
            dgvSesijeGodina.AllowUserToDeleteRows = false;
            dgvSesijeGodina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijeGodina.Columns.AddRange(new DataGridViewColumn[] { NazivMjesec, PredmetMjesec, StartMjesec, FinishMjesec, TrajanjeMjesec });
            dgvSesijeGodina.Location = new Point(40, 514);
            dgvSesijeGodina.Name = "dgvSesijeGodina";
            dgvSesijeGodina.ReadOnly = true;
            dgvSesijeGodina.Size = new Size(571, 150);
            dgvSesijeGodina.TabIndex = 18;
            // 
            // NazivMjesec
            // 
            NazivMjesec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivMjesec.HeaderText = "Naziv";
            NazivMjesec.Name = "NazivMjesec";
            NazivMjesec.ReadOnly = true;
            // 
            // PredmetMjesec
            // 
            PredmetMjesec.HeaderText = "Predmet";
            PredmetMjesec.Name = "PredmetMjesec";
            PredmetMjesec.ReadOnly = true;
            // 
            // StartMjesec
            // 
            StartMjesec.HeaderText = "Start";
            StartMjesec.Name = "StartMjesec";
            StartMjesec.ReadOnly = true;
            // 
            // FinishMjesec
            // 
            FinishMjesec.HeaderText = "Finish";
            FinishMjesec.Name = "FinishMjesec";
            FinishMjesec.ReadOnly = true;
            // 
            // TrajanjeMjesec
            // 
            TrajanjeMjesec.HeaderText = "Trajanje";
            TrajanjeMjesec.Name = "TrajanjeMjesec";
            TrajanjeMjesec.ReadOnly = true;
            // 
            // lblMjesecno
            // 
            lblMjesecno.AutoSize = true;
            lblMjesecno.Location = new Point(412, 467);
            lblMjesecno.Name = "lblMjesecno";
            lblMjesecno.Size = new Size(38, 15);
            lblMjesecno.TabIndex = 19;
            lblMjesecno.Text = "label7";
            // 
            // lbl_Mjesec
            // 
            lbl_Mjesec.AutoSize = true;
            lbl_Mjesec.Location = new Point(412, 667);
            lbl_Mjesec.Name = "lbl_Mjesec";
            lbl_Mjesec.Size = new Size(38, 15);
            lbl_Mjesec.TabIndex = 20;
            lbl_Mjesec.Text = "label7";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(412, 272);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(38, 15);
            lblPredmet.TabIndex = 21;
            lblPredmet.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(629, 34);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 22;
            label7.Text = "Sve sesije";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { NazivSve, PredmetSve, StartSve, FinishSve, TrajanjeSve });
            dataGridView4.Location = new Point(629, 81);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.Size = new Size(489, 583);
            dataGridView4.TabIndex = 23;
            // 
            // NazivSve
            // 
            NazivSve.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivSve.HeaderText = "Naziv";
            NazivSve.Name = "NazivSve";
            NazivSve.ReadOnly = true;
            // 
            // PredmetSve
            // 
            PredmetSve.HeaderText = "Predmet";
            PredmetSve.Name = "PredmetSve";
            PredmetSve.ReadOnly = true;
            // 
            // StartSve
            // 
            StartSve.HeaderText = "Start";
            StartSve.Name = "StartSve";
            StartSve.ReadOnly = true;
            // 
            // FinishSve
            // 
            FinishSve.HeaderText = "Finish";
            FinishSve.Name = "FinishSve";
            FinishSve.ReadOnly = true;
            // 
            // TrajanjeSve
            // 
            TrajanjeSve.HeaderText = "Trajanje";
            TrajanjeSve.Name = "TrajanjeSve";
            TrajanjeSve.ReadOnly = true;
            // 
            // frmStatistika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 748);
            Controls.Add(dataGridView4);
            Controls.Add(label7);
            Controls.Add(lblPredmet);
            Controls.Add(lbl_Mjesec);
            Controls.Add(lblMjesecno);
            Controls.Add(dgvSesijeGodina);
            Controls.Add(label6);
            Controls.Add(dgvSesijeSedmica);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dgvSesijePredmet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(cmbSemestar);
            Controls.Add(cmbGodina);
            Name = "frmStatistika";
            Text = "frmStatistika";
            Load += frmStatistika_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSesijePredmet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeSedmica).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeGodina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbPredmet;
        private ComboBox cmbSemestar;
        private ComboBox cmbGodina;
        private DataGridView dgvSesijePredmet;
        private Label label1;
        private Label label5;
        private DataGridView dgvSesijeSedmica;
        private Label label6;
        private DataGridView dgvSesijeGodina;
        private Label lblMjesecno;
        private Label lbl_Mjesec;
        private Label lblPredmet;
        private Label label7;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn NazivSedmica;
        private DataGridViewTextBoxColumn PredmetSedmica;
        private DataGridViewTextBoxColumn StartSedmica;
        private DataGridViewTextBoxColumn FinishSedmica;
        private DataGridViewTextBoxColumn TrajanjeSedmica;
        private DataGridViewTextBoxColumn NazivMjesec;
        private DataGridViewTextBoxColumn PredmetMjesec;
        private DataGridViewTextBoxColumn StartMjesec;
        private DataGridViewTextBoxColumn FinishMjesec;
        private DataGridViewTextBoxColumn TrajanjeMjesec;
        private DataGridViewTextBoxColumn NazivSve;
        private DataGridViewTextBoxColumn PredmetSve;
        private DataGridViewTextBoxColumn StartSve;
        private DataGridViewTextBoxColumn FinishSve;
        private DataGridViewTextBoxColumn TrajanjeSve;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Finish;
        private DataGridViewTextBoxColumn Trajanje;
    }
}