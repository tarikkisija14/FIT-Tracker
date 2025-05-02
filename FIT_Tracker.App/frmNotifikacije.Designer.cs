namespace FIT_Tracker.App
{
    partial class frmNotifikacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifikacije));
            lblNaziv = new Label();
            lstNotifikacije = new ListBox();
            cbNotifikacije = new CheckBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNaziv.ForeColor = Color.SteelBlue;
            lblNaziv.Location = new Point(20, 9);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(113, 25);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Notifikacije";
            lblNaziv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstNotifikacije
            // 
            lstNotifikacije.BorderStyle = BorderStyle.None;
            lstNotifikacije.Font = new Font("Segoe UI", 10F);
            lstNotifikacije.FormattingEnabled = true;
            lstNotifikacije.ItemHeight = 17;
            lstNotifikacije.Location = new Point(10, 10);
            lstNotifikacije.Name = "lstNotifikacije";
            lstNotifikacije.Size = new Size(300, 136);
            lstNotifikacije.TabIndex = 1;
            lstNotifikacije.SelectedIndexChanged += lstNotifikacije_SelectedIndexChanged;
            // 
            // cbNotifikacije
            // 
            cbNotifikacije.AutoSize = true;
            cbNotifikacije.Font = new Font("Segoe UI", 10F);
            cbNotifikacije.Location = new Point(20, 221);
            cbNotifikacije.Name = "cbNotifikacije";
            cbNotifikacije.Size = new Size(167, 23);
            cbNotifikacije.TabIndex = 2;
            cbNotifikacije.Text = "Onemoguci notifikacije";
            cbNotifikacije.UseVisualStyleBackColor = true;
            cbNotifikacije.CheckedChanged += cbNotifikacije_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lstNotifikacije);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 160);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5028066;
            pictureBox2.Location = new Point(115, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._12177271;
            pictureBox3.Location = new Point(210, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hd_red_square_close_x_button_icon_transparent_background_701751695038842smjnuhymfc;
            pictureBox4.Location = new Point(301, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // frmNotifikacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 318);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(cbNotifikacije);
            Controls.Add(lblNaziv);
            Name = "frmNotifikacije";
            Text = "Notifikacije";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private ListBox lstNotifikacije;
        private CheckBox cbNotifikacije;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}