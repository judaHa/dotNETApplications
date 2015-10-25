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
    public partial class Devis1 : Form
    {
        Boolean a = true;
        Boolean b = true;
        Accueil ac;

        public Devis1(Accueil ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        public Devis1()
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
            int dv_code = 1;
            try
            {
                if (dgvDevis.Rows.Count != 0)
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(dv_code) from devis";
                    connection.Open();
                    dv_code = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }
                AjouterDevis ad = new AjouterDevis(Convert.ToString(dv_code),this,ac);
                ad.Show();
                ac.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void modifier()
        {
            if (dgvDevis.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int v_code = Convert.ToInt16(dgvDevis.CurrentRow.Cells[0].Value.ToString());
                int v_cl_code = Convert.ToInt16(dgvDevis.CurrentRow.Cells[1].Value.ToString());
                string v_date = Convert.ToString(dgvDevis.CurrentRow.Cells[2].Value.ToString());
                string v_statut = Convert.ToString(dgvDevis.CurrentRow.Cells[3].Value.ToString());
                string v_adresse = Convert.ToString(dgvDevis.CurrentRow.Cells[4].Value.ToString());
                string v_ville = Convert.ToString(dgvDevis.CurrentRow.Cells[5].Value.ToString());
                int v_cp = Convert.ToInt32(dgvDevis.CurrentRow.Cells[6].Value.ToString());
                string v_pays = Convert.ToString(dgvDevis.CurrentRow.Cells[7].Value.ToString());
                int v_fixe = Convert.ToInt32(dgvDevis.CurrentRow.Cells[8].Value.ToString());
                int v_fax = Convert.ToInt32(dgvDevis.CurrentRow.Cells[9].Value.ToString());
                int v_mobile = Convert.ToInt32(dgvDevis.CurrentRow.Cells[10].Value.ToString());
                string v_email = Convert.ToString(dgvDevis.CurrentRow.Cells[11].Value.ToString());
                string v_sitew = Convert.ToString(dgvDevis.CurrentRow.Cells[12].Value.ToString());
                string v_note = Convert.ToString(dgvDevis.CurrentRow.Cells[13].Value.ToString());

                Devis dv = new Devis(v_code, v_cl_code, v_date, v_statut, v_adresse, v_ville, v_cp, v_pays, v_fixe, v_mobile, v_fax, v_email, v_sitew, v_note);

                ModifierDevis md = new ModifierDevis(this, dv,ac);
                md.Show();
                ac.Enabled = false;
            }
        }

        private void supprimer()
        {
            if (dgvDevis.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce devis?", "Suppression!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int v_code = Convert.ToInt16(dgvDevis.CurrentRow.Cells[0].Value.ToString());

                    Devis dv = new Devis(v_code);
                    dv.dv_supprimer();
                    this.devisTableAdapter.Fill(this.gestioncommercialeDataSet1.devis);

                    MessageBox.Show("Devis supprimé!", "Suppression", MessageBoxButtons.OK);
                }
            }
        }

        private void afficherrecherche()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                dgvDevis.Location = new Point(87, 12);
                dgvDevis.Size = new Size(759, 374);
                radioButton1.Checked = true;
                textBox1.Text = "";
                textBox1.Visible = true;
                comboBox1.Text = "Actif";
                comboBox1.Visible = false;
                dateTimePicker1.Value = System.DateTime.Today;
                dateTimePicker1.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                dgvDevis.Location = new Point(87, 88);
                dgvDevis.Size = new Size(759, 298);
                textBox1.Focus();
            }
        }

        private void effectuerrecherche()
        {
                if (radioButton2.Checked && textBox1.Text != "")
                {
                    devisBindingSource.Filter = "dv_code =" + Convert.ToInt32(textBox1.Text);
                }
                else if (radioButton3.Checked && textBox1.Text != "")
                {
                    devisBindingSource.Filter = "Client_codeClient=" + Convert.ToInt32(textBox1.Text);
                }
                else if (radioButton7.Checked)
                {
                    devisBindingSource.Filter = "dv_date = '" + dateTimePicker1.Value.ToString("dd /MM / yyyy") + "'";
                }
                else if (radioButton5.Checked && textBox1.Text != "")
                {
                    devisBindingSource.Filter = "dv_pays like '" + textBox1.Text + "%'";
                }
                else if (radioButton6.Checked && textBox1.Text != "")
                {
                    devisBindingSource.Filter = "dv_ville like '" + textBox1.Text + "%'";
                }
                else if (radioButton1.Checked)
                {
                    devisBindingSource.Filter = "dv_statut like '" + comboBox1.Text + "%'";
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Actif";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Actif";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Actif";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Actif";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox1.Text = "Actif";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Focus();
        }


        private void Devis1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.devis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.devisTableAdapter.Fill(this.gestioncommercialeDataSet1.devis);
        }

        private void Devis1_KeyUp(object sender, KeyEventArgs e)
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

        private void Devis1_FormClosing(object sender, FormClosingEventArgs e)
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
            pictureBox5.Location = new Point(11, 238);
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = false;
            effectuerrecherche();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void dgvDevis_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void rechercherCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void ajouterDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void modifierDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void supprimerDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void imprimerDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void rechercherDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            b = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDevis.Rows.Count == 0)
                e.Cancel = true;
        }

        private void dgvDevis_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = dgvDevis.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            b = false;
        }



       



    }
}
