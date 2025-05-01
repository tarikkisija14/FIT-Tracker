namespace FIT_Tracker.App
{
    partial class frmTarget
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
            cmbGodina = new ComboBox();
            cmbSemestar = new ComboBox();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BrojSati = new NumericUpDown();
            btnSnimi = new Button();
            btnClose = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)BrojSati).BeginInit();
            SuspendLayout();
            // 
            // cmbGodina
            // 
            cmbGodina.BackColor = Color.White;
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FlatStyle = FlatStyle.Flat;
            cmbGodina.Font = new Font("Segoe UI", 12F);
            cmbGodina.ForeColor = Color.Black;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(28, 42);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(122, 29);
            cmbGodina.TabIndex = 4;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbSemestar
            // 
            cmbSemestar.BackColor = Color.White;
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FlatStyle = FlatStyle.Flat;
            cmbSemestar.Font = new Font("Segoe UI", 12F);
            cmbSemestar.ForeColor = Color.Black;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(156, 42);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(134, 29);
            cmbSemestar.TabIndex = 5;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbPredmet
            // 
            cmbPredmet.BackColor = Color.White;
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FlatStyle = FlatStyle.Flat;
            cmbPredmet.Font = new Font("Segoe UI", 12F);
            cmbPredmet.ForeColor = Color.Black;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(28, 94);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(262, 29);
            cmbPredmet.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 24);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "Godina studija";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 74);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Predmet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 24);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Semestar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 135);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 10;
            label1.Text = "Broj sati za ucenje predmeta:";
            // 
            // BrojSati
            // 
            BrojSati.Location = new Point(30, 153);
            BrojSati.Name = "BrojSati";
            BrojSati.Size = new Size(260, 23);
            BrojSati.TabIndex = 11;
            // 
            // btnSnimi
            // 
            btnSnimi.BackColor = Color.SteelBlue;
            btnSnimi.FlatStyle = FlatStyle.Flat;
            btnSnimi.ForeColor = Color.White;
            btnSnimi.Location = new Point(28, 191);
            btnSnimi.Name = "btnSnimi";
            btnSnimi.Size = new Size(96, 32);
            btnSnimi.TabIndex = 12;
            btnSnimi.Text = "Save";
            btnSnimi.UseVisualStyleBackColor = false;
            btnSnimi.Click += btnSnimi_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(194, 191);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 32);
            btnClose.TabIndex = 13;
            btnClose.Text = "Zatvori";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 241);
            button1.Name = "button1";
            button1.Size = new Size(260, 40);
            button1.TabIndex = 14;
            button1.Text = "Pregledaj Targete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmTarget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 301);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(btnSnimi);
            Controls.Add(BrojSati);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbGodina);
            Controls.Add(cmbSemestar);
            Controls.Add(cmbPredmet);
            Name = "frmTarget";
            Text = "Target";
            Load += frmTarget_Load;
            ((System.ComponentModel.ISupportInitialize)BrojSati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGodina;
        private ComboBox cmbSemestar;
        private ComboBox cmbPredmet;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private NumericUpDown BrojSati;
        private Button btnSnimi;
        private Button btnClose;
        private Button button1;
    }
}