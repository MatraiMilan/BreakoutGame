namespace Pool
{
    partial class frmPontok
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
            this.lblPontokCim = new System.Windows.Forms.Label();
            this.dsPontok = new Pool.dsPontok();
            this.dtPontszamokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnUjjatek = new System.Windows.Forms.Button();
            this.lblElertPontszamSzoveg = new System.Windows.Forms.Label();
            this.lblElertPontszamSzam = new System.Windows.Forms.Label();
            this.txtBoxPontok = new System.Windows.Forms.RichTextBox();
            this.btnVissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPontok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPontszamokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPontokCim
            // 
            this.lblPontokCim.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontokCim.Location = new System.Drawing.Point(4, 3);
            this.lblPontokCim.Name = "lblPontokCim";
            this.lblPontokCim.Size = new System.Drawing.Size(524, 46);
            this.lblPontokCim.TabIndex = 0;
            this.lblPontokCim.Text = "Legjobb pontszámok";
            this.lblPontokCim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPontokCim.UseCompatibleTextRendering = true;
            // 
            // dsPontok
            // 
            this.dsPontok.DataSetName = "dsPontok";
            this.dsPontok.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPontszamokBindingSource
            // 
            this.dtPontszamokBindingSource.DataMember = "dtPontszamok";
            this.dtPontszamokBindingSource.DataSource = this.dsPontok;
            // 
            // btnKilepes
            // 
            this.btnKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilepes.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(360, 474);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(168, 64);
            this.btnKilepes.TabIndex = 3;
            this.btnKilepes.TabStop = false;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnUjjatek
            // 
            this.btnUjjatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjjatek.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjjatek.Location = new System.Drawing.Point(12, 474);
            this.btnUjjatek.Name = "btnUjjatek";
            this.btnUjjatek.Size = new System.Drawing.Size(168, 64);
            this.btnUjjatek.TabIndex = 1;
            this.btnUjjatek.TabStop = false;
            this.btnUjjatek.Text = "Új játék";
            this.btnUjjatek.UseVisualStyleBackColor = true;
            this.btnUjjatek.Click += new System.EventHandler(this.btnUjjatek_Click);
            // 
            // lblElertPontszamSzoveg
            // 
            this.lblElertPontszamSzoveg.BackColor = System.Drawing.Color.Transparent;
            this.lblElertPontszamSzoveg.Font = new System.Drawing.Font("Agency FB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElertPontszamSzoveg.Location = new System.Drawing.Point(12, 425);
            this.lblElertPontszamSzoveg.Name = "lblElertPontszamSzoveg";
            this.lblElertPontszamSzoveg.Size = new System.Drawing.Size(264, 42);
            this.lblElertPontszamSzoveg.TabIndex = 4;
            this.lblElertPontszamSzoveg.Text = "Elért pontszám:";
            this.lblElertPontszamSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElertPontszamSzam
            // 
            this.lblElertPontszamSzam.BackColor = System.Drawing.Color.Transparent;
            this.lblElertPontszamSzam.Font = new System.Drawing.Font("Agency FB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElertPontszamSzam.Location = new System.Drawing.Point(278, 425);
            this.lblElertPontszamSzam.Name = "lblElertPontszamSzam";
            this.lblElertPontszamSzam.Size = new System.Drawing.Size(250, 42);
            this.lblElertPontszamSzam.TabIndex = 5;
            this.lblElertPontszamSzam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPontok
            // 
            this.txtBoxPontok.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPontok.Location = new System.Drawing.Point(12, 52);
            this.txtBoxPontok.Name = "txtBoxPontok";
            this.txtBoxPontok.ReadOnly = true;
            this.txtBoxPontok.Size = new System.Drawing.Size(516, 370);
            this.txtBoxPontok.TabIndex = 6;
            this.txtBoxPontok.TabStop = false;
            this.txtBoxPontok.Text = "";
            this.txtBoxPontok.WordWrap = false;
            // 
            // btnVissza
            // 
            this.btnVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVissza.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVissza.Location = new System.Drawing.Point(186, 474);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(168, 64);
            this.btnVissza.TabIndex = 2;
            this.btnVissza.TabStop = false;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // frmPontok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 550);
            this.ControlBox = false;
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.txtBoxPontok);
            this.Controls.Add(this.lblElertPontszamSzam);
            this.Controls.Add(this.lblElertPontszamSzoveg);
            this.Controls.Add(this.btnUjjatek);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.lblPontokCim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPontok";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dsPontok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPontszamokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsPontok dsPontok;
        private System.Windows.Forms.BindingSource dtPontszamokBindingSource;
        public System.Windows.Forms.Label lblPontokCim;

        public frmPontok()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnUjjatek;
        private System.Windows.Forms.Label lblElertPontszamSzoveg;
        private System.Windows.Forms.Label lblElertPontszamSzam;
        private System.Windows.Forms.RichTextBox txtBoxPontok;
        private System.Windows.Forms.Button btnVissza;
    }
}