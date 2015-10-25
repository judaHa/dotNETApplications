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
    public partial class ModifierProduit : Form
    {
        Stock s;
        Produit p = new Produit();
        Accueil ac;

        public ModifierProduit(Stock s, Produit p,Accueil ac)
        {
            InitializeComponent();
            this.s = s;
            this.p = p;
            this.ac =ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(textBox6, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox7, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox11, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox8, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox13, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox12, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox20, "Insertion des numéros uniquement (Ex : 1.01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox19, "Insertion des numéros uniquement (Ex : 1.01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox18, "Insertion des numéros uniquement (Ex : 1.01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox21, "Insertion des numéros uniquement (Ex : 1.01).");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
             if (rsl == DialogResult.Yes)
             {
                 Hide();
                 ac.Enabled = true;
             }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || textBox19.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                label22.ForeColor = Color.Black;
                label23.ForeColor = Color.Black;
                label26.ForeColor = Color.Black;
                label27.ForeColor = Color.Black;

                if (textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                if (textBox2.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                if (textBox3.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                if (comboBox2.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                if (textBox4.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                if (textBox5.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
                if (textBox6.Text == "")
                {
                    label11.ForeColor = Color.Red;
                }
                if (textBox7.Text == "")
                {
                    label12.ForeColor = Color.Red;
                }
                if (comboBox3.Text == "")
                {
                    label15.ForeColor = Color.Red;
                }
                if (comboBox4.Text == "")
                {
                    label14.ForeColor = Color.Red;
                }
                if (textBox19.Text == "")
                {
                    label26.ForeColor = Color.Red;
                }
                if (textBox20.Text == "")
                {
                    label27.ForeColor = Color.Red;
                }

            }

            else
            {
                string code_produit = textBox1.Text;
                string libelle_produit = textBox2.Text;
                string designation_produit = textBox3.Text;
                string unite_produit = comboBox2.Text;
                string fabricant_produit = textBox4.Text;
                string ref_fabricant_produit = textBox5.Text;
                string poids_produit = textBox6.Text + " " + comboBox5.Text;
                string volume_produit = textBox7.Text + " " + comboBox6.Text;
                string Famille_idFamille = comboBox3.Text;
                string Categorie_idCategorie = comboBox4.Text;
                string produit_critique = comboBox1.Text;
                int stock_min_produit;

                if (textBox11.Text != "")
                { stock_min_produit = Convert.ToInt16(textBox11.Text); }
                else
                { stock_min_produit = 0; }

                int stock_max_produit;
                if (textBox11.Text != "")
                { stock_max_produit = Convert.ToInt16(textBox8.Text); }
                else
                { stock_max_produit = 0; }


                int stock_securite_produit;
                if (textBox11.Text != "")
                { stock_securite_produit = Convert.ToInt16(textBox13.Text); }
                else
                { stock_securite_produit = 0; }

                int stock_disponible_produit;
                if (textBox11.Text != "")
                { stock_disponible_produit = Convert.ToInt16(textBox12.Text); }
                else
                { stock_disponible_produit = 0; }

                string delai_approv_produit = textBox14.Text;
                string magasin_produit = textBox17.Text;
                string emplacement_produit = textBox15.Text;
                string duree_conservation = textBox16.Text;
                //prix_moyen
                double prix_moyen_produit = Convert.ToDouble(textBox20.Text);
               /* if (textBox20.Text[0] == '.' || textBox20.Text[textBox20.Text.Length - 1] == '.')
                {
                    prix_moyen_produit = Convert.ToDouble(textBox20);
                }
                else
                {
                    prix_moyen_produit = 0;
                    MessageBox.Show("Erreur de saisie", "Champ invalide", MessageBoxButtons.OK);
                    label27.ForeColor = Color.Red;
                    textBox20.Text = "";
                }*/

                //prix_vente
                double prix_vente_produit = Convert.ToDouble(textBox19.Text);
                


                //TVA
                double TVA_produit;
                if (textBox18.Text == "")
                {
                    TVA_produit = 0;
                }
                else
                {
                    TVA_produit = Convert.ToDouble(textBox18.Text);
                }

                //REMISE
                double remise_produit;
                if (textBox21.Text == "")
                {
                    remise_produit = 0;
                }
                else
                {
                    remise_produit = Convert.ToDouble(textBox21.Text);
                }

                //Produit p = new Produit(code_produit, libelle_produit, designation_produit, unite_produit, fabricant_produit, ref_fabricant_produit, poids_produit, volume_produit, Famille_idFamille, Categorie_idCategorie, produit_critique, stock_min_produit, stock_max_produit, stock_securite_produit, stock_disponible_produit, delai_approv_produit, magasin_produit, emplacement_produit, duree_conservation_produit, prix_moyen_produit, prix_vente_produit, TVA_produit, remise_produit);
                p.modifierProduit(libelle_produit, designation_produit, unite_produit, fabricant_produit, ref_fabricant_produit, poids_produit, volume_produit, Famille_idFamille, Categorie_idCategorie, produit_critique, stock_min_produit, stock_max_produit, stock_securite_produit, stock_disponible_produit, delai_approv_produit, magasin_produit, emplacement_produit, duree_conservation, prix_moyen_produit, prix_vente_produit, TVA_produit, remise_produit);
                s.produitTableAdapter.Fill(s.gestioncommercialeDataSet1.produit);

                Hide();
                ac.Enabled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Parametres = new Parametres();
            Parametres.Show();
            TabControl t = (TabControl)Parametres.Controls["tabControl1"];
            t.SelectedTab = t.TabPages["tabPage1"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form Parametres = new Parametres();
            Parametres.Show();
            TabControl t = (TabControl)Parametres.Controls["tabControl1"];
            t.SelectedTab = t.TabPages["tabPage2"];
        }

        private void ModifierProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.gestioncommercialeDataSet1.categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.familleTableAdapter.Fill(this.gestioncommercialeDataSet1.famille);

            textBox1.Text = p.code_produit;
            textBox2.Text = p.libelle_produit;
            textBox3.Text = p.designation_produit;
            comboBox2.Text = p.unite_produit;
            textBox4.Text = p.fabricant_produit;
            textBox5.Text = p.ref_fabricant_produit;


            //Poids
            string chiffres_poids = "";
            string unite_poids = "";
            for (int i = 0; i < p.poids_produit.Length; i++)
            {
                if (p.poids_produit[i].Equals(' '))
                {
                    chiffres_poids = p.poids_produit.Substring(0, i);
                    unite_poids = p.poids_produit.Substring(i + 1, p.poids_produit.Length - i - 1);
                }
            }
            textBox6.Text = chiffres_poids;
            comboBox5.Text = unite_poids;

            //Volume
            String chiffres_volume = "";
            string unite_volume = "";
            for (int i = 0; i < p.volume_produit.Length; i++)
            {
                if (p.volume_produit[i].Equals(' '))
                {
                    chiffres_volume = p.volume_produit.Substring(0, i);
                    unite_volume = p.volume_produit.Substring(i + 1, p.volume_produit.Length - i - 1);
                }
            }
            textBox7.Text = chiffres_volume;
            comboBox6.Text = unite_volume;

            comboBox3.Text = p.Famille_idFamille;
            comboBox4.Text = p.Categorie_idCategorie;
            comboBox1.Text = p.produit_critique;
            textBox11.Text = p.stock_min_produit.ToString();
            textBox8.Text = p.stock_max_produit.ToString();
            textBox13.Text = p.stock_securite_produit.ToString();
            textBox12.Text = p.stock_disponible_produit.ToString();
            textBox14.Text = p.delai_approv_produit;
            textBox17.Text = p.magasin_produit;
            textBox15.Text = p.emplacement_produit;
            textBox16.Text = p.duree_conservation_produit;
            textBox20.Text = p.prix_moyen_produit.ToString();
            textBox19.Text = p.prix_vente_produit.ToString();
            textBox18.Text = p.TVA_produit.ToString();
            textBox21.Text = p.remise_produit.ToString();
        }

        private void ModifierProduit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.enregistrerEnter;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.enregistrerLeave;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.annulerEnter;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.annulerLeave;
        }



    }
}
