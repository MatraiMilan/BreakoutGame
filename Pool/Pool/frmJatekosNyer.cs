using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool
{
    public partial class frmJatekosNyer : Form
    {
        Form1 ths;
        string szoveg;
        int szamlalo;

        public frmJatekosNyer(Form1 ParentForm)
        {
            InitializeComponent();

            ths = ParentForm;
            Beallitasok();
        }

        //beállítások
        private void Beallitasok()
        {
            ths.lblIdo.BackColor = ths.BackColor;
            ths.lblIdo.ForeColor = ths.btnLabda.BackColor;
            ths.lblPontszam.BackColor = ths.BackColor;
            ths.lblPontszam.ForeColor = ths.btnLabda.BackColor;
            TopMost = true;
            szamlalo = 0;
            szoveg = "G  R  A  T  U  L  Á  L  O  K";
            BackColor = Color.Black;
            lblGratulalok.ForeColor = Color.FromArgb(255,ths.BackColor.R < 255 - 100 ? ths.BackColor.R + 100 : ths.BackColor.R, ths.BackColor.G < 255 - 100 ? ths.BackColor.G + 100 : ths.BackColor.G, ths.BackColor.B < 255 - 100 ? ths.BackColor.B + 100 : ths.BackColor.B);

            timerKiiro.Start();
        }

        //timer tick
        private void timerKiiro_Tick(object sender, EventArgs e)
        {
            if (lblGratulalok.Visible == false) lblGratulalok.Visible = true;
            if (lblGratulalok.Text != szoveg)
            {
                lblGratulalok.Text += szoveg[szamlalo];
                szamlalo++;                
                szamlalo = lblGratulalok.Text == szoveg ? 0 : szamlalo;
            }
            else if (lblGratulalok.Text == szoveg)
            {                
                lblGratulalok.Visible = lblGratulalok.Visible == true ? false : true;
                if (szamlalo >= 15)
                {
                    timerKiiro.Stop();
                    Dispose();
                    Close();
                    new frmPontok(ths).Show();
                }
                szamlalo++;
            }                    
        }
    }
}
