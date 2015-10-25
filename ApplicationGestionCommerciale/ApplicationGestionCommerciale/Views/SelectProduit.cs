using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    public partial class SelectProduit : Form
    {
        public SelectProduit()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(pictureBox1, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox2, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox3, "Supprimer");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Sélectionner");
        }

        private void SelectProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitTableAdapter.Fill(this.gestioncommercialeDataSet1.produit);

        }
    }
}
