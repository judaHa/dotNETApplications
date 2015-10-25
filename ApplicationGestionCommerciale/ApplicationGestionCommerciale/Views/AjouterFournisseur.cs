using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    public partial class AjouterFournisseur : Form
    {
        Fournisseurs f;

        public AjouterFournisseur(string idFournisseur,Fournisseurs f)
        {
            InitializeComponent();
            txtcode.Text = idFournisseur;
            this.f = f;

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
            if (textBox2.Text != "" || txtnom.Text != "" || txtprenom.Text != "" || txtadresse.Text != "" && textBox1.Text != "" || txtville.Text != "" || txttel.Text != "" || txtcodepostal.Text != "" || txtfax.Text != "" || txtemail.Text != "" || txtsite.Text != "" || txtnotes.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    f.Enabled = true;
                }
            }
            else
            {
                Hide();
                f.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtville.Text == "" || comboBox1.Text == "" || (txttel.Text == "" && textBox1.Text=="") || txtemail.Text == "")
            {
                MessageBox.Show("Vous devez remplir les champs vides!", "Champs vides", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                label1.ForeColor = Color.Black;
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
                if (txttel.Text == "" && textBox1.Text == "")
                {
                    label8.ForeColor = Color.Red;
                    label1.ForeColor = Color.Red;
                }
                if (txtemail.Text == "")
                {
                    label10.ForeColor = Color.Red;
                }
            }


            else
            {
                string etat = "Nouveau";
                int nbTr = 0;

                try
                {
                    Entity.Fournisseur C = new Entity.Fournisseur();

                    C.idFournisseur =int.Parse( txtcode.Text);
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
                    C.etat_Fournisseur = etat;
                    C.nb_transactions_Fournisseur = nbTr;
                    C.note_Fournisseur = txtnotes.Text;

                    DAL.DAL_Fournisseur.InsertFournisseur(C);
                }
                catch (Exception ecc)
                {
                    MessageBox.Show(ecc.ToString());
                }
                f.fournisseurTableAdapter.Fill(f.gestioncommercialeDataSet1.fournisseur);

                
                Hide();
                f.Enabled = true;
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

        private void AjouterFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox2.Text != "" || txtnom.Text != "" || txtprenom.Text != "" || txtadresse.Text != "" && textBox1.Text != "" || txtville.Text != "" || txttel.Text != "" || txtcodepostal.Text != "" || txtfax.Text != "" || txtemail.Text != "" || txtsite.Text != "" || txtnotes.Text != "")
            {
                DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.Yes)
                {
                    Hide();
                    f.Enabled = true;
                }
            }
            else
            {
                Hide();
                f.Enabled = true;
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
