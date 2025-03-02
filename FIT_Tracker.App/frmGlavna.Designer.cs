namespace FIT_Tracker.App
{
    partial class frmGlavna
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
            cmbGodina = new ComboBox();
            cmbSemestar = new ComboBox();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(165, 31);
            label1.Name = "label1";
            label1.Size = new Size(206, 100);
            label1.TabIndex = 0;
            label1.Text = "FIT Tracker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbGodina
            // 
            cmbGodina.BackColor = Color.White;
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FlatStyle = FlatStyle.Flat;
            cmbGodina.Font = new Font("Segoe UI", 12F);
            cmbGodina.ForeColor = Color.Black;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(29, 154);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(147, 29);
            cmbGodina.TabIndex = 1;
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
            cmbSemestar.Location = new Point(182, 154);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(88, 29);
            cmbSemestar.TabIndex = 2;
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
            cmbPredmet.Location = new Point(276, 153);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(342, 29);
            cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 136);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Godina studija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 135);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Semestar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 135);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Predmet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(29, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.play;
            pictureBox2.Location = new Point(251, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(644, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.statistics;
            pictureBox3.Location = new Point(29, 327);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.settings;
            pictureBox4.Location = new Point(199, 327);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.bell;
            pictureBox5.Location = new Point(353, 327);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(102, 71);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.information;
            pictureBox6.Location = new Point(506, 318);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(112, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(644, 417);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(cmbGodina);
            Controls.Add(pictureBox1);
            Controls.Add(cmbSemestar);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(cmbPredmet);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "FIT Tracker";
            Load += frmGlavna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbGodina;
        private ComboBox cmbSemestar;
        private ComboBox cmbPredmet;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}