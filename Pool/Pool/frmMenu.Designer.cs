namespace Pool
{
    partial class frmMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnUjjatek = new System.Windows.Forms.Button();
            this.btnFolytatas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.lblJatekos = new System.Windows.Forms.Label();
            this.txtJatekosNeve = new System.Windows.Forms.TextBox();
            this.btnEredmények = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(281, 46);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menü";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMenu.UseCompatibleTextRendering = true;
            // 
            // btnUjjatek
            // 
            this.btnUjjatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjjatek.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjjatek.Location = new System.Drawing.Point(12, 179);
            this.btnUjjatek.Name = "btnUjjatek";
            this.btnUjjatek.Size = new System.Drawing.Size(281, 46);
            this.btnUjjatek.TabIndex = 2;
            this.btnUjjatek.TabStop = false;
            this.btnUjjatek.Text = "Új játék";
            this.btnUjjatek.UseVisualStyleBackColor = true;
            this.btnUjjatek.Click += new System.EventHandler(this.btnUjjatek_Click);
            // 
            // btnFolytatas
            // 
            this.btnFolytatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolytatas.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFolytatas.Location = new System.Drawing.Point(12, 127);
            this.btnFolytatas.Name = "btnFolytatas";
            this.btnFolytatas.Size = new System.Drawing.Size(281, 46);
            this.btnFolytatas.TabIndex = 1;
            this.btnFolytatas.TabStop = false;
            this.btnFolytatas.Text = "Folytatás";
            this.btnFolytatas.UseVisualStyleBackColor = true;
            this.btnFolytatas.Click += new System.EventHandler(this.btnFolytatas_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilepes.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(12, 283);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(281, 46);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.TabStop = false;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // lblJatekos
            // 
            this.lblJatekos.AutoSize = true;
            this.lblJatekos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJatekos.Location = new System.Drawing.Point(12, 79);
            this.lblJatekos.Name = "lblJatekos";
            this.lblJatekos.Size = new System.Drawing.Size(127, 20);
            this.lblJatekos.TabIndex = 7;
            this.lblJatekos.Text = "Játékos neve:";
            // 
            // txtJatekosNeve
            // 
            this.txtJatekosNeve.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJatekosNeve.Location = new System.Drawing.Point(145, 76);
            this.txtJatekosNeve.MaxLength = 13;
            this.txtJatekosNeve.Name = "txtJatekosNeve";
            this.txtJatekosNeve.Size = new System.Drawing.Size(148, 32);
            this.txtJatekosNeve.TabIndex = 5;
            this.txtJatekosNeve.TabStop = false;
            // 
            // btnEredmények
            // 
            this.btnEredmények.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEredmények.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEredmények.Location = new System.Drawing.Point(12, 231);
            this.btnEredmények.Name = "btnEredmények";
            this.btnEredmények.Size = new System.Drawing.Size(281, 46);
            this.btnEredmények.TabIndex = 3;
            this.btnEredmények.TabStop = false;
            this.btnEredmények.Text = "Eredmények";
            this.btnEredmények.UseVisualStyleBackColor = true;
            this.btnEredmények.Click += new System.EventHandler(this.btnEredmények_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnEredmények);
            this.Controls.Add(this.txtJatekosNeve);
            this.Controls.Add(this.lblJatekos);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnFolytatas);
            this.Controls.Add(this.btnUjjatek);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnUjjatek;
        private System.Windows.Forms.Button btnFolytatas;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label lblJatekos;
        private System.Windows.Forms.TextBox txtJatekosNeve;
        private System.Windows.Forms.Button btnEredmények;
    }
}