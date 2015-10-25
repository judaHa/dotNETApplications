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
    public partial class ModifierFacture : Form
    {
        int numero_ligneFacture;
        int numero;
        string Produit_codeProduit;
        double prix_vente_produit;
        string libelle_produit;
        double TVA_produit;
        double remise_produit;
        int quantite;
        double montant_Produit;
        int Facture_numeroFacture;

        double timbre_Facture;
        double remise_Facture;
        double montantHT_Facture;
        double montantTTC_Facture;


        Factures Formf;
        Facture f = new Facture();
        Accueil ac;

        public ModifierFacture(Factures Formf, Facture f,Accueil ac)
        {
            InitializeComponent();
            this.Formf = Formf;
            this.f = f;
            this.ac = ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(textBox5, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox6, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox7, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox3, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Modifier");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox5, "Supprimer");
        }

        //*******************************************************************************************************************************************************

        public void AjouterLigneFacture()
        {
            panel1.Visible = true;
            textBox2.Text = "";
            textBox7.Text = "";
            pictureBox9.Visible = false;
            pictureBox6.Visible = true;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        public void ModifierLigneFacture()
        {
            panel1.Visible = true;
            pictureBox9.Visible = true;
            pictureBox6.Visible = false;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

            numero_ligneFacture = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[9].Value);
            numero = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            Produit_codeProduit = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            quantite = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[6].Value);

            textBox2.Text = Produit_codeProduit;
            textBox7.Text = quantite.ToString();
            textBox7.Focus();
        }

        public void SupprimerLigneFacture()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                {
                    int numero_ligneFacture = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneFacture L = new LigneFacture(numero_ligneFacture);
                    L.SupprimerLigneFacture();
                    this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);

                    Selection();
                }
            }
        }

        public void Selection()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                numero = i + 1;
                Produit_codeProduit = dataGridView1.Rows[i].Cells[1].Value.ToString();

              //selectionner le libellé produit
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select libelle_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection.Open();
                libelle_produit = cmd.ExecuteScalar().ToString();
                connection.Close();
              //selectionner le prix produit
                cmd.CommandText = "select prix_vente_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection.Open();
                prix_vente_produit = Convert.ToDouble(cmd.ExecuteScalar());
                connection.Close();
              //selectionner le TVA produit
                cmd.CommandText = "select TVA_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection.Open();
                TVA_produit = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
              //selectionner la remise produit
                cmd.CommandText = "select remise_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection.Open();
                remise_produit = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                dataGridView1.Rows[i].Cells[0].Value = numero;
                dataGridView1.Rows[i].Cells[1].Value = Produit_codeProduit;
                dataGridView1.Rows[i].Cells[2].Value = libelle_produit;
                dataGridView1.Rows[i].Cells[3].Value = prix_vente_produit;
                dataGridView1.Rows[i].Cells[4].Value = TVA_produit;
                dataGridView1.Rows[i].Cells[5].Value = remise_produit;
            }
        }

        //*******************************************************************************************************************************************************



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
             if (rsl == DialogResult.Yes)
             {
                 Hide();
                 ac.Enabled = true;
             }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        
       

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
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
                Produit_codeProduit = textBox2.Text;
                // string libelle_produit;
                //double TVA_produit;
                //double remise_produit;
                quantite = Convert.ToInt16(textBox7.Text);
                montant_Produit = quantite * prix_vente_produit;


                LigneFacture L = new LigneFacture(numero_ligneFacture);
                L.ModifierLigneFacture( Produit_codeProduit, quantite, montant_Produit, Facture_numeroFacture);
                this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);

                textBox2.Text = "";
                textBox7.Text = "";
                panel1.Visible = false;

                Selection();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
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

                //numero_ligneFacture
                int numero_ligneFacture;
                if (dataGridView1.Rows.Count == 0)
                {
                    numero_ligneFacture = 1;
                }
                else
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(numero_ligneFacture) from lignefacture";
                    connection.Open();
                    numero_ligneFacture = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }


                string Produit_codeProduit = textBox2.Text;
                
                
           //selectionner le prix produit
                string MyConString2 = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection2 = new MySqlConnection(MyConString2);
                MySqlCommand cmd2 = connection2.CreateCommand();
                cmd2.CommandText = "select prix_vente_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                prix_vente_produit = Convert.ToInt32(cmd2.ExecuteScalar());
                connection2.Close();
           //selectionner le TVA produit
                cmd2.CommandText = "select TVA_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                TVA_produit = Convert.ToInt32(cmd2.ExecuteScalar());
                connection2.Close();
          //selectionner le remise produit
                cmd2.CommandText = "select remise_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                remise_produit = Convert.ToInt32(cmd2.ExecuteScalar());
                connection2.Close();

                
                int quantite = Convert.ToInt16(textBox7.Text);
                double montant_Produit = quantite * prix_vente_produit;
                int Facture_numeroFacture = Convert.ToInt16(textBox1.Text);

                         //recuperer le montant HT de la facture
                            montantHT_Facture += montant_Produit;
                            textBox3.Text = montantHT_Facture.ToString();
                         //recuperer le montant TTC
                            montantTTC_Facture = montantHT_Facture + ((TVA_produit * montantHT_Facture) / 100);
                            textBox4.Text = montantTTC_Facture.ToString();
               


                LigneFacture L = new LigneFacture(numero_ligneFacture, Produit_codeProduit, quantite, montant_Produit, Facture_numeroFacture);
                L.AjouterLigneFacture();
                this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);

                textBox2.Text = "";
                textBox7.Text = "";
                panel1.Visible = false;

                Selection();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Form Clients = new Clients(cl_show);
            //Clients.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                if (textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                if (textBox8.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
            }
               
            
            else
            {
                if (textBox5.Text == "")
                {
                    textBox5.Text = "0";
                }
                if (textBox6.Text == "")
                {
                    textBox6.Text = "0";
                }


                int numero_Facture = Convert.ToInt16(textBox1.Text);
                string date_Facture = dateTimePicker1.Value.ToString("dd / MM / yyyy");
                double timbre_Facture = Convert.ToDouble(textBox5.Text);
                double remise_Facture = Convert.ToDouble(textBox6.Text);
                montantHT_Facture = Convert.ToDouble(textBox3.Text);
                montantTTC_Facture = Convert.ToDouble(textBox4.Text); ;
                string statut_Facture;
                if (radioButton1.Checked == true)
                    statut_Facture = radioButton1.Text;
                else
                { statut_Facture = radioButton2.Text; }

                int Client_codeClient = Convert.ToInt16(textBox8.Text);

                f.modifierFacture(date_Facture, timbre_Facture, remise_Facture, montantHT_Facture, montantTTC_Facture, statut_Facture, Client_codeClient);
                Formf.factureTableAdapter.Fill(Formf.gestioncommercialeDataSet1.facture);

                Hide();
                ac.Enabled = true;
            }
        }

        private void ModifierFacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignefacture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);

            lignefactureBindingSource.Filter = "Facture_numeroFacture = " + Convert.ToInt16(f.numero_Facture);

            Facture_numeroFacture = f.numero_Facture;

            textBox1.Text = f.numero_Facture.ToString(); 
            textBox8.Text = f.Client_codeClient.ToString();
            dateTimePicker1.Text = f.date_Facture;
            textBox5.Text = f.timbre_Facture.ToString();
            textBox6.Text = f.remise_Facture.ToString();
            textBox3.Text = f.montantHT_Facture.ToString();
            textBox4.Text = f.montantTTC_Facture.ToString();
            if (f.statut_Facture == radioButton1.Text)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            Selection();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                AjouterLigneFacture();
            }
            else
            {
                panel1.Visible = false;
                textBox2.Text = "";
                textBox7.Text = "";
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                if (panel1.Visible == false)
                {
                    ModifierLigneFacture();
                }
                else
                {
                    panel1.Visible = false;
                    textBox2.Text = "";
                    textBox7.Text = "";
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                }
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            SupprimerLigneFacture();
        }

        private void ModifierFacture_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(29, 29);
            pictureBox8.Location = new Point(339, 75);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.Location = new Point(341, 77);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.Location = new Point(557, 40);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.Location = new Point(559, 42);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.Location = new Point(603, 42);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(605, 42);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.Location = new Point(649, 42);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.Location = new Point(651, 42);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(29, 29);
            pictureBox10.Location = new Point(128, 30);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.Location = new Point(130, 32);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(46, 43);
            pictureBox6.Location = new Point(33, 132);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(42, 39);
            pictureBox6.Location = new Point(35, 134);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(46, 43);
            pictureBox9.Location = new Point(33, 132);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(42, 39);
            pictureBox9.Location = new Point(35, 134);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(46, 43);
            pictureBox7.Location = new Point(90, 132);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(42, 39);
            pictureBox7.Location = new Point(92, 134);
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
            AjouterLigneFacture();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLigneFacture();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLigneFacture();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierLigneFacture();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                timbre_Facture = Convert.ToDouble(textBox5.Text);
            }
            else
            {
                timbre_Facture = 0;
            }
            montantTTC_Facture = montantHT_Facture + ((timbre_Facture * montantHT_Facture) / 100);
            textBox4.Text = montantTTC_Facture.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                remise_Facture = Convert.ToDouble(textBox6.Text);
            }
            else
            {
                remise_Facture = 0;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SelectProduit sp = new SelectProduit();
            sp.Show();
        }

        





        }
    }

