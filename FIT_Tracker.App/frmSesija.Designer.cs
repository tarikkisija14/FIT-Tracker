namespace FIT_Tracker.App
{
    partial class frmSesija
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
            lblTimer = new Label();
            btnZapocni = new Button();
            button2 = new Button();
            button3 = new Button();
            lblPredmet = new Label();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTimer.Location = new Point(193, 96);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(137, 54);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "label1";
            // 
            // btnZapocni
            // 
            btnZapocni.Location = new Point(85, 183);
            btnZapocni.Name = "btnZapocni";
            btnZapocni.Size = new Size(92, 35);
            btnZapocni.TabIndex = 1;
            btnZapocni.Text = "Zapocni sesiju";
            btnZapocni.UseVisualStyleBackColor = true;
            btnZapocni.Click += btnZapocni_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 183);
            button2.Name = "button2";
            button2.Size = new Size(92, 35);
            button2.TabIndex = 2;
            button2.Text = "Pauziraj Sesiju";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(332, 183);
            button3.Name = "button3";
            button3.Size = new Size(92, 35);
            button3.TabIndex = 3;
            button3.Text = "Zavrsi Sesiju";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Font = new Font("Segoe UI", 15F);
            lblPredmet.Location = new Point(64, 42);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(65, 28);
            lblPredmet.TabIndex = 4;
            lblPredmet.Text = "label2";
            // 
            // frmSesija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 257);
            Controls.Add(lblPredmet);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnZapocni);
            Controls.Add(lblTimer);
            Name = "frmSesija";
            Text = "frmSesija";
            Load += frmSesija_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnZapocni;
        private Button button2;
        private Button button3;
        private Label lblPredmet;
    }
}