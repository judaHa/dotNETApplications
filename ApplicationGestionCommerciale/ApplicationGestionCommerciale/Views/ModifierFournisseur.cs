using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApplicationGestionCommerciale
{
    public partial class ModifierFournisseur : Form
    {
        public int idFournisseur;
        Fournisseurs f;
        Accueil ac;

        public ModifierFournisseur(Fournisseurs f,Accueil ac)
        {
            InitializeComponent();
            this.f = f;
            this.ac = ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(txtcodepostal, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(txttel, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(textBox1, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(txtfax, "Insertion des numéros uniquement.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel);
             if (rsl == DialogResult.Yes)
             {
                 Hide();
                 ac.Enabled = true;
             }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtville.Text == "" || comboBox1.Text == "" || txttel.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK);
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;

                if (txtnom.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                if (txtprenom.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                if (txtcodepostal.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
                if (txtadresse.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                if (txtville.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                if (comboBox1.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                if (txttel.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                if (txtemail.Text == "")
                {
                    label10.ForeColor = Color.Red;
                }
            }
            else
            {

                Entity.Fournisseur C = new Entity.Fournisseur();

                C.idFournisseur = int.Parse(txtcode.Text);
                C.ref_Fournisseur = textBox2.Text;
                C.nom_Fournisseur = txtnom.Text;
                C.prenom_Fournisseur = txtprenom.Text;
                C.adresse_Fournisseur = txtadresse.Text;
                C.codePostal_Fournisseur = int.Parse(txtcodepostal.Text);
                C.ville_Fournisseur = txtville.Text;
                C.pays_Fournisseur = comboBox1.Text;
                C.tel_Fournisseur = int.Parse(txttel.Text);
                C.telmobile_Fournisseur = int.Parse(textBox1.Text);
                C.email_Fournisseur = txtemail.Text;
                C.fax_Fournisseur = int.Parse(txtfax.Text);
                C.siteInternet_Fournisseur = txtsite.Text;
                

                if (rbNouveau.Checked == true)
                {
                    C.etat_Fournisseur = "Nouveau";
                }
                else if (rbActif.Checked == true)
                { 
                    C.etat_Fournisseur = "Actif";
                }
                else if (rbInactif.Checked == true) 
                { 
                    C.etat_Fournisseur = "Inactif"; 
                }

                C.note_Fournisseur = txtnotes.Text;

                DAL.DAL_Fournisseur.UpdateFournisseur(C);

              //  if (DAL.DAL_Fournisseur.UpdateFournisseur(C) == true)
             //   { MessageBox.Show("Mise à jour avec succes").ToString(); }

              //  else { MessageBox.Show("Mise à jour echouee").ToString(); }
                
                f.fournisseurTableAdapter.Fill(f.gestioncommercialeDataSet1.fournisseur);

                Hide();
                ac.Enabled = true;
            }
        }

        private void txtcodepostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModifierFournisseur_Load(object sender, EventArgs e)
        {
            //lcodef.Text = idFournisseur ;

            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            string strSql = "Select * from fournisseur where idFournisseur=?idFournisseur "; 

            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.Parameters.AddWithValue("?idFournisseur", idFournisseur);  
            cmd.CommandText = strSql;


            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    txtcode.Text = reader["idFournisseur"].ToString();
                    textBox2.Text = reader["ref_Fournisseur"].ToString();
                    txtnom.Text = reader["nom_Fournisseur"].ToString();
                    txtprenom.Text = reader["prenom_Fournisseur"].ToString();
                    txtadresse.Text = reader["adresse_Fournisseur"].ToString();
                    txtcodepostal.Text = (reader["codePostal_Fournisseur"]).ToString();
                    txtville.Text = reader["ville_Fournisseur"].ToString();
                    comboBox1.Text = reader["pays_Fournisseur"].ToString();
                    txttel.Text = reader["tel_Fournisseur"].ToString();
                    textBox1.Text = reader["telmobile_Fournisseur"].ToString();
                    txtemail.Text = reader["email_Fournisseur"].ToString();
                    txtfax.Text = (reader["fax_Fournisseur"]).ToString();
                    txtsite.Text =reader["siteInternet_Fournisseur"].ToString();
                    txtnotes.Text = reader["note_Fournisseur"].ToString();


                    if ((reader["etat_Fournisseur"].ToString()) == "Nouveau" )
                    {
                        rbNouveau.Checked = true;
                    }
                    else if (reader["etat_Fournisseur"].ToString() == "Actif")
                    {
                        rbActif.Checked = true;
                    }
                    else if (reader["etat_Fournisseur"].ToString() == "Inactif") { 
                        rbInactif.Checked = true; }

                    
                }
                reader.Close();
            }
            catch
            {
                _Cnn.Close();
            } 
        }

        private void ModifierFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtemail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("E-mail non valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.SelectAll();
                    e.Cancel = true;
                }
            }
        }




    }
}
