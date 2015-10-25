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
    public partial class AjouterProduit : Form
    {
        Stock s;
        DataGridView d;
        Accueil ac;
        public AjouterProduit(Stock s,DataGridView d,Accueil ac)
        {
            InitializeComponent();
            this.s = s;
            this.d = d;
            this.ac = ac;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || textBox20.Text == "" || textBox19.Text == "")
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
                { stock_min_produit = Convert.ToInt16(textBox11.Text);}
                else
                { stock_min_produit = 0; }

                int stock_max_produit;
                if (textBox11.Text != "")
                { stock_max_produit = Convert.ToInt16(textBox8.Text);}
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
                string duree_conservation_produit = textBox16.Text;

                
                double prix_moyen_produit = Convert.ToDouble(textBox20.Text);
                
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


                for(int i =0; i< d.Rows.Count; i++)
                    if ((d.Rows[i].Cells[6].Value.ToString() == poids_produit && d.Rows[i].Cells[7].Value.ToString() == volume_produit && d.Rows[i].Cells[8].Value.ToString() == Famille_idFamille && d.Rows[i].Cells[9].Value.ToString() == Categorie_idCategorie) || (d.Rows[i].Cells[1].Value.ToString() == libelle_produit))
                {
                    DialogResult rsl = MessageBox.Show("Ce produit peut être existant déjà sous le code : " + d.Rows[i].Cells[0].Value.ToString() + "\n Voulez-vous continuer?","Attention",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                    if (rsl == DialogResult.No)
                    {
                        Hide();
                    }
                }


                else
                {
                Produit P = new Produit(code_produit, libelle_produit, designation_produit, unite_produit, fabricant_produit, ref_fabricant_produit, poids_produit, volume_produit, Famille_idFamille, Categorie_idCategorie, produit_critique, stock_min_produit, stock_max_produit, stock_securite_produit, stock_disponible_produit, delai_approv_produit, magasin_produit, emplacement_produit, duree_conservation_produit, prix_moyen_produit, prix_vente_produit, TVA_produit, remise_produit);
                P.ajouterProduit();
                s.produitTableAdapter.Fill(this.gestioncommercialeDataSet1.produit);

                Hide();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || comboBox2.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox11.Text != "" || textBox8.Text != "" || textBox13.Text != "" || textBox12.Text != "" || textBox14.Text != "" || textBox17.Text != "" || textBox15.Text != "" || textBox16.Text != "" || textBox20.Text != "" || textBox19.Text != "" || textBox18.Text != "" || textBox21.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    ac.Enabled = true;
                }
            }
            else
            {
                Hide();
                ac.Enabled = true;
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AjouterProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.gestioncommercialeDataSet1.categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.familleTableAdapter.Fill(this.gestioncommercialeDataSet1.famille);
         

        }

        private void AjouterProduit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || comboBox2.Text == "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox11.Text != "" || textBox8.Text != "" || textBox13.Text != "" || textBox12.Text != "" || textBox14.Text != "" || textBox17.Text != "" || textBox15.Text != "" || textBox16.Text != "" || textBox20.Text != "" || textBox19.Text != "" || textBox18.Text != "" || textBox21.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    ac.Enabled = true;
                }
            }
            else
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
