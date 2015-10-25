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
    public partial class ModifierDevis : Form
    {
        int num_ligne_devis;
        int dv_code;
        string pr_code;
        int pr_quantite;
        double pr_montant;

        Accueil ac;
        Devis1 d;
        Devis dv = new Devis();
        string v_statut = "Actif";

        public ModifierDevis(Devis1 d, Devis dv,Accueil ac)
        {
            InitializeComponent();
            this.d = d;
            this.dv = dv;
            this.ac = ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(tbCP, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(tbFixe, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(tbMobile, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(tbFax, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox3, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox5, "Supprimer");
        }

        //*************************************************************************************************************************************************

        public void AjouterLigneDevis()
        {
            panel2.Visible = true;
            pictureBox9.Visible = false;
            pictureBox8.Visible = true;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        public void ModifierLigneDevis()
        {
            panel2.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

            num_ligne_devis = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            dv_code = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[1].Value);
            pr_code = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pr_quantite = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[3].Value);
            pr_montant = 0;

            textBox2.Text = pr_code;
            textBox7.Text = pr_quantite.ToString();
            textBox7.Focus();
        }

        public void SupprimerLigneDevis()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment supprimer ce produit de la facture?", "Supprimer Produit de la facture", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                {
                    int num_ligne_devis = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneDevis L = new LigneDevis(num_ligne_devis);
                    L.ld_supprimer();
                    this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);
                }
            }
        }

//**********************************************************************************************************************************************************************




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    ac.Enabled = true;
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string  dv_adresse, dv_ville, dv_pays, dv_email, dv_sitew, dv_note, dv_date, dv_statut;
                int dv_code, cl_code, dv_cp, dv_fixe, dv_mobile, dv_fax;

                 if (tbCodeDevis.Text == "" || tbCodeClient.Text == "")
                {
                MessageBox.Show("Veuillez remplir tous les champs nécessaires .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lCodeDevis.ForeColor = Color.Black;
                lClient.ForeColor = Color.Black;
                if (tbCodeDevis.Text == "")
                {
                    lCodeDevis.ForeColor = Color.Red;
                }
                if (tbCodeClient.Text == "")
                {
                    lClient.ForeColor = Color.Red;
                }

                }
             else
             {
               

                if (tbCP.Text == "")
                    dv_cp = 0;
                else
                    dv_cp = Convert.ToInt32(tbCP.Text);

                if (tbFixe.Text == "")
                    dv_fixe = 0;
                else
                    dv_fixe = Convert.ToInt32(tbFixe.Text);

                if (tbMobile.Text == "")
                    dv_mobile = 0;
                else
                    dv_mobile = Convert.ToInt32(tbMobile.Text);

                if (tbFax.Text == "")
                    dv_fax = 0;
                else
                    dv_fax = Convert.ToInt32(tbFax.Text);

                dv_code = Convert.ToInt16(tbCodeDevis.Text);
                cl_code = Convert.ToInt16(tbCodeClient.Text);
                dv_adresse = rtbAdresse.Text;
                dv_ville = tbVille.Text;
                dv_pays = tbPays.Text;
                dv_email = tbEmail.Text;
                dv_sitew = tbSitew.Text;
                dv_note = rtbNote.Text;
                dv_date = dtpDevis.Value.ToString("dd / MM / yyyy");
                dv_statut = v_statut;

                dv.dv_modifier(cl_code, dv_date, dv_statut, dv_adresse, dv_ville, dv_cp, dv_pays, dv_fixe, dv_mobile, dv_fax, dv_email, dv_sitew, dv_note);
                d.devisTableAdapter.Fill(d.gestioncommercialeDataSet1.devis);
               
                Hide();
                ac.Enabled = true;
               }
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbActif_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Actif";
        }

        private void rbAnnule_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Annulé";
        }
        

        private void ModifierDevis_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignedevis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);
            
            lignedevisBindingSource.Filter = "dv_code= " + Convert.ToInt16(dv.dv_code);

            tbCodeDevis.Text = dv.dv_code.ToString();
            tbCodeClient.Text = dv.cl_code.ToString();
            dtpDevis.Text = dv.dv_date;
            rtbAdresse.Text = dv.dv_adresse;
            tbVille.Text = dv.dv_ville;
            tbPays.Text = dv.dv_pays;
            tbEmail.Text = dv.dv_email;
            tbSitew.Text = dv.dv_sitew;
            rtbNote.Text = dv.dv_note;
            tbCP.Text = dv.dv_cp.ToString();
            tbFixe.Text = dv.dv_fixe.ToString();
            tbMobile.Text = dv.dv_mobile.ToString();
            tbFax.Text = dv.dv_fax.ToString();
            dtpDevis.Text = dv.dv_date;
            if (dv.dv_statut == "Actif")
                rbActif.Checked = true;
            else if (dv.dv_statut == "Terminé")
                lTermine.Checked = true;
            else if (dv.dv_statut == "Annulée")
                rbAnnule.Checked = true;
        }

        private void rbActif_CheckedChanged_1(object sender, EventArgs e)
        {
            v_statut = "Actif";
        }

        private void lTermine_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Terminé";
        }

        private void rbAnnule_CheckedChanged_1(object sender, EventArgs e)
        {
            v_statut = "Annulé";
        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFixe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModifierDevis_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            panel2.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                if (textBox2.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                if (textBox7.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                
            }
            else
            {
                //num_ligne_devis
                int num_ligne_devis;
                if (dataGridView1.Rows.Count == 0)
                {
                    num_ligne_devis = 1;
                }
                else
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(num_ligne_devis) from lignedevis";
                    connection.Open();
                    num_ligne_devis = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }

                int dv_code = Convert.ToInt16(tbCodeDevis.Text);
                string pr_code = textBox2.Text;
                int pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                double pr_montant = pr_quantite * prix_vente_produit;

                LigneDevis L = new LigneDevis(num_ligne_devis, dv_code, pr_code, pr_quantite, pr_montant);
                L.ld_ajouter();
                this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                if (textBox2.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                if (textBox7.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
            }
            else
            {
                //numero_ligneDevis
                int num_ligne_devis;
                if (dataGridView1.Rows.Count == 0)
                {
                    num_ligne_devis = 1;
                }
                else
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(num_ligne_devis) from lignedevis";
                    connection.Open();
                    num_ligne_devis = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }

                int dv_code = Convert.ToInt16(tbCodeDevis.Text);
                string pr_code = textBox2.Text;
                int pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                double pr_montant = pr_quantite * prix_vente_produit;

                LigneDevis L = new LigneDevis(num_ligne_devis);
                L.ld_modifier(dv_code, pr_code, pr_quantite, pr_montant);
                this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                if (textBox2.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                if (textBox7.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                
            }
            else
            {
                pr_code = textBox2.Text;
                pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                pr_montant = pr_quantite * prix_vente_produit;

                LigneDevis L = new LigneDevis(num_ligne_devis);
                L.ld_modifier(dv_code, pr_code, pr_quantite, pr_montant);
                this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                AjouterLigneDevis();
            }
            else
            {
                panel2.Visible = false;
                textBox2.Text = "";
                textBox7.Text = "";
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SupprimerLigneDevis();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                if (panel2.Visible == false)
                {
                    ModifierLigneDevis();
                }
                else
                {
                    panel2.Visible = false;
                    textBox2.Text = "";
                    textBox7.Text = "";
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                }
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

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(29, 29);
            pictureBox6.Location = new Point(298, 39);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.Location = new Point(300, 41);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.Location = new Point(558, 49);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.Location = new Point(560, 51);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.Location = new Point(604, 49);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(606, 51);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.Location = new Point(650, 49);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.Location = new Point(652, 51);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(46, 43);
            pictureBox8.Location = new Point(35, 124);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(42, 39);
            pictureBox8.Location = new Point(37, 126);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(46, 43);
            pictureBox9.Location = new Point(35, 124);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(42, 39);
            pictureBox9.Location = new Point(37, 126);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(46, 43);
            pictureBox7.Location = new Point(92, 124);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(42, 39);
            pictureBox7.Location = new Point(94, 126);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(29, 29);
            pictureBox10.Location = new Point(129, 31);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.Location = new Point(130, 33);
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

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLigneDevis();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneDevis();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneDevis();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneDevis();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(tbEmail.Text))
                {
                    MessageBox.Show("E-mail non valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SelectProduit sp = new SelectProduit();
            sp.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SelectClient sc = new SelectClient();
            sc.Show();
        }




    }
}
