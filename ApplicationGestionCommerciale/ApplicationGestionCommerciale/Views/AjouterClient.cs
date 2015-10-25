using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ApplicationGestionCommerciale
{
    public partial class AjouterClient : Form
    {
        Clients cl;
        Accueil ac;

        public AjouterClient(string code_Client,Clients cl,Accueil ac)
        {
            InitializeComponent();
            this.cl = cl;
            this.ac = ac;
            txtcode.Text = code_Client;

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
            if (textBox2.Text != "" || txtnom.Text != "" || txtprenom.Text != "" || txtadresse.Text != "" || textBox1.Text != "" || txtville.Text != "" || txtfix.Text != "" || txtmobile.Text != "" || txtfax.Text != "" || txtemail.Text != "" || txtsite.Text != "" || txtsociete.Text != "" || txtnotes.Text != "")
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
            if (txtcode.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtville.Text == "" || comboBox1.Text == "" || (txtfix.Text == "" && txtmobile.Text == "") || txtemail.Text == "" || textBox1.Text =="" )
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                if (txtfix.Text == "" && txtmobile.Text =="")
                {
                    label8.ForeColor = Color.Red;
                    label9.ForeColor = Color.Red;
                }
                if (txtemail.Text == "")
                {
                    label11.ForeColor = Color.Red;
                }
                if (textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
            }

            else
            {

                string etat = "Nouveau";
                int nbTr = 0;

                try
                {
                    Entity.Client C = new Entity.Client();

                    C.code_Client = Convert.ToInt16(txtcode.Text);
                    C.ref_Client = textBox2.Text;
                    C.nom_Client = txtnom.Text;
                    C.prenom_Client = txtprenom.Text;
                    C.adresse_Client = txtadresse.Text;
                    C.codepostal_Client = Convert.ToInt16(textBox1.Text);
                    C.ville_Client = txtville.Text;
                    C.pays_Client = comboBox1.Text;
                    C.telFixe_Client = int.Parse(txtfix.Text);
                    C.telMobile_Client = int.Parse(txtmobile.Text);
                    C.email_Client = txtemail.Text;
                    C.site_Client = txtsite.Text;
                    C.fax_Client = int.Parse(txtfax.Text);
                    C.societe_Client = txtsociete.Text;
                    C.etat_Client = etat;
                    C.nbTransactions_Client = nbTr;
                    C.notes_Client = txtnotes.Text;

                    DAL.DAL_Client.InsertClient(C);
                }
                catch (Exception ecc)
                {

                    MessageBox.Show(ecc.ToString());
                }

                cl.clientTableAdapter.Fill(cl.gestioncommercialeDataSet1.client);
                Hide();
                ac.Enabled = true;
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

        private void AjouterClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox2.Text != "" || txtnom.Text != "" || txtprenom.Text != "" || txtadresse.Text != "" || textBox1.Text != "" || txtville.Text != "" || txtfix.Text != "" || txtmobile.Text != "" || txtfax.Text != "" || txtemail.Text != "" || txtsite.Text != "" || txtsociete.Text != "" || txtnotes.Text != "")
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

        private void AjouterClient_Load(object sender, EventArgs e)
        {
            ac.Enabled = false;
        }
 




    }
}
