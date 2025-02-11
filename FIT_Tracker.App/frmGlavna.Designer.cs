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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(272, 27);
            label1.Name = "label1";
            label1.Size = new Size(218, 54);
            label1.TabIndex = 0;
            label1.Text = "Fit Tracker";
            // 
            // cmbGodina
            // 
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(59, 144);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(121, 23);
            cmbGodina.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(186, 144);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(67, 23);
            cmbSemestar.TabIndex = 2;
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(259, 144);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(292, 23);
            cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Godina studija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 126);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Semestar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 125);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Predmet";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(59, 184);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(601, 39);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(557, 126);
            button1.Name = "button1";
            button1.Size = new Size(103, 40);
            button1.TabIndex = 8;
            button1.Text = "Zapocni sesiju";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(59, 240);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 9;
            button2.Text = "Statistika";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(186, 240);
            button3.Name = "button3";
            button3.Size = new Size(103, 40);
            button3.TabIndex = 10;
            button3.Text = "Postavke";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(301, 240);
            button4.Name = "button4";
            button4.Size = new Size(103, 40);
            button4.TabIndex = 11;
            button4.Text = "Obavijesti";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(429, 240);
            button5.Name = "button5";
            button5.Size = new Size(103, 40);
            button5.TabIndex = 12;
            button5.Text = "Charts";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(557, 240);
            button6.Name = "button6";
            button6.Size = new Size(103, 40);
            button6.TabIndex = 13;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = true;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 320);
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
            Controls.Add(label1);
            Name = "frmGlavna";
            Text = "frmGlavna";
            Load += frmGlavna_Load;
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
    }
}