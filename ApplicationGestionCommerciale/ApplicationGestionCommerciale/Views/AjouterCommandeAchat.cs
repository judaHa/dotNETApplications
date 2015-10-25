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
    public partial class AjouterCommandeAchat : Form
    {
        CommandesAchat ca;
        Accueil ac;

        string adresse_Fournisseur;
        int codePostal_Fournisseur;
        string ville_Fournisseur;
        string pays_Fournisseur;
        int tel_Fournisseur;
        int telmobile_Fournisseur;
        int fax_Fournisseur;
        string email_Fournisseur;
        string siteInternet_Fournisseur;
        string note_Fournisseur;

        int num_ligne_commande;
        int numero;
        int cma_code;
        string pr_code;
        string libelle_produit;
        double prix_vente_produit;
        double TVA_produit;
        double remise_produit;
        int pr_quantite;
        double pr_montant;

        double montantHT_CA;
        double montantTTC_CA;

        double TVA_Total;

        public AjouterCommandeAchat(string cma_code, CommandesAchat ca,Accueil ac)
        {
            InitializeComponent();
            this.ca = ca;
            this.ac = ac;
            tbCodeCommA.Text = cma_code;

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

        //**************************************************************************************************************************************************************************
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
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox7.Focus();
        }

        public void SupprimerLigneCommandeAchat()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                {
                    Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        this.dataGridView1.Rows.RemoveAt(rowToDelete);
                    }

                    if (dataGridView1.Rows.Count != 0)
                    {
                        ModifierMontants_CA();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        }
                    }
                    else
                    {
                        montantHT_CA = 0;
                        textBox3.Text = "0";
                        montantTTC_CA = 0;
                        textBox4.Text = "0";
                    }
                    /*int num_ligne_commande = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneCommandeAchat L = new LigneCommandeAchat(num_ligne_commande);
                    L.lcma_supprimer();
                    this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);*/
                }
            }
        }

        public void ModifierMontants_CA()
        {
            montantHT_CA = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                montantHT_CA = montantHT_CA + Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                textBox3.Text = montantHT_CA.ToString();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TVA_Total = TVA_Total + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            montantTTC_CA = montantHT_CA + TVA_Total;
            textBox4.Text = montantTTC_CA.ToString();
        }




        //**************************************************************************************************************************************************************************



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeFourni.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
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
                    cma_statut = "Active";

                    CommandeAchat cma = new CommandeAchat(cma_code, fr_code, cma_statut, cma_date, cma_date_liv, cma_adresse, cma_ville, cma_cp, cma_pays, cma_fixe, cma_mobile, cma_fax, cma_email, cma_sitew, cma_note);
                    cma.cma_ajouter();
                    ca.commandeachatTableAdapter.Fill(ca.gestioncommercialeDataSet1.commandeachat);

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                        MySqlConnection connection = new MySqlConnection(MyConString);
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select count(*) from lignecommande";
                        connection.Open();
                        int num = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();
                        if (num != 0)
                        {
                            cmd.CommandText = "select max(num_ligne_commande) from lignecommandeachat;";
                            connection.Open();
                            num_ligne_commande = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                            connection.Close();
                        }
                        else
                        {
                            num_ligne_commande = 1;
                        }
                        
                        dataGridView1.Rows[i].Cells[8].Value = num_ligne_commande;
                        num_ligne_commande = Convert.ToInt16(dataGridView1.Rows[i].Cells[8].Value);
                        pr_code = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        pr_quantite = Convert.ToInt16(dataGridView1.Rows[i].Cells[6].Value);
                        pr_montant = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                        LigneCommandeAchat L = new LigneCommandeAchat(num_ligne_commande, cma_code, pr_code, pr_quantite, pr_montant);
                        L.lcma_ajouter();

                    }

                    Hide();
                    ac.Enabled = true;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

        private void AjouterCommandeAchat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignecommandeachat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);
            lignecommandeachatBindingSource.Filter = "cma_code = " + Convert.ToInt16(tbCodeCommA.Text);
            ModifierMontants_CA();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
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
                if (dataGridView1.Rows.Count == 0)
                {
                    numero = 1;
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                    numero = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) + 1;
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                }


                pr_code = textBox2.Text;

                //selectionner le libellé produit
                string MyConString2 = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection2 = new MySqlConnection(MyConString2);
                MySqlCommand cmd2 = connection2.CreateCommand();
                cmd2.CommandText = "select libelle_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                libelle_produit = cmd2.ExecuteScalar().ToString();
                connection2.Close();
                //selectionner le prix produit
                cmd2.CommandText = "select prix_vente_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                prix_vente_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
                //selectionner le TVA produit
                cmd2.CommandText = "select TVA_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                TVA_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
                //selectionner le remise produit
                cmd2.CommandText = "select remise_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                remise_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();


                pr_quantite = Convert.ToInt16(textBox7.Text);
                pr_montant = pr_quantite * prix_vente_produit;

                cma_code = Convert.ToInt16(tbCodeCommA.Text);

                dataGridView1.Rows.Add(numero, pr_code, libelle_produit, prix_vente_produit, TVA_produit, remise_produit, pr_quantite, pr_montant, cma_code);

                ModifierMontants_CA();

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
                pr_code = textBox2.Text;

                //selectionner le libellé produit
                string MyConString2 = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection2 = new MySqlConnection(MyConString2);
                MySqlCommand cmd2 = connection2.CreateCommand();
                cmd2.CommandText = "select libelle_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                libelle_produit = cmd2.ExecuteScalar().ToString();
                connection2.Close();
                //selectionner le prix produit
                cmd2.CommandText = "select prix_vente_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                prix_vente_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
                //selectionner le TVA produit
                cmd2.CommandText = "select TVA_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                TVA_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
                //selectionner la remise produit
                cmd2.CommandText = "select remise_produit from produit where code_produit ='" + pr_code + "';";
                connection2.Open();
                remise_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();


                pr_quantite = Convert.ToInt16(textBox7.Text);
                pr_montant = pr_quantite * prix_vente_produit;


                dataGridView1.SelectedRows[0].Cells[1].Value = pr_code;
                dataGridView1.SelectedRows[0].Cells[2].Value = libelle_produit;
                dataGridView1.SelectedRows[0].Cells[3].Value = prix_vente_produit;
                dataGridView1.SelectedRows[0].Cells[4].Value = TVA_produit;
                dataGridView1.SelectedRows[0].Cells[5].Value = remise_produit;
                dataGridView1.SelectedRows[0].Cells[6].Value = pr_quantite;
                dataGridView1.SelectedRows[0].Cells[7].Value = pr_montant;

                ModifierMontants_CA();

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lignecommandeachatTableAdapter.FillBy(this.gestioncommercialeDataSet1.lignecommandeachat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lignecommandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandeachat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lignecommandeachatTableAdapter.FillBy1(this.gestioncommercialeDataSet1.lignecommandeachat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(135, 55);
            pictureBox1.Location = new Point(198, 654);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(130, 50);
            pictureBox1.Location = new Point(200, 658);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(135,55);
            pictureBox2.Location = new Point(404, 656);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(130,50);
            pictureBox2.Location = new Point(406, 658);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(45,45);
            pictureBox6.Location = new Point(92, 124);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(40,40);
            pictureBox6.Location = new Point(94, 126);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(45,45);
            pictureBox7.Location = new Point(35, 124);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(40,40);
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
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.Location = new Point(565, 18);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.Location = new Point(567, 20);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.Location = new Point(611, 20);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(613, 20);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(45, 45);
            pictureBox5.Location = new Point(657, 18);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.Location = new Point(659, 20);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(35, 35);
            pictureBox10.Location = new Point(129, 31);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(30, 30);
            pictureBox10.Location = new Point(130,33);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.Location = new Point(284, 30);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.Location = new Point(286, 32);
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
            AjouterLigneCommandeAchat();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneCommandeAchat();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneCommandeAchat();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneCommandeAchat();
        }

        private void AjouterCommandeAchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeFourni.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
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

        private void tbCodeFourni_TextChanged(object sender, EventArgs e)
        {
            int fr_code = Convert.ToInt16(tbCodeFourni.Text);

            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select adresse_Fournisseur from fournisseur where idFournisseur ='" + fr_code + "';";
            connection.Open();
            adresse_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select codePostal_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            codePostal_Fournisseur = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select ville_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            ville_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select pays_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            pays_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select tel_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            tel_Fournisseur = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select telmobile_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            telmobile_Fournisseur = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select fax_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            fax_Fournisseur = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select email_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            email_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select siteInternet_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            siteInternet_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select note_Fournisseur from fournisseur where idFournisseur =" + fr_code + ";";
            connection.Open();
            note_Fournisseur = cmd.ExecuteScalar().ToString();
            connection.Close();

            rtbAdresse.Text = adresse_Fournisseur;
            tbCP.Text = codePostal_Fournisseur.ToString();
            tbVille.Text = ville_Fournisseur;
            tbPays.Text = pays_Fournisseur;
            tbFixe.Text = tel_Fournisseur.ToString();
            tbMobile.Text = telmobile_Fournisseur.ToString();
            tbFax.Text = fax_Fournisseur.ToString();
            tbEmail.Text = email_Fournisseur;
            tbSitew.Text = siteInternet_Fournisseur;
            rtbNote.Text = note_Fournisseur;
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SelectFournisseur sf = new SelectFournisseur();
            sf.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SelectProduit sp = new SelectProduit();
            sp.Show();
        }

        

        

    }
}
