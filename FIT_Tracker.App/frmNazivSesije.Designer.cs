namespace FIT_Tracker.App
{
    partial class frmNazivSesije
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
            txtNaziv = new TextBox();
            btnSave = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Unesite naziv ove sesije";
            // 
            // txtNaziv
            // 
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Location = new Point(162, 35);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(324, 23);
            txtNaziv.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(411, 69);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Snimi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = Color.SteelBlue;
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(330, 69);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 3;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmNazivSesije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 104);
            Controls.Add(btnOdustani);
            Controls.Add(btnSave);
            Controls.Add(txtNaziv);
            Controls.Add(label1);
            Name = "frmNazivSesije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nazovite sesiju";
            Load += frmNazivSesije_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNaziv;
        private Button btnSave;
        private Button btnOdustani;
    }
}