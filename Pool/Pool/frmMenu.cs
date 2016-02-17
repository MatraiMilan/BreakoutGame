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
    public partial class frmMenu : Form
    {
        Form1 ths;
        public frmMenu(Form1 parentForm)
        {
            ths = parentForm;
            InitializeComponent();
            KinezetBeallitas();
        }

        //színek, kinézet beállítása
        private void KinezetBeallitas()
        {
            if (ths.elsoJatek == true || ths.JatekVege == true)
            {
                btnFolytatas.Enabled = false;
            }
            else
            {
                btnFolytatas.Enabled = true;
            }            
            txtJatekosNeve.Text = ths.jatekosNeve;
            TopMost = true;
            BackColor = ths.BackColor;
            lblMenu.ForeColor = ths.lblPontszam.ForeColor;
            lblJatekos.ForeColor = lblMenu.ForeColor;
            btnFolytatas.ForeColor = lblMenu.ForeColor;
            btnFolytatas.BackColor = Color.FromArgb(BackColor.R > 41 ? BackColor.R - 40 : BackColor.R, BackColor.G > 41 ? BackColor.G - 40 : BackColor.G, BackColor.B > 41 ? BackColor.B - 40 : BackColor.B);
            btnKilepes.ForeColor = lblMenu.ForeColor;
            btnKilepes.BackColor = btnFolytatas.BackColor;
            btnUjjatek.ForeColor = lblMenu.ForeColor;
            btnUjjatek.BackColor = btnFolytatas.BackColor;
            btnEredmények.ForeColor = lblMenu.ForeColor;
            btnEredmények.BackColor = btnFolytatas.BackColor;
            txtJatekosNeve.ForeColor = lblMenu.ForeColor;
            txtJatekosNeve.BackColor = btnFolytatas.BackColor;            
        }

        //bezárás
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Close();
            ths.Close();
        }

        //újjáték
        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            //ths.elsoJatek = false;
            ths.jatekosNeve = txtJatekosNeve.Text;
            TopMost = false;
            Close();
            ths.TopMost = true;
            ths.Enabled = true;
            ths.UjJatek();
        }

        //folytatás
        private void btnFolytatas_Click(object sender, EventArgs e)
        {
            //ths.elsoJatek = false;
            ths.jatekosNeve = txtJatekosNeve.Text;
            TopMost = false;
            Close();
            ths.TopMost = true;
            ths.Enabled = true;
            ths.timer.Start();
            ths.idoMero.Start();
            Cursor.Hide();
        }

        //eredmények mutatása
        private void btnEredmények_Click(object sender, EventArgs e)
        {            
            new frmPontok(ths).Show();
        }
    }
}
