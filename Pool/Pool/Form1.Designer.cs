namespace Pool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnDeszka = new System.Windows.Forms.Button();
            this.btnLabda = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblIdo = new System.Windows.Forms.Label();
            this.lblPontszam = new System.Windows.Forms.Label();
            this.lblSzorzoKijelzo = new AtlatszoLabel.SajatLabel();
            this.SuspendLayout();
            // 
            // btnDeszka
            // 
            this.btnDeszka.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeszka.Enabled = false;
            this.btnDeszka.FlatAppearance.BorderSize = 2;
            this.btnDeszka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszka.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeszka.Location = new System.Drawing.Point(214, 551);
            this.btnDeszka.Name = "btnDeszka";
            this.btnDeszka.Size = new System.Drawing.Size(100, 20);
            this.btnDeszka.TabIndex = 0;
            this.btnDeszka.TabStop = false;
            this.btnDeszka.UseVisualStyleBackColor = false;
            this.btnDeszka.LocationChanged += new System.EventHandler(this.KurzorHelye);
            // 
            // btnLabda
            // 
            this.btnLabda.BackColor = System.Drawing.Color.Black;
            this.btnLabda.Enabled = false;
            this.btnLabda.FlatAppearance.BorderSize = 0;
            this.btnLabda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabda.Location = new System.Drawing.Point(253, 269);
            this.btnLabda.Name = "btnLabda";
            this.btnLabda.Size = new System.Drawing.Size(20, 20);
            this.btnLabda.TabIndex = 1;
            this.btnLabda.TabStop = false;
            this.btnLabda.UseVisualStyleBackColor = false;
            this.btnLabda.LocationChanged += new System.EventHandler(this.btnLabda_LocationChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblIdo
            // 
            this.lblIdo.AutoSize = true;
            this.lblIdo.BackColor = System.Drawing.Color.Transparent;
            this.lblIdo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdo.Location = new System.Drawing.Point(505, 553);
            this.lblIdo.Name = "lblIdo";
            this.lblIdo.Size = new System.Drawing.Size(0, 16);
            this.lblIdo.TabIndex = 2;
            // 
            // lblPontszam
            // 
            this.lblPontszam.AutoSize = true;
            this.lblPontszam.BackColor = System.Drawing.Color.Transparent;
            this.lblPontszam.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPontszam.Location = new System.Drawing.Point(12, 553);
            this.lblPontszam.Name = "lblPontszam";
            this.lblPontszam.Size = new System.Drawing.Size(0, 16);
            this.lblPontszam.TabIndex = 3;
            // 
            // lblSzorzoKijelzo
            // 
            this.lblSzorzoKijelzo.Font = new System.Drawing.Font("Agency FB", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSzorzoKijelzo.Location = new System.Drawing.Point(214, 308);
            this.lblSzorzoKijelzo.Name = "lblSzorzoKijelzo";
            this.lblSzorzoKijelzo.Size = new System.Drawing.Size(135, 93);
            this.lblSzorzoKijelzo.TabIndex = 5;
            this.lblSzorzoKijelzo.TabStop = false;
            this.lblSzorzoKijelzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 578);
            this.ControlBox = false;
            this.Controls.Add(this.lblSzorzoKijelzo);
            this.Controls.Add(this.lblPontszam);
            this.Controls.Add(this.lblIdo);
            this.Controls.Add(this.btnLabda);
            this.Controls.Add(this.btnDeszka);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Egerrel);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeszka;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lblIdo;
        public System.Windows.Forms.Button btnLabda;
        public AtlatszoLabel.SajatLabel lblSzorzoKijelzo;
        public System.Windows.Forms.Label lblPontszam;
    }
}

