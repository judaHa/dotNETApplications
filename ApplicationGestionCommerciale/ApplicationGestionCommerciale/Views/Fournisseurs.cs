using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Properties;

namespace ApplicationGestionCommerciale
{
    public partial class Fournisseurs : Form
    {
        Boolean a = true;
        Boolean b = true;
        Accueil ac;

        public Fournisseurs(Accueil ac)
        {
            InitializeComponent();
            this.ac=ac;
        }
        public Fournisseurs()
        {
           
        }

        //******************************************************************************************************************
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:    //message WM_NCHITTEST
                    base.WndProc(ref m);
                    if (m.Result == (IntPtr)2)        // 2 =  barre de titre
                        m.Result = (IntPtr)0;     //0 = fond de la fenetre
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ajouter()
        {
            int fr_code = 1;
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(idFournisseur) from fournisseur";
                    connection.Open();
                    fr_code = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }
                Form a = new AjouterFournisseur(Convert.ToString(fr_code),this);
                a.Show();
                ac.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void modifier()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int codamodif = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ModifierFournisseur ad = new ModifierFournisseur(this,ac);
                ad.idFournisseur = codamodif;
                ad.Show();
                ac.Enabled = false;
            }
        }

        private void supprimer()
        {

            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlConnection _Conn = DAL.Connexion.connect();

                    _Conn.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from fournisseur where idFournisseur=" + (dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + " ", _Conn);

                    string codasuppr = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    da.Fill(dt);

                    string nom = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                    string messageBoxText = "voulez vous supprimer le fournisseur \n code : " + codasuppr + " nom : " + nom + " ?";
                    string caption = "Supprimer Fournisseur?";
                    // MessageBoxButtons b = new MessageBoxButtons();
                    MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);


                    switch (result)
                    {
                        case DialogResult.Yes:
                            try
                            {
                                if (DAL.DAL_Fournisseur.DeleteFournisseur(codasuppr) == true)
                                {

                                    MessageBox.Show("Fournisseur Supprimé", "Succès");
                                }

                            }
                            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                            break;
                        case DialogResult.No:

                            break;
                        case DialogResult.Cancel:

                            break;
                    }
                }
                else { MessageBox.Show("Liste vide!","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }

                dataGridView1.DataSource = DAL.DAL_Fournisseur.affichgrid(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void afficherrecherche()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                dataGridView1.Location = new Point(87, 12);
                dataGridView1.Size = new Size(759, 374);
                textBox1.Text = "";
                radioButton1.Checked = true;
                comboBox1.Text = "Nouveau";
                textBox1.Visible = true;
                comboBox1.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                dataGridView1.Location = new Point(87, 88);
                dataGridView1.Size = new Size(759, 298);
                textBox1.Focus();
            }
        }
        private void effectuerrecherche()
        {
            if (radioButton1.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "idFournisseur =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton2.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "ref_Fournisseur ='" + textBox1.Text + "%'";
            }
            else if (radioButton3.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "nom_Fournisseur ='" + textBox1.Text + "%'";
            }
            else if (radioButton4.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "prenom_Fournisseur ='" + textBox1.Text + "%'";
            }
            else if (radioButton5.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "ville_Fournisseur ='" + textBox1.Text + "%'";
            }
            else if (radioButton6.Checked && textBox1.Text != "")
            {
                fournisseurBindingSource.Filter = "pays_Fournisseur ='" + textBox1.Text + "%'";
            }
            else if (radioButton2.Checked)
            {
                fournisseurBindingSource.Filter = "etat_Fournisseur ='" + comboBox1.Text + "%'";
            }

        }

        private void imprimer()
        {

        }

        //****************************************************************************************************************************************

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.fournisseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fournisseurTableAdapter.Fill(this.gestioncommercialeDataSet1.fournisseur);
            dataGridView1.DataSource = DAL.DAL_Fournisseur.affichgrid(dataGridView1); 
        }

        private void Fournisseurs_KeyUp(object sender, KeyEventArgs e)
        {
            if (b == true)
            {
                if (e.KeyData == Keys.A)
                {
                    ajouter();
                }
                else if (e.KeyData == Keys.M)
                {
                    modifier();
                }
                else if (e.KeyData == Keys.S)
                {
                    supprimer();
                }
                else if (e.KeyData == Keys.I)
                {
                    imprimer();
                }
                else if (e.KeyData == Keys.R)
                {
                    afficherrecherche();
                }
                else if (e.KeyData == Keys.P)
                {
                    Form p = new Parametres();
                    p.Show();
                }
            }
        }

        private void Fournisseurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(65, 75);
            pictureBox2.Location = new Point(11, 10);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(60, 70);
            pictureBox2.Location = new Point(13, 12);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(65, 75);
            pictureBox3.Location = new Point(11, 86);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(60, 70);
            pictureBox3.Location = new Point(13, 88);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(65, 75);
            pictureBox4.Location = new Point(11, 162);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(60, 70);
            pictureBox4.Location = new Point(13, 164);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(65, 75);
            pictureBox5.Location = new Point(11, 238); ;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(60, 70);
            pictureBox5.Location = new Point(13, 240);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(65, 75);
            pictureBox6.Location = new Point(11, 314);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(60, 70);
            pictureBox6.Location = new Point(13, 316);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Nouveau";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = false;
            comboBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Focus();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifier();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (a == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    b = false;
                    e.Handled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = false;
            effectuerrecherche();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void ajouterFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void modifierFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void supprimerFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void imprimerFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void rechercherFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            b = true;
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



    }
}
