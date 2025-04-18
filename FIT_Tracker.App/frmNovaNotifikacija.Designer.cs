namespace FIT_Tracker.App
{
    partial class frmNovaNotifikacija
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
            label1 = new Label();
            txtPoruka = new TextBox();
            dtpVrijeme = new DateTimePicker();
            label2 = new Label();
            btnDodaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv obavijesti";
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(12, 12);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.PlaceholderText = "Unesi poruku notifikacije";
            txtPoruka.Size = new Size(260, 23);
            txtPoruka.TabIndex = 0;
            // 
            // dtpVrijeme
            // 
            dtpVrijeme.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpVrijeme.Format = DateTimePickerFormat.Custom;
            dtpVrijeme.Location = new Point(12, 41);
            dtpVrijeme.Name = "dtpVrijeme";
            dtpVrijeme.Size = new Size(260, 23);
            dtpVrijeme.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 64);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Datum i vrijeme";
            // 
            // btnDodaj
            // 
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.Location = new Point(12, 75);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(125, 30);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.FlatStyle = FlatStyle.Flat;
            btnOtkazi.Location = new Point(147, 75);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(125, 30);
            btnOtkazi.TabIndex = 3;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // frmNovaNotifikacija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 121);
            Controls.Add(txtPoruka);
            Controls.Add(dtpVrijeme);
            Controls.Add(btnDodaj);
            Controls.Add(btnOtkazi);
            Name = "frmNovaNotifikacija";
            Text = "Nova Notifikacija";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpVrijeme;
        private TextBox txtPoruka;
        private Label label2;
        private Button btnDodaj;
        private Button btnOtkazi;
    }
}