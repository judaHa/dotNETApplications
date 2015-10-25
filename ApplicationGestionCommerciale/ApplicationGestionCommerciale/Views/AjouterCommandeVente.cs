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
    public partial class AjouterCommandeVente : Form
    {
        CommandesVente cv;

        string adresse_Client;
        int codepostal_Client;
        string ville_Client;
        string pays_Client;
        int telFixe_Client;
        int telMobile_Client;
        int fax_Client;
        string email_Client;
        string site_Client;
        string notes_Client;

        int num_ligne_commande;
        int numero;
        int cmv_code;
        string pr_code;
        string libelle_produit;
        double prix_vente_produit;
        double TVA_produit;
        double remise_produit;
        int pr_quantite;
        double pr_montant;

        double montantHT_CV;
        double montantTTC_CV;

        double TVA_Total;

        public AjouterCommandeVente(string cmv_code,CommandesVente cv)
        {
            InitializeComponent();
            tbCodeCommV.Text = cmv_code;
            this.cv = cv;

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
            t.SetToolTip(pictureBox3, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox5, "Supprimer");
        }

//*******************************************************************************************************************************************************************
        public void AjouterLigneCommandeVente()
        {
            panel2.Visible = true;
            pictureBox9.Visible = false;
            pictureBox7.Visible = true;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        public void ModifierLigneCommandeVente()
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

        public void SupprimerLigneCommandeVente()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (rsl == DialogResult.Yes)
                {
                    Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        this.dataGridView1.Rows.RemoveAt(rowToDelete);
                    }

                    if (dataGridView1.Rows.Count != 0)
                    {
                        ModifierMontants_CV();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        }
                    }
                    else
                    {
                        montantHT_CV = 0;
                        textBox3.Text = "0";
                        montantTTC_CV = 0;
                        textBox4.Text = "0";
                    }
                    /*int num_ligne_commande = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneCommandeVente L = new LigneCommandeVente(num_ligne_commande);
                    L.lcmv_supprimer();
                    this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);*/
                }
            }
        }

        public void ModifierMontants_CV()
        {
            montantHT_CV = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                montantHT_CV = montantHT_CV + Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                textBox3.Text = montantHT_CV.ToString();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TVA_Total = TVA_Total + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            montantTTC_CV = montantHT_CV + TVA_Total;
            textBox4.Text = montantTTC_CV.ToString();
        }

 //*******************************************************************************************************************************************************************


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeClient.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    cv.Enabled = true;
                }
            }
            else
            {
                Hide();
                cv.Enabled = true;
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

                    if (tbFrais.Text == "")
                        cmv_frais = 0;
                    else
                        cmv_frais = Convert.ToDouble(tbFrais.Text);

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
                    cmv_statut = "Active";

                    CommandeVente cmv = new CommandeVente(cmv_code, cl_code, cmv_statut, cmv_date, cmv_date_liv, cmv_adresse, cmv_ville, cmv_cp, cmv_pays, cmv_fixe, cmv_mobile, cmv_fax, cmv_email, cmv_sitew, cmv_note, cmv_frais);
                    cmv.cmv_ajouter();
                    cv.commandeventeTableAdapter.Fill(cv.gestioncommercialeDataSet1.commandevente);


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                        MySqlConnection connection = new MySqlConnection(MyConString);
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select count(*) from lignecommandevente";
                        connection.Open();
                        int num = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();
                        if (num != 0)
                        {
                            cmd.CommandText = "select max(num_ligne_commande) from lignecommandevente;";
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

                        LigneCommandeVente L = new LigneCommandeVente(num_ligne_commande, cmv_code, pr_code, pr_quantite, pr_montant);
                        L.lcmv_ajouter();

                    }

                    Hide();
                    cv.Enabled = true;
                    }
                
            }

            catch (FormatException)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AjouterCommandeVente_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignecommandevente'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignecommandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.lignecommandevente);
            lignecommandeventeBindingSource.Filter = "cmv_code = " + Convert.ToInt16(tbCodeCommV.Text);
            ModifierMontants_CV();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                AjouterLigneCommandeVente();
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
                    ModifierLigneCommandeVente();
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

        private void AjouterCommandeVente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeClient.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    cv.Enabled = true;
                }
            }
            else
            {
                Hide();
                cv.Enabled = true;
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

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        { 
            panel2.Visible = false;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
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

                cmv_code = Convert.ToInt16(tbCodeCommV.Text);

                dataGridView1.Rows.Add(numero, pr_code, libelle_produit, prix_vente_produit, TVA_produit, remise_produit, pr_quantite, pr_montant, cmv_code);

                ModifierMontants_CV();

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SupprimerLigneCommandeVente();
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

                ModifierMontants_CV();

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

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(29, 29);
            pictureBox8.Location = new Point(298, 53);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.Location = new Point(300, 55);
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
            AjouterLigneCommandeVente();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneCommandeVente();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneCommandeVente();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneCommandeVente();
        }

        private void tbCodeClient_TextChanged(object sender, EventArgs e)
        {
            int cl_code = Convert.ToInt16(tbCodeClient.Text);

            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select adresse_Client from client where code_Client ='" + cl_code + "';";
            connection.Open();
            adresse_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select codepostal_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            codepostal_Client = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select ville_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            ville_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select pays_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            pays_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select telFixe_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            telFixe_Client = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select telMobile_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            telMobile_Client = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select fax_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            fax_Client = Convert.ToInt16(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select email_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            email_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select site_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            site_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd.CommandText = "select notes_Client from client where code_Client =" + cl_code + ";";
            connection.Open();
            notes_Client = cmd.ExecuteScalar().ToString();
            connection.Close();

            rtbAdresse.Text = adresse_Client;
            tbCP.Text = codepostal_Client.ToString();
            tbVille.Text = ville_Client;
            tbPays.Text = pays_Client;
            tbFixe.Text = telFixe_Client.ToString();
            tbMobile.Text = telMobile_Client.ToString();
            tbFax.Text = fax_Client.ToString();
            tbEmail.Text = email_Client;
            tbSitew.Text = site_Client;
            rtbNote.Text = notes_Client;
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
            SelectClient sc = new SelectClient();
            sc.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SelectProduit sp = new SelectProduit();
            sp.Show();
        }

       



     
    }
}
