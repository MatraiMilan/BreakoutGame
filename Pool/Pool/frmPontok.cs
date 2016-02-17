using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pool
{
    public partial class frmPontok : Form
    {
        Eredmeny mostaniEredmeny; 
        Form1 ths;
        int tickelo;
        Timer pontkiiro;
        List<int> lista;
        DataSet ds;        
        public frmPontok(Form1 parentForm)
        {            
            InitializeComponent();

            ths = parentForm;   
             
            KinezetBeallitas();
            XmlEsAdatKezeles();
            EredmenyKiiratas();                           
        }

        //Eredmények kiírása
        private void EredmenyKiiratas()
        {
            //kiíratás textboxba
            byte sorszamlalo = 1;
            Eredmeny eredmeny;
            bool voltemar = false;
            foreach (DataRow item in ds.Tables["dtPontszamok"].Rows)
            {
                eredmeny = new Eredmeny(sorszamlalo, item.ItemArray[0].ToString(), (int)item.ItemArray[1], item.ItemArray[2].ToString(), item.ItemArray[3].ToString());
                if (ths.JatekVege == true && ths.UtolsoEredmenyFelLettEMarDolgozva == false && mostaniEredmeny.Nev == eredmeny.Nev && mostaniEredmeny.Pontszam == eredmeny.Pontszam && mostaniEredmeny.Ido == eredmeny.Ido && mostaniEredmeny.Datum == eredmeny.Datum && voltemar == false)
                {
                    txtBoxPontok.AppendText(eredmeny.ToString());
                    int startIndex = txtBoxPontok.GetFirstCharIndexOfCurrentLine();
                    txtBoxPontok.Select(startIndex, eredmeny.ToString().Length);
                    txtBoxPontok.SelectionBackColor = txtBoxPontok.ForeColor == Color.Black ? Color.White : Color.Black;
                    txtBoxPontok.AppendText("\r\n");
                    txtBoxPontok.SelectionStart = startIndex;
                    txtBoxPontok.ScrollToCaret();
                    voltemar = true;
                }
                else
                {
                    txtBoxPontok.AppendText(eredmeny.ToString() + "\r\n");                    
                }
                sorszamlalo++;
            }

            //pontkiíró timer beállítás, indítás
            if (ths.JatekVege == true && ths.UtolsoEredmenyFelLettEMarDolgozva == false)
            {
                PontKiiro();
                ths.UtolsoEredmenyFelLettEMarDolgozva = true;
            }
        }

        //beolvasás, adathozzáadás, xmlírás
        private void XmlEsAdatKezeles()
        {
            //xml adat beolvasás, pontszám - lista
            try
            {
                dsPontok.ReadXml("records.xml");
                foreach (DataRow item in dsPontok.Tables["dtPontszamok"].Rows)
                {
                    foreach (DataColumn dc in dsPontok.Tables["dtPontszamok"].Columns)
                    {
                        if (dc.ColumnName == "Pontszám")
                        {
                            lista.Add((int)item[dc]);
                        }
                    }
                }
            }
            catch { };

            //eredmény hozzáadása a datasethez
            if (ths.JatekVege == true && ths.UtolsoEredmenyFelLettEMarDolgozva == false && (lista.Exists(x => x < ths.PontSzam) || lista.Count < 20))
            {
                dsPontok.dtPontszamok.Rows.Add(ths.jatekosNeve, Convert.ToInt32(ths.lblPontszam.Text.Replace(" pont", null)), ths.lblIdo.Text, DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            }

            //sorbarendezett, válogatott dataset, xml írás
            ds = new DataSet();
            ds.Tables.Add(dsPontok.Tables[0].DefaultView.ToTable());
            if (ths.JatekVege == true && ths.UtolsoEredmenyFelLettEMarDolgozva == false)
            {
                if (lista.Exists(x => x < ths.PontSzam))
                {
                    lista.RemoveAt(lista.Count() - 1);
                    ds.Tables["dtPontszamok"].Rows.RemoveAt(dsPontok.dtPontszamok.Rows.Count - 1);
                }

                ds.WriteXml("records.xml");
            }
        }

        //pontkiíró timer beállítás
        private void PontKiiro()
        {
            pontkiiro = new Timer();
            pontkiiro.Interval = 1;
            pontkiiro.Tick += Pontkiiro_Tick;
            tickelo = 0;
            pontkiiro.Start();
        }

        //szerzett pont kipergető
        private void Pontkiiro_Tick(object sender, EventArgs e)
        {
            if (tickelo <= ths.PontSzam)
            {
                lblElertPontszamSzam.Text = tickelo +" pont";
            }
            else
            {
                lblElertPontszamSzam.Text = ths.PontSzam.ToString() + " pont";
                pontkiiro.Stop();
            }
            tickelo += 33;           
            
        }

        //kilppés katt
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Close();
            ths.Close();
        }

        //újjáték katt
        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            TopMost = false;            
            Close();
            ths.TopMost = true;           
            ths.Enabled = true;
            ths.UjJatek();
        }

        //kinézet beállítás
        private void KinezetBeallitas()
        {
            lblPontokCim.Location = new Point(this.Width / 2 - lblPontokCim.Width / 2, lblPontokCim.Location.Y);
            BackColor = ths.BackColor;
            StartPosition = FormStartPosition.CenterScreen;
            lblPontokCim.ForeColor = ths.lblPontszam.ForeColor;
            txtBoxPontok.ForeColor = lblPontokCim.ForeColor;
            txtBoxPontok.BackColor = Color.FromArgb(BackColor.R > 41 ? BackColor.R - 40 : BackColor.R, BackColor.G > 41 ? BackColor.G - 40 : BackColor.G, BackColor.B > 41 ? BackColor.B - 40 : BackColor.B);
            btnUjjatek.BackColor = txtBoxPontok.BackColor;
            btnUjjatek.ForeColor = txtBoxPontok.ForeColor;
            btnKilepes.BackColor = txtBoxPontok.BackColor;
            btnKilepes.ForeColor = txtBoxPontok.ForeColor;
            btnVissza.BackColor = txtBoxPontok.BackColor;
            btnVissza.ForeColor = txtBoxPontok.ForeColor;
            TopMost = true;
            dsPontok.Tables[0].DefaultView.Sort = "Pontszám DESC";
            lista = new List<int>();

            if (ths.JatekVege == true && ths.UtolsoEredmenyFelLettEMarDolgozva == false)
            {             
                btnUjjatek.Enabled = true;                
                btnKilepes.Enabled = true;                                
                lblElertPontszamSzoveg.Visible = true;
                lblElertPontszamSzam.Visible = true;
                lblElertPontszamSzoveg.ForeColor = lblPontokCim.ForeColor;
                lblElertPontszamSzam.ForeColor = lblPontokCim.ForeColor;
                lblElertPontszamSzam.Text = "0"; 
                mostaniEredmeny = new Eredmeny(ths.jatekosNeve, ths.PontSzam, ths.lblIdo.Text, DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());                
            }
            else
            {     
                btnUjjatek.Enabled = false;
                btnKilepes.Enabled = false;                                
                lblElertPontszamSzoveg.Visible = false;
                lblElertPontszamSzam.Visible = false; 
            }
            
        }

        //vissza katt
        private void btnVissza_Click(object sender, EventArgs e)
        {
            if (ths.JatekVege == false)
            {
                this.Dispose();
                this.Close();
            }
            else
            {                
                this.Dispose();
                this.Close();                
                new frmMenu(ths).Show();
            }
                      
        }
    }

    class Eredmeny
    {
        public byte Sorszam { get; set; }
        public string Nev { get; set; }
        public int Pontszam { get; set; }
        public string Ido { get; set; }
        public string Datum { get; set; }

        public Eredmeny(byte sorszam, string nev, int pontszam, string ido, string datum)
        {
            this.Sorszam = sorszam;
            this.Nev = nev;
            this.Pontszam = pontszam;
            this.Ido = ido;
            this.Datum = datum;
        }

        public Eredmeny(string nev, int pontszam, string ido, string datum)
        {            
            this.Nev = nev;
            this.Pontszam = pontszam;
            this.Ido = ido;
            this.Datum = datum;
        }

        public override string ToString()
        {
            return String.Format("{0,-5} {1, -13} {2, 6} pont {3, 7} {4, 20}", Sorszam, Nev, Pontszam, Ido, Datum);
        }
    }
}
