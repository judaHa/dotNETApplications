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
    public partial class AjouterDevis : Form
    {
        Devis1 d;
        Accueil ac;

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

        int num_ligne_devis;
        int numero;
        int dv_code;
        string pr_code;
        string libelle_produit;
        double prix_vente_produit;
        double TVA_produit;
        double remise_produit;
        int pr_quantite;
        double pr_montant;

        double montantHT_Devis;
        double montantTTC_Devis;

        double TVA_Total;


        public AjouterDevis(string dv_code, Devis1 d,Accueil ac)
        {
            InitializeComponent();
            tbCodeDevis.Text = dv_code;
            this.d = d;
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

        //*******************************************************************************************************************************

        public void AjouterLigneDevis()
        {
            panel2.Visible = true;
            pictureBox9.Visible = false;
            pictureBox8.Visible = true;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        public void ModifierLigneDevis()
        {
            panel2.Visible = true;
            pictureBox9.Visible = true;
            pictureBox6.Visible = false;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

            numero = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            pr_code = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pr_quantite = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[6].Value);

            textBox2.Text = pr_code;
            textBox7.Text = pr_quantite.ToString();
            textBox7.Focus();
        }

        public void SupprimerLigneDevis()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        ModifierMontants_Devis();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        }
                    }
                    else
                    {
                        montantHT_Devis = 0;
                        tbHT.Text = "0";
                        montantTTC_Devis = 0;
                        tbTTC.Text = "0";
                    }

                    /*int num_ligne_devis = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneDevis L = new LigneDevis(num_ligne_devis);
                    L.ld_supprimer();
                    this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);*/
                }
            }
        }

        public void ModifierMontants_Devis()
        {
            montantHT_Devis = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                montantHT_Devis = montantHT_Devis + Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                tbHT.Text = montantHT_Devis.ToString();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TVA_Total = TVA_Total + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            montantTTC_Devis = montantHT_Devis + TVA_Total;
            tbTTC.Text = montantTTC_Devis.ToString();
        }

  //****************************************************************************************************************************************************
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeClient.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
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
             string  dv_adresse, dv_ville, dv_pays, dv_email, dv_sitew, dv_note , dv_date , dv_statut;
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
                    dv_statut = "Actif";

                    Devis dv = new Devis(dv_code, cl_code,dv_statut, dv_date,  dv_adresse, dv_ville, dv_cp, dv_pays, dv_fixe, dv_mobile, dv_fax, dv_email, dv_sitew, dv_note);
                    dv.dv_ajouter();
                    d.devisTableAdapter.Fill(d.gestioncommercialeDataSet1.devis);

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                        MySqlConnection connection = new MySqlConnection(MyConString);
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select count(*) from lignedevis";
                        connection.Open();
                        int num = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();
                        if (num != 0)
                        {
                            cmd.CommandText = "select max(num_ligne_devis) from lignedevis;";
                            connection.Open();
                            num_ligne_devis = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                            connection.Close();
                        }
                        else
                        {
                            num_ligne_devis = 1;
                        }
                        dataGridView1.Rows[i].Cells[8].Value = num_ligne_devis;
                        num_ligne_devis = Convert.ToInt16(dataGridView1.Rows[i].Cells[8].Value);
                        pr_code = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        pr_quantite = Convert.ToInt16(dataGridView1.Rows[i].Cells[6].Value);
                        pr_montant = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                        LigneDevis L = new LigneDevis(num_ligne_devis, dv_code, pr_code, pr_quantite, pr_montant);
                        L.ld_ajouter();
                    }

                    Hide();
                    ac.Enabled = true;
                }
            }
            
            catch(FormatException)
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }

        }

       
        private void AjouterDevis_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignedevis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);
            lignedevisBindingSource.Filter = "dv_code = " + Convert.ToInt16(tbCodeDevis.Text);
            ModifierMontants_Devis();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SupprimerLigneDevis();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void AjouterDevis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || tbCodeClient.Text != "" || rtbAdresse.Text != "" || tbCP.Text != "" || tbVille.Text != "" || tbFixe.Text != "" || tbMobile.Text != "" || tbFax.Text != "" || tbEmail.Text != "" || tbSitew.Text != "" || rtbNote.Text != "")
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
                //numero : numero de la ligne_factue dans la facture

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

                dv_code = Convert.ToInt16(tbCodeDevis.Text);

                dataGridView1.Rows.Add(numero, pr_code, libelle_produit, prix_vente_produit, TVA_produit, remise_produit, pr_quantite, pr_montant, dv_code);

                ModifierMontants_Devis();

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox7.Text = "";
            panel2.Visible = false;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK,MessageBoxIcon.Error);
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

                ModifierMontants_Devis();

                textBox2.Text = "";
                textBox7.Text = "";
                panel2.Visible = false;

                /*LigneDevis L = new LigneDevis(num_ligne_devis);
                L.ld_modifier(dv_code, pr_code, pr_quantite, pr_montant);
                this.lignedevisTableAdapter.Fill(this.gestioncommercialeDataSet1.lignedevis);*/

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneDevis();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneDevis();
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

        







    }
}
