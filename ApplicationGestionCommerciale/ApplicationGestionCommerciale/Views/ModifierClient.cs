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
    public partial class ModifierClient : Form
    {
        public int code_Client;
        Clients cl;
        Accueil ac;

        public ModifierClient(Clients cl,Accueil ac)
        {
            InitializeComponent();
            this.cl = cl;
            this.ac = ac;

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(textBox1, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(txtfix, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(txtmobile, "Insertion des numéros uniquement.");

            t.ShowAlways = true;
            t.SetToolTip(txtfax, "Insertion des numéros uniquement.");
        }

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
            if (txtcode.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtville.Text == "" || comboBox1.Text == "" || (txtfix.Text == "" && txtmobile.Text == "") || txtemail.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;

                if (txtcode.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                if (txtnom.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                if (txtprenom.Text == "")
                {
                    label4.ForeColor = Color.Red;
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
                if (txtfix.Text == "" && txtmobile.Text == "")
                {
                    label8.ForeColor = Color.Red;
                    label9.ForeColor = Color.Red;
                }
                if (txtemail.Text == "")
                {
                    label11.ForeColor = Color.Red;
                }


            }
            else
            {

                Entity.Client C = new Entity.Client();

                C.code_Client = int.Parse(txtcode.Text);
                C.ref_Client = textBox2.Text;
                C.nom_Client = txtnom.Text;
                C.prenom_Client = txtprenom.Text;
                C.adresse_Client = txtadresse.Text;
                C.codepostal_Client = int.Parse(textBox1.Text);
                C.ville_Client = txtville.Text;
                C.pays_Client = comboBox1.Text;
                C.telFixe_Client = int.Parse(txtfix.Text);
                C.telMobile_Client = int.Parse(txtmobile.Text);
                C.email_Client = txtemail.Text;
                C.site_Client = txtsite.Text;
                C.fax_Client = int.Parse(txtfax.Text);
                C.societe_Client = txtsociete.Text;

                if (radionouveau.Checked == true)
                {
                    C.etat_Client = "Nouveau";
                }
                else if (Radiofidele.Checked == true)
                { C.etat_Client = "Fidele"; }
                else if (radiooccasio.Checked == true) { C.etat_Client = "Occasionnel"; }

                C.notes_Client = txtnotes.Text;

                DAL.DAL_Client.UpdateClient(C);
             //   if (DAL.DAL_Client.UpdateClient(C) == true)
              //  { MessageBox.Show("Mise à jour avec succès").ToString(); }

                //else { MessageBox.Show("Mise à jour échouée").ToString(); }

                cl.clientTableAdapter.Fill(cl.gestioncommercialeDataSet1.client);
                Hide();
                ac.Enabled = true;
            }
        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {
           // lcodeClient.Text = code_Client;

            try
            {
                MySqlConnection _Cnn = DAL.Connexion.connect();
                _Cnn.Open();
                string strSql = "Select * from client where code_Client=?code_Client ";

                MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
                cmd.Parameters.AddWithValue("?code_Client", code_Client);
                cmd.CommandText = strSql;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtcode.Text = reader["code_Client"].ToString();
                    textBox2.Text = reader["ref_Client"].ToString();
                    txtnom.Text = reader["nom_Client"].ToString();
                    txtprenom.Text = reader["prenom_Client"].ToString();
                    txtadresse.Text = reader["adresse_Client"].ToString();
                    textBox1.Text = reader["codepostal_Client"].ToString();
                    txtville.Text = reader["ville_Client"].ToString();
                    comboBox1.Text = reader["pays_Client"].ToString();
                    txtfix.Text = reader["telFixe_Client"].ToString();
                    txtmobile.Text = (reader["telMobile_Client"]).ToString();
                    txtemail.Text = reader["email_Client"].ToString();
                    txtsite.Text = reader["site_Client"].ToString();
                    txtfax.Text = (reader["fax_Client"]).ToString();
                    txtsociete.Text = reader["societe_Client"].ToString();


                    if (reader["etat_Client"].ToString() == "Nouveau")
                    {
                        radionouveau.Checked = true;
                    }
                    else if (reader["etat_Client"].ToString() == "Fidele")
                    {
                        Radiofidele.Checked = true;
                    }
                    else if (reader["etat_Client"].ToString() == "Occasionnel") { radiooccasio.Checked = true; }

                    txtnotes.Text = reader["notes_Client"].ToString();
                }
                reader.Close();
                _Cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModifierClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
                ac.Enabled = true;
            }
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
