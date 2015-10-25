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
    public partial class AjouterFacture : Form
    {
        Factures f;
        Accueil ac;

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
        double montantHT_Facture =0;
        double montantTTC_Facture =0;

        public AjouterFacture(string numero_Facture, Factures f,Accueil ac)
        {
            InitializeComponent();
            textBox1.Text = numero_Facture;
            this.f = f;
            this.ac = ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(textBox5, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox6, "Insertion des numéros uniquement (Ex : 1,01).");

            t.ShowAlways = true;
            t.SetToolTip(textBox7, "Insertion des numéros uniquement (Ex : 1,01).");
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

            //numero_ligneFacture = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
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
                DialogResult rsl = MessageBox.Show("Voulez-vous vraiment éliminer ce produit de la facture?", "Supprimer Produit de la facture", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                {
                    Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        this.dataGridView1.Rows.RemoveAt(rowToDelete);
                    }

                    if (dataGridView1.Rows.Count != 0)
                    {
                        ModifierMontants_Facture();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        }
                    }
                    else
                    {
                        montantHT_Facture = 0;
                        textBox3.Text = "0";
                        montantTTC_Facture = 0;
                        textBox4.Text = "0";
                    }
                    
                    /*int numero_ligneFacture = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    LigneFacture L = new LigneFacture(numero_ligneFacture);
                    L.SupprimerLigneFacture();
                    this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);*/
                }
            }
        }

        public void ModifierMontants_Facture()
        {
            montantHT_Facture = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                montantHT_Facture = montantHT_Facture + Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                textBox3.Text = montantHT_Facture.ToString();

                montantTTC_Facture = montantHT_Facture + ((timbre_Facture * montantHT_Facture) / 100);
                textBox4.Text = montantTTC_Facture.ToString();
            }
        }

        

        //*******************************************************************************************************************************************************



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || textBox8.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox2.Text != "" || textBox7.Text != "")
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



        private void pictureBox6_Click(object sender, EventArgs e)
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
                

                Produit_codeProduit = textBox2.Text;

            //selectionner le libellé produit
                string MyConString2 = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection2 = new MySqlConnection(MyConString2);
                MySqlCommand cmd2 = connection2.CreateCommand();
                cmd2.CommandText = "select libelle_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                libelle_produit = cmd2.ExecuteScalar().ToString();
                connection2.Close();
            //selectionner le prix produit
                cmd2.CommandText = "select prix_vente_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                prix_vente_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
            //selectionner le TVA produit
                cmd2.CommandText = "select TVA_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                TVA_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
            //selectionner le remise produit
                cmd2.CommandText = "select remise_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                remise_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();


                quantite = Convert.ToInt16(textBox7.Text);
                montant_Produit = quantite * prix_vente_produit;

                Facture_numeroFacture = Convert.ToInt16(textBox1.Text);

                dataGridView1.Rows.Add(numero, Produit_codeProduit, libelle_produit, prix_vente_produit, TVA_produit, remise_produit, quantite, montant_Produit, Facture_numeroFacture);

                ModifierMontants_Facture();

                textBox2.Text = "";
                textBox7.Text = "";
                panel1.Visible = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox7.Text = "";
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            panel1.Visible = false;

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

              
                double montantHT_Facture = Convert.ToDouble(textBox3.Text);
                double montantTTC_Facture = Convert.ToDouble(textBox4.Text);

                int Client_codeClient = Convert.ToInt16(textBox8.Text);

                string statut_Facture;
                if (radioButton1.Checked == true)
                    statut_Facture = radioButton1.Text;
                else
                { statut_Facture = radioButton2.Text; }

                Facture F = new Facture(numero_Facture, date_Facture, timbre_Facture, remise_Facture, montantHT_Facture, montantTTC_Facture, statut_Facture, Client_codeClient);
                F.creerFacture();
                f.factureTableAdapter.Fill(f.gestioncommercialeDataSet1.facture);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //numero_ligneFacture : numero de la ligne_factue dans la base

                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select count(*) from lignefacture"; //where Facture_numeroFacture = " + Facture_numeroFacture;
                    connection.Open();
                    int num = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();
                    if (num != 0)
                    {
                        cmd.CommandText = "select max(numero_ligneFacture) from lignefacture;"; //where Facture_numeroFacture = " + Facture_numeroFacture;
                        connection.Open();
                        numero_ligneFacture = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                        connection.Close();
                    }
                    else
                    {
                        numero_ligneFacture = 1;
                    }
                    dataGridView1.Rows[i].Cells[8].Value = numero_ligneFacture;
                    numero_ligneFacture = Convert.ToInt16(dataGridView1.Rows[i].Cells[8].Value);
                    Produit_codeProduit = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    quantite = Convert.ToInt16(dataGridView1.Rows[i].Cells[6].Value);
                    montant_Produit = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    Facture_numeroFacture = numero_Facture;

                    LigneFacture L = new LigneFacture(numero_ligneFacture,Produit_codeProduit, quantite, montant_Produit, Facture_numeroFacture);
                    L.AjouterLigneFacture();
                }

                //this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);

                Hide();
                ac.Enabled = true;
            }
           
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

           //selectionner le libellé produit
                string MyConString2 = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection2 = new MySqlConnection(MyConString2);
                MySqlCommand cmd2 = connection2.CreateCommand();
                cmd2.CommandText = "select libelle_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                libelle_produit = cmd2.ExecuteScalar().ToString();
                connection2.Close();
           //selectionner le prix produit
                cmd2.CommandText = "select prix_vente_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                prix_vente_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
           //selectionner le TVA produit
                cmd2.CommandText = "select TVA_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                TVA_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();
           //selectionner la remise produit
                cmd2.CommandText = "select remise_produit from produit where code_produit ='" + Produit_codeProduit + "';";
                connection2.Open();
                remise_produit = Convert.ToDouble(cmd2.ExecuteScalar());
                connection2.Close();


                quantite = Convert.ToInt16(textBox7.Text);
                montant_Produit = quantite * prix_vente_produit;


                dataGridView1.SelectedRows[0].Cells[1].Value = Produit_codeProduit;
                dataGridView1.SelectedRows[0].Cells[2].Value = libelle_produit;
                dataGridView1.SelectedRows[0].Cells[3].Value = prix_vente_produit;
                dataGridView1.SelectedRows[0].Cells[4].Value = TVA_produit;
                dataGridView1.SelectedRows[0].Cells[5].Value = remise_produit;
                dataGridView1.SelectedRows[0].Cells[6].Value = quantite;
                dataGridView1.SelectedRows[0].Cells[7].Value = montant_Produit;

                ModifierMontants_Facture();

                textBox2.Text = "";
                textBox7.Text = "";
                panel1.Visible = false;

                //LigneFacture L = new LigneFacture(numero_ligneFacture);
                //L.ModifierLigneFacture(Produit_codeProduit, quantite, montant_Produit, Facture_numero_Facture);
                //this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);
            }
        }

        private void AjouterFacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.lignefacture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.lignefactureTableAdapter.Fill(this.gestioncommercialeDataSet1.lignefacture);
            lignefactureBindingSource.Filter = "Facture_numeroFacture = " + Convert.ToInt16(textBox1.Text);
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
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

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SupprimerLigneFacture();
        }

        private void AjouterFacture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 || textBox8.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox2.Text != "" || textBox7.Text != "")
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

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.Location = new Point(339, 75);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.Location = new Point(341, 77);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(29, 29);
            pictureBox10.Location = new Point(128, 30);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.Location = new Point(130,32);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.Location = new Point(557, 40);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(559, 42);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.Location = new Point(603, 42);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.Location = new Point(605, 42);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(48, 48);
            pictureBox8.Location = new Point(649, 42);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(40, 40);
            pictureBox8.Location = new Point(651, 42);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(46, 43);
            pictureBox6.Location = new Point(35, 124);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(42, 39);
            pictureBox6.Location = new Point(37, 126);
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

        

        


    }
}
