using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace ApplicationGestionCommerciale
{
    public partial class Accueil : Form
    {
        Timer bg = new Timer();

        Clients cl = new Clients();
        Boolean cl_show = false;

        Fournisseurs fr = new Fournisseurs();
        Boolean fr_show = false;

        Stock st = new Stock();
        Boolean st_show = false;

        Devis1 dv = new Devis1();
        Boolean dv_show = false;

        Factures fa = new Factures();
        Boolean fa_show = false;

        CommandesAchat cma = new CommandesAchat();
        Boolean cma_show = false;

        CommandesVente cmv = new CommandesVente();
        Boolean cmv_show = false;

        public Accueil()
        {
            InitializeComponent();
            string jour = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("dddd"));
            string nb_jr = DateTime.Now.ToString("dd");
            string mois = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("MMMM"));
            string an = DateTime.Now.ToString("yyyy");
            string heure = DateTime.Now.ToString("HH");
            string min = DateTime.Now.ToString("mm");
            string sec = DateTime.Now.ToString("ss");

            bg.Tick += (s, e) => { label1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("dddd dd MMMM yyyy    HH:mm:ss")); };
            bg.Interval = 333;
            bg.Start();

            ToolTip tt1 = new ToolTip();

            tt1.ShowAlways = true;
            tt1.SetToolTip(pictureBox9, "Calculatrice");

            tt1.ShowAlways = true;
            tt1.SetToolTip(pictureBox10, "Calendrier");

            tt1.ShowAlways = true;
            tt1.SetToolTip(pictureBox11, "Réglages");

            tt1.ShowAlways = true;
            tt1.SetToolTip(pictureBox12, "Quitter");

        }

        
        //Fonctions d'affichage________________________________________________________

        private void afficherClients()
        {
            if (cl_show == false)
            {
                cl = new Clients(cl_show,this);
                cl.MdiParent = this;
                cl.Show();
                cl.Location = new Point(70, 85);
                cl_show = true;

                fr.Hide();
                fr_show = false;
                st.Hide();
                st_show = false;
                dv.Hide();
                dv_show = false;
                cma.Hide();
                cma_show = false;
                cmv.Hide();
                cmv_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                cl.Hide();
                cl_show = false;
            }
        }

        private void afficherFournisseurs()
        {
            if (fr_show == false)
            {
                fr = new Fournisseurs(this);
                fr.MdiParent = this;
                fr.Show();
                fr.Location = new Point(70, 85);
                fr_show = true;

                cl.Hide();
                cl_show = false;
                st.Hide();
                st_show = false;
                dv.Hide();
                dv_show = false;
                cma.Hide();
                cma_show = false;
                cmv.Hide();
                cmv_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                fr.Hide();
                fr_show = false;
            }
        }

        private void afficherStock()
        {
            if (st_show == false)
            {
                st = new Stock(this);
                st.MdiParent = this;
                st.Show();
                st.Location = new Point(70, 85);
                st_show = true;

                cl.Hide();
                cl_show = false;
                fr.Hide();
                fr_show = false;
                dv.Hide();
                dv_show = false;
                cma.Hide();
                cma_show = false;
                cmv.Hide();
                cmv_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                st.Hide();
                st_show = false;
            }
        }

        private void afficherDevis()
        {
            if (dv_show == false)
            {
                dv = new Devis1(this);
                dv.MdiParent = this;
                dv.Show();
                dv.Location = new Point(70, 85);
                dv_show = true;

                cl.Hide();
                cl_show = false;
                fr.Hide();
                fr_show = false;
                st.Hide();
                st_show = false;
                cma.Hide();
                cma_show = false;
                cmv.Hide();
                cmv_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                dv.Hide();
                dv_show = false;
            }
        }

        private void afficherCommandesAchat()
        {
            if (cma_show == false)
            {
                cma = new CommandesAchat(this);
                cma.MdiParent = this;
                cma.Show();
                cma.Location = new Point(70, 85);
                cma_show = true;

                cl.Hide();
                cl_show = false;
                fr.Hide();
                fr_show = false;
                st.Hide();
                st_show = false;
                dv.Hide();
                dv_show = false;
                cmv.Hide();
                cmv_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                cma.Hide();
                cma_show = false;
            }
        }

        private void afficherCommandesVente()
        {
            if (cmv_show == false)
            {
                cmv = new CommandesVente(this);
                cmv.MdiParent = this;
                cmv.Show();
                cmv.Location = new Point(70, 85);
                cmv_show = true;

                cl.Hide();
                cl_show = false;
                fr.Hide();
                fr_show = false;
                st.Hide();
                st_show = false;
                dv.Hide();
                dv_show = false;
                cma.Hide();
                cma_show = false;
                fa.Hide();
                fa_show = false;
            }
            else
            {
                cmv.Hide();
                cmv_show = false;
            }
        }

        private void afficherFactures()
        {
            if (fa_show == false)
            {
                fa = new Factures(this);
                fa.MdiParent = this;
                fa.Show();
                fa.Location = new Point(70, 85);
                fa_show = true;

                cl.Hide();
                cl_show = false;
                fr.Hide();
                fr_show = false;
                st.Hide();
                st_show = false;
                dv.Hide();
                dv_show = false;
                cma.Hide();
                cma_show = false;
                cmv.Hide();
                cmv_show = false;
            }
            else
            {
                fa.Hide();
                fa_show = false;
            }
        }

        private void afficherCalculatrice()
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch
            {
                MessageBox.Show("Impossible d'accéder à la calculatrice!", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void afficherCalendrier()
        {
            if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
                button1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
                button1.Visible = true;
            }
        }

        private void afficherParametres()
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            Form Parametres = new Parametres();
            Parametres.Show();
        }

        private void quitter()
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            DialogResult rsl = MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Quitter", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Form First = new First();
                First.Show();
                Hide();
            };
        }

        //_____________________________________________________________________

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            quitter();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            afficherCalendrier();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            afficherCalculatrice();
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            afficherParametres();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            afficherClients();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            afficherFournisseurs();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            afficherStock();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            afficherDevis();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (label2.Visible == true && label2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
            afficherFactures();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            afficherCommandesAchat();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            afficherCommandesVente();
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button1.Visible = false;
        }

        private void Accueil_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                afficherClients();
            }
            else if (e.KeyData == Keys.F2)
            {
                afficherFournisseurs();
            }
            else if (e.KeyData == Keys.F3)
            {
                afficherStock();
            }
            else if (e.KeyData == Keys.F4)
            {
                afficherDevis();
            }
            else if (e.KeyData == Keys.F5)
            {
                afficherCommandesAchat();
            }
            else if (e.KeyData == Keys.F6)
            {
                afficherCommandesVente();
            }
            else if (e.KeyData == Keys.F7)
            {
                afficherFactures();
            }
            else if (e.KeyData == Keys.F8)
            {
                afficherCalculatrice();
            }
            else if (e.KeyData == Keys.F9)
            {
                afficherCalendrier();
            }
            else if (e.KeyData == Keys.F10)
            {
                afficherParametres();
            }
            else if (e.KeyData == Keys.F11)
            {
                quitter();
            }
            else if (e.KeyData == Keys.F12)
            {
                Environment.Exit(0);
            }
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            quitter();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.ClientsEnter11;
            pictureBox1.Size = new Size(130, 64);
            pictureBox1.Location = new Point(64, 40);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.ClientsLeave11;
            pictureBox1.Size = new Size(124, 57);
            pictureBox1.Location = new Point(69, 44);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox2.Image = Properties.Resources.FournisseursEnter1;
            pictureBox2.Size = new Size(156, 64);
            pictureBox2.Location = new Point(202, 40);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox2.Image = Properties.Resources.FournisseursLeave1;
            pictureBox2.Size = new Size(150, 57);
            pictureBox2.Location = new Point(204, 44);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox3.Image = Properties.Resources.StockEnter1;
            pictureBox3.Size = new Size(149, 64);
            pictureBox3.Location = new Point(363, 40);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox3.Image = Properties.Resources.StockLeave1;
            pictureBox3.Size = new Size(143, 57);
            pictureBox3.Location = new Point(366, 44);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox4.Image = Properties.Resources.DevisEnter1;
            pictureBox4.Size = new Size(148, 64);
            pictureBox4.Location = new Point(518, 40);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox4.Image = Properties.Resources.DevisLeave1;
            pictureBox4.Size = new Size(142, 57);
            pictureBox4.Location = new Point(520, 44);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox5.Image = Properties.Resources.CommandesEnter1;
            pictureBox5.Size = new Size(150, 64);
            pictureBox5.Location = new Point(673, 40);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox5.Image = Properties.Resources.CommandesLeave1;
            pictureBox5.Size = new Size(144, 57);
            pictureBox5.Location = new Point(676, 44);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox6.Image = Properties.Resources.FacturesEnter1;
            pictureBox6.Size = new Size(152, 64);
            pictureBox6.Location = new Point(830, 40);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox6.Image = Properties.Resources.FacturesLeave1;
            pictureBox6.Size = new Size(146, 57);
            pictureBox6.Location = new Point(833, 44);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitter();
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.AppsEnter1;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.AppsLeave1;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.CalendarEnter1;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.CalendarLeave1;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.ReglageEnter1;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.ReglageLeave1;
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.ExitEnter1;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.ExitLeave1;
        }

        private void sociétéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form p = new Parametres();
            p.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherClients();
        }

        private void fournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherFournisseurs();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherStock();
        }

        private void devisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherDevis();
        }

        private void commandesDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherCommandesAchat();
        }

        private void commandesDeVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherCommandesVente();
        }

        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherFactures();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficherCalendrier();
        }

        private void calculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherCalculatrice();
        }

        private void calendrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherCalendrier();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        

        
        
        

      
    }
}
