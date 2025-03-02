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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(207, 31);
            label1.Name = "label1";
            label1.Size = new Size(185, 66);
            label1.TabIndex = 0;
            label1.Text = "FIT Tracker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbGodina
            // 
            cmbGodina.BackColor = Color.White;
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FlatStyle = FlatStyle.Popup;
            cmbGodina.Font = new Font("Segoe UI", 12F);
            cmbGodina.ForeColor = Color.Black;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(47, 144);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(147, 29);
            cmbGodina.TabIndex = 1;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbSemestar
            // 
            cmbSemestar.BackColor = Color.White;
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FlatStyle = FlatStyle.Popup;
            cmbSemestar.Font = new Font("Segoe UI", 12F);
            cmbSemestar.ForeColor = Color.Black;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(200, 144);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(88, 29);
            cmbSemestar.TabIndex = 2;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbPredmet
            // 
            cmbPredmet.BackColor = Color.White;
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FlatStyle = FlatStyle.Popup;
            cmbPredmet.Font = new Font("Segoe UI", 12F);
            cmbPredmet.ForeColor = Color.Black;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(294, 143);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(354, 29);
            cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Godina studija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 125);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Semestar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 125);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Predmet";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 132, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(47, 329);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 9;
            button2.Text = "Statistika";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(76, 132, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(170, 329);
            button3.Name = "button3";
            button3.Size = new Size(103, 40);
            button3.TabIndex = 10;
            button3.Text = "Postavke";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(76, 132, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(289, 329);
            button4.Name = "button4";
            button4.Size = new Size(103, 40);
            button4.TabIndex = 11;
            button4.Text = "Obavijesti";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(76, 132, 255);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(415, 329);
            button5.Name = "button5";
            button5.Size = new Size(103, 40);
            button5.TabIndex = 12;
            button5.Text = "Charts";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(76, 132, 255);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(545, 329);
            button6.Name = "button6";
            button6.Size = new Size(103, 40);
            button6.TabIndex = 13;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(71, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.play;
            pictureBox2.Location = new Point(276, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(693, 383);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(cmbGodina);
            Controls.Add(pictureBox1);
            Controls.Add(cmbSemestar);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(cmbPredmet);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmGlavna";
            Text = "FIT Tracker";
            Load += frmGlavna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}