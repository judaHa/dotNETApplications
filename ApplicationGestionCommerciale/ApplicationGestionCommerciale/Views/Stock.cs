using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient.Properties;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ApplicationGestionCommerciale
{
    public partial class Stock : Form
    {
        Boolean a = true;
        Boolean b = true;

        Accueil ac;

        public Stock(Accueil ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        public Stock()
        {
        }

        //******************************************************************************************************************
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:    //message WM_NCHITTEST
                    base.WndProc(ref m);
                    if (m.Result == (IntPtr)2)        // 2 =  barre de titre
                        m.Result = (IntPtr)0;     //0 = fond de la fenetre
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ajouter()
        {
            Form a = new AjouterProduit(this,dataGridView1,ac);
            a.Show();
            ac.Enabled = false;
        }

        private void modifier()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                string code_produit = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string libelle_produit = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string designation_produit = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string unite_produit = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string fabricant_produit = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string ref_fabricant_produit = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string poids_produit = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string volume_produit = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string Famille_idFamille = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                string Categorie_idCategorie = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                string produit_critique = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                int stock_min_produit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[11].Value);
                int stock_max_produit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[12].Value);
                int stock_securite_produit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[13].Value);
                int stock_disponible_produit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[14].Value);
                string delai_approv_produit = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                string magasin_produit = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                string emplacement_produit = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                string duree_conservation = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                double prix_moyen_produit = Convert.ToDouble(dataGridView1.CurrentRow.Cells[19].Value);
                double prix_vente_produit = Convert.ToDouble(dataGridView1.CurrentRow.Cells[20].Value);
                double TVA_produit = Convert.ToDouble(dataGridView1.CurrentRow.Cells[21].Value);
                double remise_produit = Convert.ToDouble(dataGridView1.CurrentRow.Cells[22].Value);
                
                Produit p = new Produit(code_produit, libelle_produit, designation_produit, unite_produit, fabricant_produit, ref_fabricant_produit, poids_produit, volume_produit, Famille_idFamille, Categorie_idCategorie, produit_critique, stock_min_produit, stock_max_produit, stock_securite_produit, stock_disponible_produit, delai_approv_produit, magasin_produit, emplacement_produit, duree_conservation, prix_moyen_produit, prix_vente_produit, TVA_produit, remise_produit);
                Form m = new ModifierProduit(this, p,ac);
                m.Show();
                ac.Enabled = false;
            }
        }

        private void supprimer()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit?", "Supprimer Produit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string code_produit = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Produit P = new Produit(code_produit);
                    P.supprimerProduit();
                    this.produitTableAdapter.Fill(this.gestioncommercialeDataSet1.produit);
                }
            }
        }

        private void afficherrecherche()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                dataGridView1.Location = new Point(87, 12);
                dataGridView1.Size = new Size(759, 374);
                radioButton1.Checked = true;
                textBox1.Text = "";
                textBox1.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                dataGridView1.Location = new Point(87, 88);
                dataGridView1.Size = new Size(759, 298);
                textBox1.Focus();
            }
        }

        private void effectuerrecherche()
        {
            if (radioButton1.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "code_produit =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton2.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "libelle_produit like '" + textBox1.Text + "%'";
            }
            else if (radioButton3.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "designation_produit like '" + textBox1.Text + "%'";
            }
            else if (radioButton4.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "Famille_idfamille like '" + textBox1.Text + "%'";
            }
            else if (radioButton5.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "prix_vente_produit =" + Convert.ToDouble(textBox1.Text);
            }
            else if (radioButton6.Checked && textBox1.Text != "")
            {
                produitBindingSource.Filter = "Categorie_idcategorie like '" + textBox1.Text + "%'";
            }
        }

        private void imprimer()
        {

        }

        //****************************************************************************************************************************************

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitTableAdapter.Fill(this.gestioncommercialeDataSet1.produit);           
        }

        private void Stock_KeyUp(object sender, KeyEventArgs e)
        {
            if (b == true)
            {
                if (e.KeyData == Keys.A)
                {
                    ajouter();
                }
                else if (e.KeyData == Keys.M)
                {
                    modifier();
                }
                else if (e.KeyData == Keys.S)
                {
                    supprimer();
                }
                else if (e.KeyData == Keys.I)
                {
                    imprimer();
                }
                else if (e.KeyData == Keys.R)
                {
                    afficherrecherche();
                }
                else if (e.KeyData == Keys.P)
                {
                    Form p = new Parametres();
                    p.Show();
                }
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(65, 75);
            pictureBox2.Location = new Point(11, 10);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(60, 70);
            pictureBox2.Location = new Point(13, 12);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(65, 75);
            pictureBox3.Location = new Point(11, 86);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(60, 70);
            pictureBox3.Location = new Point(13, 88);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(65, 75);
            pictureBox4.Location = new Point(11, 162);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(60, 70);
            pictureBox4.Location = new Point(13, 164);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(65, 75);
            pictureBox5.Location = new Point(11, 238);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(60, 70);
            pictureBox5.Location = new Point(13, 240);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(65, 75);
            pictureBox6.Location = new Point(11, 314);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(60, 70);
            pictureBox6.Location = new Point(13, 316);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = false;
            effectuerrecherche();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifier();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (a == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    b = false;
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void ajouterPorduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void modifierPorduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }
       
        private void supprimerPorduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void imprimerPorduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void rechercherPorduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            b = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                e.Cancel = true;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = dataGridView1.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }
      

       
    }
}
