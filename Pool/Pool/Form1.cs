using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pool
{
    public partial class Form1 : Form
    {
        List<Button> GombLista = new List<Button>();
        Random r = new Random();
        int A, B;
        Point kezdohely;
        int szamlalo;
        //int deszkaOldaliranyValtozo;
        public Timer idoMero;
        int idoSzamlalo;
        int pontszam;
        public int PontSzam { get { return pontszam; } }
        byte hanyszorErEgymasUtanGomhoz;
        byte visszaszamlalo = 5;
        int formEredetiSzelesseg;
        public string jatekosNeve { get; set; }
        public bool elsoJatek { get; set; }
        public bool JatekVege { get; set; }
        public bool UtolsoEredmenyFelLettEMarDolgozva { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        //Játékmenet
        private void timer_Tick(object sender, EventArgs e)
        {
            Jatek();
        }

        //Gyorsító
        private void btnLabda_LocationChanged(object sender, EventArgs e)
        {
            if (btnLabda.Right >= btnDeszka.Left && btnLabda.Left <= btnDeszka.Right && btnLabda.Bottom >= btnDeszka.Top && btnLabda.Bottom < btnDeszka.Bottom)
            {
                if (szamlalo % 5 == 0 && B < 10)
                {
                    B++;
                    //deszkaOldaliranyValtozo += 1;
                }
            }

        }

        //Indulás
        private void Form1_Load(object sender, EventArgs e)
        {
            formEredetiSzelesseg = Width;
            BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Szivaltas();
            pontszam = 0;
            lblPontszam.Text = pontszam.ToString() + " pont";
            szamlalo = 0;
            GombFelrakas();
            kezdohely = btnLabda.Location;
            //deszkaOldaliranyValtozo = 10;
            A = r.Next(-2, 3);
            B = r.Next(1, 2);
            OraBeallitas();
            Cursor.Hide();
            lblSzorzoKijelzo.Visible = false;
            jatekosNeve = Environment.UserName;
            elsoJatek = true;
            timer.Stop();
            idoMero.Stop();
            Cursor.Show();
            Enabled = false;
            TopMost = false;
            JatekVege = false;
            UtolsoEredmenyFelLettEMarDolgozva = false;
            new frmMenu(this).Show();
        }

        //órabeállítás
        private void OraBeallitas()
        {
            lblIdo.Text = "00:00";
            idoMero = new Timer();
            idoMero.Interval = 1000;
            idoMero.Tick += IdoMero_Tick;
            idoSzamlalo = 0;
            idoMero.Start();
        }

        //Idő számláló tick        
        private void IdoMero_Tick(object sender, EventArgs e)
        {
            //Cursor.Clip = new Rectangle(this.Location.X /*+ 50*/, this.Location.Y, ClientSize.Width /*- 50*/, ClientSize.Height /*- 50*/);
            idoSzamlalo++;
            lblIdo.Text = TimeSpan.FromSeconds(idoSzamlalo).ToString(@"mm\:ss");
            if ((idoSzamlalo + visszaszamlalo) % 30 == 0)
            {
                if (visszaszamlalo % 2 == 0)
                {
                    btnDeszka.BackColor = Color.DarkOrange;
                }
                else
                {
                    btnDeszka.BackColor = Color.PeachPuff;
                }
                visszaszamlalo--;
            }
            if (idoSzamlalo % 30 == 0)
            {
                UjGombSorFelrako();
                btnDeszka.BackColor = Color.DarkOrange;
                if (GombLista.Exists(x => x.Bottom > btnDeszka.Top))
                {
                    JatekVegeVeszit();
                }
            }
            else if (visszaszamlalo == 0)
            {
                visszaszamlalo = 5;
            }

        }


        //Gombfelrakás
        private void GombFelrakas()
        {
            int sorVege = 19;
            Width += formEredetiSzelesseg == Width ? 0 : 2;
            Point b = new Point(0, 0);
            for (int i = 0; i < 100; i++)
            {
                Button a = new Button();
                a.Enabled = false;
                a.TabStop = false;
                a.Width = Width / 20;
                a.Height = a.Width;
                a.Location = b;
                a.FlatStyle = FlatStyle.Flat;
                a.BackColor = System.Drawing.Color.FromArgb(r.Next(200, 255), r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                b.X += a.Width;
                if (i == sorVege /*|| i == 39 || i == 59 || i == 79*/)
                {
                    b.Y += a.Height;
                    b.X = 0;
                    sorVege += 20;
                }
                this.Controls.Add(a);
                GombLista.Add(a);
            }
            Width -= 2;
        }

        /*//jobbra, balra gombok felülírása
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                case Keys.Right:
                    return true;
            }
            return base.IsInputKey(keyData);
        }*/

        //egérrel irányítás
        private void Egerrel(object sender, MouseEventArgs e)
        {

            if (e.X <= 50)
            {
                btnDeszka.Location = new Point(0, btnDeszka.Location.Y);
            }
            else if (e.X >= ClientSize.Width - 50)
            {
                btnDeszka.Location = new Point(ClientSize.Width - btnDeszka.Width, btnDeszka.Location.Y);
            }
            else
            {
                btnDeszka.Location = new Point(e.X - btnDeszka.Width / 2, btnDeszka.Location.Y);
            }
            

            //pontszam és óra háttérszíne
            if (lblIdo.Right < btnDeszka.Right)
            {
                lblIdo.BackColor = btnDeszka.BackColor;
            }
            else
            {
                lblIdo.BackColor = Color.Transparent;
            }
            if (lblPontszam.Left > btnDeszka.Left)
            {
                lblPontszam.BackColor = btnDeszka.BackColor;
            }
            else
            {
                lblPontszam.BackColor = Color.Transparent;
            }

        }

        //beviteli gombok használata
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (this.Enabled == true)
            {
                base.OnKeyDown(e);
                switch (e.KeyCode)
                {
                    //    case Keys.Left:
                    //        {
                    //            if (btnDeszka.Left > 0)
                    //            {
                    //                btnDeszka.Location = new Point(btnDeszka.Location.X - deszkaOldaliranyValtozo, btnDeszka.Location.Y);
                    //            }
                    //        }
                    //        break;
                    //    case Keys.Right:
                    //        {
                    //            if (btnDeszka.Right < ClientSize.Width)
                    //            {
                    //                btnDeszka.Location = new Point(btnDeszka.Location.X + deszkaOldaliranyValtozo, btnDeszka.Location.Y);
                    //            }
                    //        }
                    //        break;
                    default:
                        {
                            timer.Stop();
                            idoMero.Stop();
                            Cursor.Show();
                            Enabled = false;
                            TopMost = false;
                            new frmMenu(this).Show();
                            //if (MessageBox.Show("Biztos kilép?", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                            //    Close();
                            //    break;
                            //}
                            //else
                            //{
                            //    timer.Start();
                            //    idoMero.Start();
                            //    Cursor.Hide();
                            break;
                            //}
                        }
                }
            }
        }

        //Új játék kezdés
        public void UjJatek()
        {
            if (elsoJatek == false)
            {
                foreach (Button item in GombLista)
                {
                    item.Dispose();
                }
                lblSzorzoKijelzo.Text = "";
                btnDeszka.BackColor = Color.DarkOrange;
                BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                Szivaltas();
                pontszam = 0;
                szamlalo = 0;
                lblPontszam.Text = pontszam.ToString() + " pont";
                GombLista.Clear();
                GombFelrakas();
                btnLabda.Location = kezdohely;
                btnDeszka.Location = new Point(ClientSize.Width / 2 - btnDeszka.Width / 2, btnDeszka.Location.Y);
                A = r.Next(-2, 3);
                B = r.Next(1, 2);
                //deszkaOldaliranyValtozo = 10;
                Cursor.Hide();
                OraBeallitas();
                JatekVege = false;
                UtolsoEredmenyFelLettEMarDolgozva = false;
                timer.Start();
            }
            else
            {
                elsoJatek = false;
                Cursor.Hide();
                OraBeallitas();
                timer.Start();
            }

        }

        //Játék
        public void Jatek()
        {
            btnLabda.Location = new Point(btnLabda.Location.X + A, btnLabda.Location.Y + B);

            //labda irányváltás
            if (btnLabda.Left <= 10 || btnLabda.Right >= Width - 10 || btnLabda.Bottom >= btnDeszka.Top - 10 || GombLista.Exists(x => x.Bottom + 10 >= btnLabda.Top))
            {
                //ha gombhoz ér
                if (GombLista.Exists(x => x.Bottom + 10 >= btnLabda.Top))
                {
                    HaGombhozEr();
                }//ha deszkához ér
                else if (btnLabda.Right >= btnDeszka.Left && btnLabda.Left <= btnDeszka.Right && btnLabda.Bottom >= btnDeszka.Top && btnLabda.Bottom < btnDeszka.Bottom)
                {
                    HaDeszkahozEr();
                }
                //ha falhoz ér
                if ((btnLabda.Right >= ClientSize.Width && A > 0) || (btnLabda.Left <= 0 && A < 0))
                {
                    A *= -1;
                }
                if (btnLabda.Top <= 0 && B < 0)
                {
                    B *= -1;
                }

                //Ha leesik
                if (btnLabda.Top >= ClientSize.Height)
                {
                    JatekVegeVeszit();
                }
            }

            //szorzókijelző eltüntetése/mutatása

            if (lblSzorzoKijelzo.Visible == false && hanyszorErEgymasUtanGomhoz > 1/*btnLabda.Bottom <= lblSzorzoKijelzo.Top*/)
            {

                lblSzorzoKijelzo.Visible = true;
            }


            //if (lblSzorzoKijelzo.Visible == true && btnLabda.Bottom > lblSzorzoKijelzo.Top)
            //{
            //    lblSzorzoKijelzo.Visible = false;
            //}
            //else if (lblSzorzoKijelzo.Visible == false && btnLabda.Bottom <= lblSzorzoKijelzo.Top)
            //{

            //    lblSzorzoKijelzo.Visible = true;
            //}

        }

        //játékvége / veszít
        private void JatekVegeVeszit()
        {
            JatekVege = true;
            Cursor.Show();
            idoMero.Stop();
            timer.Stop();
            new frmPontok(this).Show();
            //this.TopMost = false;
            this.Enabled = false;
        }

        //deszkahoz er
        private void HaDeszkahozEr()
        {
            hanyszorErEgymasUtanGomhoz = 0;
            lblSzorzoKijelzo.Text = "";
            B *= -1;
            szamlalo++;
            if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + btnDeszka.Size.Width / 7)
            {
                A = B - 2;
            }
            else if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + (btnDeszka.Size.Width / 7) * 2)
            {
                A = B - 1;
            }
            else if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + (btnDeszka.Size.Width / 7) * 3)
            {
                A = B;
            }
            else if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + (btnDeszka.Size.Width / 7) * 4)
            {
                A = 0;
            }
            else if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + (btnDeszka.Size.Width / 7) * 5)
            {
                A = (B * -1);
            }
            else if (btnLabda.Location.X + btnLabda.Width / 2 < btnDeszka.Location.X + (btnDeszka.Size.Width / 7) * 6)
            {
                A = (B * -1) + 1;
            }
            else
            {
                A = (B * -1) + 2;
            }
        }

        //gombhoz ér - szinvaltas - nyer a játékos
        private void HaGombhozEr()
        {
            //ha gombhoz ér alulról
            if (GombLista.Exists(x => (x.Bottom >= btnLabda.Top && x.Top < btnLabda.Top) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2))
            {
                B *= -1;
                BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                GombLista.Find(x => (x.Bottom >= btnLabda.Top && x.Top < btnLabda.Top) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2).Dispose();
                GombLista.Remove(GombLista.Find(x => (x.Bottom >= btnLabda.Top && x.Top < btnLabda.Top) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2));
                hanyszorErEgymasUtanGomhoz++;
                pontszam += (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) < 0 ? (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) * -1 : (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10);
                lblPontszam.Text = pontszam.ToString() + " pont";
            }//ha gombhoz ér felülről            
            else if (GombLista.Exists(x => (x.Top <= btnLabda.Bottom && x.Bottom > btnLabda.Bottom) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2))
            {
                B *= -1;
                BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                GombLista.Find(x => (x.Top <= btnLabda.Bottom && x.Bottom > btnLabda.Bottom) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2).Dispose();
                GombLista.Remove(GombLista.Find(x => (x.Top <= btnLabda.Bottom && x.Bottom > btnLabda.Bottom) && x.Location.X < btnLabda.Location.X + btnLabda.Width / 2 && x.Location.X + x.Width > btnLabda.Location.X + btnLabda.Width / 2));
                hanyszorErEgymasUtanGomhoz++;
                pontszam += (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) < 0 ? (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) * -1 : (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10);
                lblPontszam.Text = pontszam.ToString() + " pont";
            }//ha jobb oldalról ér a gombhoz
            else if (GombLista.Exists(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Right >= btnLabda.Left && x.Left < btnLabda.Left)))
            {
                if (A == 0) { A = 3; }
                else { A *= -1; }
                BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                GombLista.Find(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Right >= btnLabda.Left && x.Left < btnLabda.Left)).Dispose();
                GombLista.Remove(GombLista.Find(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Right >= btnLabda.Left && x.Left < btnLabda.Left)));
                hanyszorErEgymasUtanGomhoz++;
                pontszam += (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) < 0 ? (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) * -1 : (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10);
                lblPontszam.Text = pontszam.ToString() + " pont";
            }//ha bal oldalról ér a gombhoz
            else if (GombLista.Exists(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Left <= btnLabda.Right && x.Right > btnLabda.Right)))
            {
                if (A == 0) { A = -3; }
                else { A *= -1; }
                BackColor = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                GombLista.Find(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Left <= btnLabda.Right && x.Right > btnLabda.Right)).Dispose();
                GombLista.Remove(GombLista.Find(x => x.Location.Y < btnLabda.Location.Y + btnLabda.Height / 2 && x.Location.Y + x.Height > btnLabda.Location.Y + btnLabda.Height / 2 && (x.Left <= btnLabda.Right && x.Right > btnLabda.Right)));
                hanyszorErEgymasUtanGomhoz++;
                pontszam += (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) < 0 ? (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10) * -1 : (hanyszorErEgymasUtanGomhoz * B + idoSzamlalo / 10);
                lblPontszam.Text = pontszam.ToString() + " pont";
            }

            //színváltás
            Szivaltas();

            //szorzó mutatása
            if (hanyszorErEgymasUtanGomhoz > 2)
            {
                lblSzorzoKijelzo.Text = "x" + hanyszorErEgymasUtanGomhoz;
            }

            //ha nyer a játékos
            if (GombLista.Count == 0)
            {
                NyerAJatekos();
            }
        }

        //színváltás
        private void Szivaltas()
        {
            if (BackColor.R + BackColor.G + BackColor.B < 450)
            {
                btnLabda.BackColor = Color.White;
                lblIdo.ForeColor = btnLabda.BackColor;
                lblPontszam.ForeColor = btnLabda.BackColor;
                lblSzorzoKijelzo.ForeColor = btnLabda.BackColor;
            }
            else
            {
                btnLabda.BackColor = Color.Black;
                lblIdo.ForeColor = btnLabda.BackColor;
                lblPontszam.ForeColor = btnLabda.BackColor;
                lblSzorzoKijelzo.ForeColor = btnLabda.BackColor;
            }
        }

        //Új sor hozzáadása
        private void UjGombSorFelrako()
        {
            foreach (Button item in GombLista)
            {
                item.Location = new Point(item.Location.X, item.Location.Y + item.Height);
            }
            Point b = new Point(0, 0);
            for (int i = 0; i < 20; i++)
            {
                Button a = new Button();
                a.Enabled = false;
                a.TabStop = false;
                a.Width = ClientSize.Width / 20;
                a.Height = a.Width;
                a.Location = b;
                a.FlatStyle = FlatStyle.Flat;
                a.BackColor = System.Drawing.Color.FromArgb(r.Next(200, 255), r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                b.X += a.Width;
                this.Controls.Add(a);
                GombLista.Add(a);
            }
        }

        //deszka helyváltozás = kurzor helyének megadása
        private void KurzorHelye(object sender, EventArgs e)
        {
            Cursor.Clip = new Rectangle(this.Location.X /*+ 50*/, this.Location.Y, ClientSize.Width /*- 50*/, ClientSize.Height /*- 50*/);
        }

        //játékvége / nyer
        private void NyerAJatekos()
        {
            JatekVege = true;
            Cursor.Show();
            idoMero.Stop();
            timer.Stop();
            new frmJatekosNyer(this).Show();
            //this.TopMost = false;
            this.Enabled = false;
        }
    }
}
