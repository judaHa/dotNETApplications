using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Devis
{
    public partial class DevisF : Form
    {
        Timer bg = new Timer();

        public DevisF()
        {
            InitializeComponent();

            string jour = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("dddd"));
            string nb_jr = DateTime.Now.ToString("dd");
            string mois = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("MMMM"));
            string an = DateTime.Now.ToString("yyyy");
            string heure = DateTime.Now.ToString("HH");
            string min = DateTime.Now.ToString("mm");
            string sec = DateTime.Now.ToString("ss");

             //définit le traitement à faire à chaque interval
             bg.Tick += (s, e) => { lTime.Text = jour + " " + nb_jr + " " + mois + " " + an + "   " + heure + ":" + min + ":" + sec; };
             //définition de l'interval en ms (333 trois fois par minutes c'est suffisant pour que l'utilisateur ne remarque pas la différence)
             //avec l'heure system, mais à modifier selon ta précision et la performance...
             bg.Interval = 333;
             //lancement de l'affichage de l'heure.
             bg.Start();

        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DevisF_Load(object sender, EventArgs e)
        {

        }

        private void pbAccueil_MouseEnter(object sender, EventArgs e)
        {
            pbAccueil.Image = Properties.Resources.AccueilEnter;
        }

        private void pbAccueil_MouseLeave(object sender, EventArgs e)
        {
            pbAccueil.Image = Properties.Resources.AccueilLeave;
        }

        private void pbAjouter_MouseEnter(object sender, EventArgs e)
        {
            pbAjouter.Image = Properties.Resources.AjouterEnter;
        }

        private void pbAjouter_MouseLeave(object sender, EventArgs e)
        {
            pbAjouter.Image = Properties.Resources.AjouterLeave;
        }

        private void pbModifier_MouseEnter(object sender, EventArgs e)
        {
            pbModifier.Image = Properties.Resources.ModifierEnter;
        }

        private void pbModifier_MouseLeave(object sender, EventArgs e)
        {
            pbModifier.Image = Properties.Resources.ModifierLeave;
        }

        private void pbSupprimer_MouseEnter(object sender, EventArgs e)
        {
            pbSupprimer.Image = Properties.Resources.SupprimerEnter;
        }

        private void pbSupprimer_MouseLeave(object sender, EventArgs e)
        {
            pbSupprimer.Image = Properties.Resources.SupprimerLeave;
        }

        private void pbImprimer_MouseEnter(object sender, EventArgs e)
        {
            pbImprimer.Image = Properties.Resources.ImprimerEnter1;
        }

        private void pbImprimer_MouseLeave(object sender, EventArgs e)
        {
            pbImprimer.Image = Properties.Resources.ImprimerLeave1;
        }

        private void pbRechercher_MouseEnter(object sender, EventArgs e)
        {
            pbRechercher.Image = Properties.Resources.RechercherEnter;
        }

        private void pbRechercher_MouseLeave(object sender, EventArgs e)
        {
            pbRechercher.Image = Properties.Resources.RechercherLeave;
        }

        private void pbQuitter_MouseEnter(object sender, EventArgs e)
        {
            pbQuitter.Image = Properties.Resources.QuitterEnter;
        }

        private void pbQuitter_MouseLeave(object sender, EventArgs e)
        {
            pbQuitter.Image = Properties.Resources.QuitterLeave;
        }

        private void pbAjouter_Click(object sender, EventArgs e)
        {
            AjoutDevis ad = new AjoutDevis(this);
            ad.Show();
            Hide();
        }

        private void pbModifier_Click(object sender, EventArgs e)
        {
            ModifierDevis md = new ModifierDevis(this);
            md.Show();
            Hide();
        }

        private void pbRechercher_Click(object sender, EventArgs e)
        {
            pRecherche.Visible = true;
            dgvDevis.Location = new Point(12,152);
            dgvDevis.Size = new Size(760,276);
            
        }

        private void pbRechHide_MouseEnter(object sender, EventArgs e)
        {
            pbRechHide.Image = Properties.Resources.RechercheHideEnter;
        }

        private void pbRechHide_MouseLeave(object sender, EventArgs e)
        {
            pbRechHide.Image = Properties.Resources.RechercheHideLeave;
        }

        private void pbRechHide_Click(object sender, EventArgs e)
        {
            pRecherche.Visible = false;
            dgvDevis.Location = new Point(12,119);
            dgvDevis.Size = new Size(760,309);
        }

        private void rbCodeDevis_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = true;
            dtpDate.Visible = false;
        }

        private void rbCodeClient_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = true;
            dtpDate.Visible = false;
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = false;
            dtpDate.Visible = true;
        }

        private void rbCP_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = true;
            dtpDate.Visible = false;
        }

        private void rbVille_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = true;
            dtpDate.Visible = false;
        }

        private void rbPays_CheckedChanged(object sender, EventArgs e)
        {
            tbMotsCles.Visible = true;
            dtpDate.Visible = false;
        }

        private void pRecherche_Paint(object sender, PaintEventArgs e)
        {

        }

       


        
    }
}
