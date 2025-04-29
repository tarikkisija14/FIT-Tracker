namespace FIT_Tracker.App
{
    partial class frmPregledTargeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvTargeti;
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
            dgvTargeti = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTargeti).BeginInit();
            SuspendLayout();
            // 
            // dgvTargeti
            // 
            dgvTargeti.AllowUserToAddRows = false;
            dgvTargeti.AllowUserToDeleteRows = false;
            dgvTargeti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTargeti.Location = new Point(20, 20);
            dgvTargeti.Name = "dgvTargeti";
            dgvTargeti.ReadOnly = true;
            dgvTargeti.Size = new Size(600, 300);
            dgvTargeti.TabIndex = 0;
            // 
            // frmPregledTargeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 340);
            Controls.Add(dgvTargeti);
            Name = "frmPregledTargeta";
            Text = "frmPregledTargeta";
            Load += frmPregledTargeta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTargeti).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}