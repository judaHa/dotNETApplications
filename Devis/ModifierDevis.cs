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
    public partial class ModifierDevis : Form
    {
        DevisF dv = new DevisF();

        public ModifierDevis(DevisF dv)
        {
            InitializeComponent();
            this.dv = dv;
        }

        private void pbEnregistrer_MouseEnter(object sender, EventArgs e)
        {
            pbEnregistrer.Image = Properties.Resources.EnregistrerEnter;
        }

        private void pbEnregistrer_MouseLeave(object sender, EventArgs e)
        {
            pbEnregistrer.Image = Properties.Resources.EnregistrerLeave;
        }

        private void pbAnnuler_MouseEnter(object sender, EventArgs e)
        {
            pbAnnuler.Image = Properties.Resources.AnnulerEnter;
        }

        private void pbAnnuler_MouseLeave(object sender, EventArgs e)
        {
            pbAnnuler.Image = Properties.Resources.AnnulerLeave;
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

        private void pbModifClient_MouseEnter(object sender, EventArgs e)
        {
            pbModifClient.Image = Properties.Resources.ModifierDevisEnter;
        }

        private void pbModifClient_MouseLeave(object sender, EventArgs e)
        {
            pbModifClient.Image = Properties.Resources.ModifierDevisLeqve;
        }

        private void pbAnnuler_Click(object sender, EventArgs e)
        {
            dv.Show();
            Close();
        }

        private void ModifierDevis_FormClosing(object sender, FormClosingEventArgs e)
        {
            dv.Show();
        }

    }
}
