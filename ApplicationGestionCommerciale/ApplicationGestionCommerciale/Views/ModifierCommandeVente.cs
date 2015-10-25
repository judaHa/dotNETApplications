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
    public partial class ModifierCommandeVente : Form
    {
        int num_ligne_commande;
        int cmv_code;
        string pr_code;
        int pr_quantite;
        double pr_montant;


        CommandesVente cv;
        CommandeVente cv1 = new CommandeVente();
        Accueil ac;
        string v_statut = "Active";

        public ModifierCommandeVente(CommandesVente cv, CommandeVente cv1,Accueil ac)
        {
            InitializeComponent();
            this.cv = cv;
            this.cv1 = cv1;
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
            t.SetToolTip(tbFrais, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox5, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox8, "Supprimer");
        }

        //**************************************************************************************************************************************************

        public void AjouterLigneCommandeVente()
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                pictureBox9.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                textBox2.Text = "";
                textBox7.Text = "";
            }
        }

        public void ModifierLigneCommandeVente()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                if (panel2.Visible == false)
                {
                    panel2.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox3.Visible = false;

                    num_ligne_commande = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value); ;
                    cmv_code = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[1].Value); ;
                    pr_code = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    pr_quantite = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[3].Value);
                    pr_montant = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value); ;

                    textBox2.Text = pr_code;
                    textBox7.Text = pr_quantite.ToString();
                    textBox7.Focus();
                }
                else
                {
                    panel2.Visible = false;
                    textBox2.Text = "";
                    textBox7.Text = "";
                }
            }
        }

        public void supprimerLigneCommandeVente()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                {
                    int num_ligne_commande = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneCommandeVente L = new LigneCommandeVente(num_ligne_commande);
                    L.lcmv_supprimer();
                    this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);
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
                string  cmv_adresse, cmv_ville, cmv_pays, cmv_email, cmv_sitew, cmv_note, cmv_date, cmv_statut, cmv_date_liv;
                int cmv_code, cl_code, cmv_cp, cmv_fixe, cmv_mobile, cmv_fax;
                double cmv_frais;

                if(tbCodeCommV.Text == "" || tbCodeClient.Text == "")
                {
                MessageBox.Show("Veuillez remplir tous les champs nécessaires .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lComm.ForeColor = Color.Black;
                    lClient.ForeColor = Color.Black;
                if (tbCodeCommV.Text == "")
                {
                    lComm.ForeColor = Color.Red;
                    
                }
                if (tbCodeClient.Text == "")
                {
                    lClient.ForeColor  = Color.Red;
                }
                
                }
                else
                {
                  
                    if (tbCP.Text == "")
                        cmv_cp = 0;
                    else
                        cmv_cp = Convert.ToInt32(tbCP.Text);

                    if (tbFixe.Text == "")
                        cmv_fixe = 0;
                    else
                        cmv_fixe = Convert.ToInt32(tbFixe.Text);

                    if (tbMobile.Text == "")
                        cmv_mobile = 0;
                    else
                        cmv_mobile = Convert.ToInt32(tbMobile.Text);

                    if (tbFax.Text == "")
                        cmv_fax = 0;
                    else
                        cmv_fax = Convert.ToInt32(tbFax.Text);

                    if (tbFax.Text == "")
                        cmv_frais = 0;
                    else
                        cmv_frais = Convert.ToInt32(tbFax.Text);

                    cmv_code = Convert.ToInt32(tbCodeCommV.Text);
                    cl_code = Convert.ToInt32(tbCodeClient.Text);
                    cmv_adresse = rtbAdresse.Text;
                    cmv_ville = tbVille.Text;
                    cmv_pays = tbPays.Text;
                    cmv_email = tbEmail.Text;
                    cmv_sitew = tbSitew.Text;
                    cmv_note = rtbNote.Text;
                    cmv_date = dtpCommV.Value.ToString("dd / MM / yyyy");
                    cmv_date_liv = dtpLiv.Value.ToString("dd / MM / yyyy");
                    cmv_statut = v_statut;

                    cv1.cmv_modifier(cl_code, cmv_statut, cmv_date, cmv_date_liv, cmv_adresse, cmv_ville, cmv_cp, cmv_pays, cmv_fixe, cmv_mobile, cmv_fax, cmv_email, cmv_sitew, cmv_note , cmv_frais);

                    cv.commandeventeTableAdapter.Fill(cv.gestioncommercialeDataSet1.commandevente);
                    
                    Hide();
                    ac.Enabled = true;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifierCommandeVente_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignecommandevente'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);

            lignecommandeventeBindingSource.Filter = "cmv_code like '" + cv1.cmv_code + "'";

            tbCodeCommV.Text = cv1.cmv_code.ToString();
            tbCodeClient.Text = cv1.cl_code.ToString(); ;
            dtpCommV.Text = cv1.cmv_date;
            dtpLiv.Text = cv1.cmv_date_liv;
            rtbAdresse.Text = cv1.cmv_adresse;
            tbVille.Text = cv1.cmv_ville;
            tbPays.Text = cv1.cmv_pays;
            tbEmail.Text = cv1.cmv_email;
            tbSitew.Text = cv1.cmv_sitew;
            rtbNote.Text = cv1.cmv_note;
            tbCP.Text = cv1.cmv_cp.ToString();
            tbFixe.Text = cv1.cmv_fixe.ToString();
            tbMobile.Text = cv1.cmv_mobile.ToString();
            tbFax.Text = cv1.cmv_fax.ToString();
            dtpCommV.Text = cv1.cmv_date;
            tbFrais.Text = cv1.cmv_frais.ToString();

            if (cv1.cmv_statut == "Active")
                rbActive.Checked = true;
            else if (cv1.cmv_statut == "Terminée")
                lTerminee.Checked = true;
            else if (cv1.cmv_statut == "Annulée")
                rbAnnulee.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AjouterLigneCommandeVente();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ModifierLigneCommandeVente();
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

        private void ModifierCommandeVente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
        }

        private void tbCodeCommV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCodeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFrais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "select max(num_ligne_commande) from lignecommandevente";
                    connection.Open();
                    num_ligne_commande = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }

                int cma_code = Convert.ToInt16(tbCodeCommV.Text);
                string pr_code = textBox2.Text;
                int pr_quantite = Convert.ToInt16(textBox7.Text);
                double prix_vente_produit = 0;
                double pr_montant = pr_quantite * prix_vente_produit;

                LigneCommandeVente L = new LigneCommandeVente(num_ligne_commande, cma_code, pr_code, pr_quantite, pr_montant);
                L.lcmv_ajouter();
                this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            supprimerLigneCommandeVente();
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

                LigneCommandeVente L = new LigneCommandeVente(num_ligne_commande);
                L.lcmv_modifier(cmv_code, pr_code, pr_quantite, pr_montant);
                this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.Location = new Point(558, 49);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(560, 51);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.Location = new Point(604, 49);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.Location = new Point(606, 51);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(48, 48);
            pictureBox8.Location = new Point(650, 49);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(40, 40);
            pictureBox8.Location = new Point(652, 51);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(46, 43);
            pictureBox3.Location = new Point(35, 124);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(42, 39);
            pictureBox3.Location = new Point(37, 126);
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneCommandeVente();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLigneCommandeVente();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneCommandeVente();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerLigneCommandeVente();
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
