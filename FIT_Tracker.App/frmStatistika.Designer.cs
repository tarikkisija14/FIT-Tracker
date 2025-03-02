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
            dgvSesijeMjesec = new DataGridView();
            NazivMjesec = new DataGridViewTextBoxColumn();
            PredmetMjesec = new DataGridViewTextBoxColumn();
            StartMjesec = new DataGridViewTextBoxColumn();
            FinishMjesec = new DataGridViewTextBoxColumn();
            TrajanjeMjesec = new DataGridViewTextBoxColumn();
            lblMjesecno = new Label();
            lbl_Mjesec = new Label();
            lblPredmet = new Label();
            btnSve = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSesijePredmet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeSedmica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeMjesec).BeginInit();
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
            cmbPredmet.BackColor = Color.White;
            cmbPredmet.FlatStyle = FlatStyle.Flat;
            cmbPredmet.ForeColor = Color.Black;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(271, 80);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(340, 23);
            cmbPredmet.TabIndex = 9;
            cmbPredmet.SelectedIndexChanged += cmbPredmet_SelectedIndexChanged;
            // 
            // cmbSemestar
            // 
            cmbSemestar.BackColor = Color.White;
            cmbSemestar.FlatStyle = FlatStyle.Flat;
            cmbSemestar.ForeColor = Color.Black;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(182, 81);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(83, 23);
            cmbSemestar.TabIndex = 8;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbGodina
            // 
            cmbGodina.BackColor = Color.White;
            cmbGodina.FlatStyle = FlatStyle.Flat;
            cmbGodina.ForeColor = Color.Black;
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
            dgvSesijePredmet.BackgroundColor = Color.White;
            dgvSesijePredmet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijePredmet.Columns.AddRange(new DataGridViewColumn[] { Naziv, Start, Finish, Trajanje });
            dgvSesijePredmet.GridColor = Color.FromArgb(224, 224, 224);
            dgvSesijePredmet.Location = new Point(40, 119);
            dgvSesijePredmet.Name = "dgvSesijePredmet";
            dgvSesijePredmet.ReadOnly = true;
            dgvSesijePredmet.Size = new Size(684, 150);
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
            dgvSesijeSedmica.BackgroundColor = Color.White;
            dgvSesijeSedmica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijeSedmica.Columns.AddRange(new DataGridViewColumn[] { NazivSedmica, PredmetSedmica, StartSedmica, FinishSedmica, TrajanjeSedmica });
            dgvSesijeSedmica.GridColor = Color.FromArgb(224, 224, 224);
            dgvSesijeSedmica.Location = new Point(40, 314);
            dgvSesijeSedmica.Name = "dgvSesijeSedmica";
            dgvSesijeSedmica.ReadOnly = true;
            dgvSesijeSedmica.Size = new Size(684, 150);
            dgvSesijeSedmica.TabIndex = 16;
            // 
            // NazivSedmica
            // 
            NazivSedmica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivSedmica.DataPropertyName = "Naziv";
            NazivSedmica.HeaderText = "Naziv";
            NazivSedmica.Name = "NazivSedmica";
            NazivSedmica.ReadOnly = true;
            // 
            // PredmetSedmica
            // 
            PredmetSedmica.DataPropertyName = "Predmet";
            PredmetSedmica.HeaderText = "Predmet";
            PredmetSedmica.Name = "PredmetSedmica";
            PredmetSedmica.ReadOnly = true;
            // 
            // StartSedmica
            // 
            StartSedmica.DataPropertyName = "Start";
            StartSedmica.HeaderText = "Start";
            StartSedmica.Name = "StartSedmica";
            StartSedmica.ReadOnly = true;
            // 
            // FinishSedmica
            // 
            FinishSedmica.DataPropertyName = "Finish";
            FinishSedmica.HeaderText = "Finish";
            FinishSedmica.Name = "FinishSedmica";
            FinishSedmica.ReadOnly = true;
            // 
            // TrajanjeSedmica
            // 
            TrajanjeSedmica.DataPropertyName = "Trajanje";
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
            // dgvSesijeMjesec
            // 
            dgvSesijeMjesec.AllowUserToAddRows = false;
            dgvSesijeMjesec.AllowUserToDeleteRows = false;
            dgvSesijeMjesec.BackgroundColor = Color.White;
            dgvSesijeMjesec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesijeMjesec.Columns.AddRange(new DataGridViewColumn[] { NazivMjesec, PredmetMjesec, StartMjesec, FinishMjesec, TrajanjeMjesec });
            dgvSesijeMjesec.GridColor = Color.FromArgb(224, 224, 224);
            dgvSesijeMjesec.Location = new Point(40, 514);
            dgvSesijeMjesec.Name = "dgvSesijeMjesec";
            dgvSesijeMjesec.ReadOnly = true;
            dgvSesijeMjesec.Size = new Size(684, 150);
            dgvSesijeMjesec.TabIndex = 18;
            // 
            // NazivMjesec
            // 
            NazivMjesec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivMjesec.DataPropertyName = "Naziv";
            NazivMjesec.HeaderText = "Naziv";
            NazivMjesec.Name = "NazivMjesec";
            NazivMjesec.ReadOnly = true;
            // 
            // PredmetMjesec
            // 
            PredmetMjesec.DataPropertyName = "Predmet";
            PredmetMjesec.HeaderText = "Predmet";
            PredmetMjesec.Name = "PredmetMjesec";
            PredmetMjesec.ReadOnly = true;
            // 
            // StartMjesec
            // 
            StartMjesec.DataPropertyName = "Start";
            StartMjesec.HeaderText = "Start";
            StartMjesec.Name = "StartMjesec";
            StartMjesec.ReadOnly = true;
            // 
            // FinishMjesec
            // 
            FinishMjesec.DataPropertyName = "Finish";
            FinishMjesec.HeaderText = "Finish";
            FinishMjesec.Name = "FinishMjesec";
            FinishMjesec.ReadOnly = true;
            // 
            // TrajanjeMjesec
            // 
            TrajanjeMjesec.DataPropertyName = "Trajanje";
            TrajanjeMjesec.HeaderText = "Trajanje";
            TrajanjeMjesec.Name = "TrajanjeMjesec";
            TrajanjeMjesec.ReadOnly = true;
            // 
            // lblMjesecno
            // 
            lblMjesecno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMjesecno.AutoSize = true;
            lblMjesecno.Location = new Point(511, 467);
            lblMjesecno.Name = "lblMjesecno";
            lblMjesecno.Size = new Size(38, 15);
            lblMjesecno.TabIndex = 19;
            lblMjesecno.Text = "label7";
            // 
            // lbl_Mjesec
            // 
            lbl_Mjesec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Mjesec.AutoSize = true;
            lbl_Mjesec.Location = new Point(511, 667);
            lbl_Mjesec.Name = "lbl_Mjesec";
            lbl_Mjesec.Size = new Size(38, 15);
            lbl_Mjesec.TabIndex = 20;
            lbl_Mjesec.Text = "label7";
            // 
            // lblPredmet
            // 
            lblPredmet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(511, 272);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(38, 15);
            lblPredmet.TabIndex = 21;
            lblPredmet.Text = "label7";
            // 
            // btnSve
            // 
            btnSve.Location = new Point(626, 23);
            btnSve.Name = "btnSve";
            btnSve.Size = new Size(98, 32);
            btnSve.TabIndex = 22;
            btnSve.Text = "Sve sesije";
            btnSve.UseVisualStyleBackColor = true;
            // 
            // frmStatistika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(754, 748);
            Controls.Add(btnSve);
            Controls.Add(lblPredmet);
            Controls.Add(lbl_Mjesec);
            Controls.Add(lblMjesecno);
            Controls.Add(dgvSesijeMjesec);
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
            Text = "Statistika";
            Load += frmStatistika_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSesijePredmet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeSedmica).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesijeMjesec).EndInit();
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
        private DataGridView dgvSesijeMjesec;
        private Label lblMjesecno;
        private Label lbl_Mjesec;
        private Label lblPredmet;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Finish;
        private DataGridViewTextBoxColumn Trajanje;
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
        private Button btnSve;
    }
}