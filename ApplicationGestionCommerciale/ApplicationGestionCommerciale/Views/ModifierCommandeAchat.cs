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
    public partial class ModifierCommandeAchat : Form
    {
        int num_ligne_commande;
        int cma_code;
        string pr_code;
        int pr_quantite;
        double pr_montant;

        CommandesAchat ca;
        CommandeAchat ca1 = new CommandeAchat();
        Accueil ac;
        string v_statut = "Active";

        public ModifierCommandeAchat(CommandesAchat ca, CommandeAchat ca1,Accueil ac)
        {
            InitializeComponent();
            this.ca = ca;
            this.ca1 = ca1;
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
            t.SetToolTip(textBox7, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox3, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox5, "Supprimer");
        }


        //****************************************************************************************************************************************


        public void AjouterLigneCommandeAchat()
        {
            panel2.Visible = true;
            pictureBox9.Visible = false;
            pictureBox7.Visible = true;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        public void ModifierLigneCommandeAchat()
        {
            panel2.Visible = true;
            pictureBox9.Visible = true;
            pictureBox7.Visible = false;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

            num_ligne_commande = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value); ;
            cma_code = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[1].Value); ;
            pr_code = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pr_quantite = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[3].Value);
            pr_montant = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value); ;

            textBox2.Text = pr_code;
            textBox7.Text = pr_quantite.ToString();
            textBox7.Focus();
        }

        public void SupprimerLigneCommandeAchat()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    int num_ligne_commande = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneCommandeAchat L = new LigneCommandeAchat(num_ligne_commande);
                    L.lcma_supprimer();
                    this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);
                }
            }
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
            try
            {
                string  cma_adresse, cma_ville, cma_pays, cma_email, cma_sitew, cma_note, cma_date, cma_statut, cma_date_liv;
                int cma_code, fr_code, cma_cp, cma_fixe, cma_mobile, cma_fax;

                if(tbCodeCommA.Text == "" || tbCodeFourni.Text == "")
                {
                MessageBox.Show("Veuillez remplir tous les champs nécessaires .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lComm.ForeColor = Color.Black;
                    lFournisseur.ForeColor = Color.Black;
                if (tbCodeCommA.Text == "")
                {
                    lComm.ForeColor =Color.Red;
                }
                if (tbCodeFourni.Text == "")
                {
                    lFournisseur.ForeColor = Color.Red;
                }
                    
                }
                else
                {

                    if (tbCP.Text == "")
                        cma_cp = 0;
                    else
                        cma_cp = Convert.ToInt32(tbCP.Text);

                    if (tbFixe.Text == "")
                        cma_fixe = 0;
                    else
                        cma_fixe = Convert.ToInt32(tbFixe.Text);

                    if (tbMobile.Text == "")
                        cma_mobile = 0;
                    else
                        cma_mobile = Convert.ToInt32(tbMobile.Text);

                    if (tbFax.Text == "")
                        cma_fax = 0;
                    else
                        cma_fax = Convert.ToInt32(tbFax.Text);

                    cma_code = Convert.ToInt32(tbCodeCommA.Text);
                    fr_code = Convert.ToInt32(tbCodeFourni.Text);
                    cma_adresse = rtbAdresse.Text;
                    cma_ville = tbVille.Text;
                    cma_pays = tbPays.Text;
                    cma_email = tbEmail.Text;
                    cma_sitew = tbSitew.Text;
                    cma_note = rtbNote.Text;
                    cma_date = dtpCommA.Value.ToString("dd / MM / yyyy");
                    cma_date_liv = dtpLiv.Value.ToString("dd / MM / yyyy");
                    cma_statut = v_statut;

                    ca1.cma_modifier(fr_code, cma_statut, cma_date, cma_date_liv, cma_adresse, cma_ville, cma_cp, cma_pays, cma_fixe, cma_mobile, cma_fax, cma_email, cma_sitew, cma_note);

                    ca.commandeachatTableAdapter.Fill(ca.gestioncommercialeDataSet1.commandeachat);
                    

                    Hide();
                    ac.Enabled = true;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifierCommandeAchat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignecommandeachat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);
           

            lignecommandeachatBindingSource.Filter = "cma_code =" + ca1.cma_code ;

            tbCodeCommA.Text = ca1.cma_code.ToString();
            tbCodeFourni.Text = ca1.fr_code.ToString();
            dtpCommA.Text = ca1.cma_date;
            dtpLiv.Text = ca1.cma_date_liv;
            rtbAdresse.Text = ca1.cma_adresse;
            tbVille.Text = ca1.cma_ville;
            tbPays.Text = ca1.cma_pays;
            tbEmail.Text = ca1.cma_email;
            tbSitew.Text = ca1.cma_sitew;
            rtbNote.Text = ca1.cma_note;
            tbCP.Text = ca1.cma_cp.ToString();
            tbFixe.Text = ca1.cma_fixe.ToString();
            tbMobile.Text = ca1.cma_mobile.ToString();
            tbFax.Text = ca1.cma_fax.ToString();
            dtpCommA.Text = ca1.cma_date;

            if (ca1.cma_statut == "Active")
                rbActive.Checked = true;
            else if (ca1.cma_statut == "Terminée")
                lTerminee.Checked = true;
            else if (ca1.cma_statut == "Annulée")
                rbAnnulee.Checked = true;
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Active";
        }

        private void lTerminee_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Terminée";
        }

        private void rbAnnulee_CheckedChanged(object sender, EventArgs e)
        {
            v_statut = "Annulée";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                if (panel2.Visible == false)
                {
                    ModifierLigneCommandeAchat();
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

        private void ModifierCommandeAchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
        }

        private void tbCodeCommA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCodeFourni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SupprimerLigneCommandeAchat();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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
                //num_ligne_commande
                int num_ligne_commande;
                if (dataGridView1.Rows.Count == 0)
                {
                    num_ligne_commande = 1;
                }
                else
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(num_ligne_commande) from lignecommandeachat";
                    connection.Open();
                    num_ligne_commande = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }

                int cma_code = Convert.ToInt16(tbCodeCommA.Text);
                string pr_code = textBox2.Text;
                int pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                double pr_montant = pr_quantite * prix_vente_produit;

                LigneCommandeAchat L = new LigneCommandeAchat(num_ligne_commande, cma_code, pr_code, pr_quantite, pr_montant);
                L.lcma_ajouter();
                this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                AjouterLigneCommandeAchat();
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
                pr_code = textBox2.Text;
                pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                pr_montant = pr_quantite * prix_vente_produit;

                LigneCommandeAchat L = new LigneCommandeAchat(num_ligne_commande);
                L.lcma_modifier(cma_code, pr_code, pr_quantite, pr_montant);
                this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
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
            pictureBox6.Size = new Size(46, 43);
            pictureBox6.Location = new Point(92, 124);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(42, 39);
            pictureBox6.Location = new Point(94, 126);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(46, 43);
            pictureBox7.Location = new Point(35, 124);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(42, 39);
            pictureBox7.Location = new Point(37, 126);
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

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(29, 29);
            pictureBox8.Location = new Point(298, 41);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.Location = new Point(300, 43);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLigneCommandeAchat();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneCommandeAchat();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneCommandeAchat();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneCommandeAchat();
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SelectFournisseur sf = new SelectFournisseur();
            sf.Show();
        }

      

       


        
    }
}
