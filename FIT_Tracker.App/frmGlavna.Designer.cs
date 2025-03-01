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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(214, 62);
            label1.Name = "label1";
            label1.Size = new Size(227, 54);
            label1.TabIndex = 0;
            label1.Text = "FIT Tracker";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(51, 184);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(121, 23);
            cmbGodina.TabIndex = 1;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(178, 184);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(67, 23);
            cmbSemestar.TabIndex = 2;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(251, 184);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(292, 23);
            cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 166);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Godina studija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 166);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Semestar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 165);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Predmet";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(51, 224);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(601, 39);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(549, 165);
            button1.Name = "button1";
            button1.Size = new Size(103, 42);
            button1.TabIndex = 8;
            button1.Text = "Zapocni sesiju";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(51, 280);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 9;
            button2.Text = "Statistika";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(178, 280);
            button3.Name = "button3";
            button3.Size = new Size(103, 40);
            button3.TabIndex = 10;
            button3.Text = "Postavke";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(293, 280);
            button4.Name = "button4";
            button4.Size = new Size(103, 40);
            button4.TabIndex = 11;
            button4.Text = "Obavijesti";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.CornflowerBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(421, 280);
            button5.Name = "button5";
            button5.Size = new Size(103, 40);
            button5.TabIndex = 12;
            button5.Text = "Charts";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(549, 280);
            button6.Name = "button6";
            button6.Size = new Size(103, 40);
            button6.TabIndex = 13;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(75, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(693, 367);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(cmbSemestar);
            Controls.Add(cmbGodina);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmGlavna";
            Text = "FIT Tracker";
            Load += frmGlavna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
    }
}