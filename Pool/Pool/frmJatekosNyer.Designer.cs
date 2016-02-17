namespace Pool
{
    partial class frmJatekosNyer
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
            this.lblGratulalok = new System.Windows.Forms.Label();
            this.timerKiiro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGratulalok
            // 
            this.lblGratulalok.BackColor = System.Drawing.Color.Transparent;
            this.lblGratulalok.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratulalok.Location = new System.Drawing.Point(18, 9);
            this.lblGratulalok.Name = "lblGratulalok";
            this.lblGratulalok.Size = new System.Drawing.Size(1103, 144);
            this.lblGratulalok.TabIndex = 0;
            this.lblGratulalok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGratulalok.Visible = false;
            // 
            // timerKiiro
            // 
            this.timerKiiro.Tick += new System.EventHandler(this.timerKiiro_Tick);
            // 
            // frmJatekosNyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 162);
            this.ControlBox = false;
            this.Controls.Add(this.lblGratulalok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJatekosNyer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGratulalok;
        private System.Windows.Forms.Timer timerKiiro;
    }
}