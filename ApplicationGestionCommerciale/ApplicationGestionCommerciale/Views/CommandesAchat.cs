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
    public partial class CommandesAchat : Form
    {
        Boolean a = true;
        Boolean b = true;
        Accueil ac;

        public CommandesAchat(Accueil ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        public CommandesAchat()
        {
            
        }

        //**************************************************************************************************************************************************
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

        public void ajouter()
        {
            int cma_code = 1;
            try
            {
                if (dgvCommAchat.Rows.Count != 0)
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(cma_code) from commandeachat";
                    connection.Open();
                    cma_code = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }
                Form aca = new AjouterCommandeAchat(Convert.ToString(cma_code),this,ac);
                aca.Show();
                ac.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void modifier()
        {
            if (dgvCommAchat.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int v_code = Convert.ToInt16(dgvCommAchat.CurrentRow.Cells[0].Value.ToString());
                int v_fr_code = Convert.ToInt16(dgvCommAchat.CurrentRow.Cells[1].Value.ToString());
                string v_statut = Convert.ToString(dgvCommAchat.CurrentRow.Cells[2].Value.ToString());
                string v_date = Convert.ToString(dgvCommAchat.CurrentRow.Cells[3].Value.ToString());
                string v_date_liv = Convert.ToString(dgvCommAchat.CurrentRow.Cells[4].Value.ToString());
                string v_adresse = Convert.ToString(dgvCommAchat.CurrentRow.Cells[5].Value.ToString());
                string v_ville = Convert.ToString(dgvCommAchat.CurrentRow.Cells[6].Value.ToString());
                int v_cp = Convert.ToInt32(dgvCommAchat.CurrentRow.Cells[7].Value.ToString());
                string v_pays = Convert.ToString(dgvCommAchat.CurrentRow.Cells[8].Value.ToString());
                int v_fixe = Convert.ToInt32(dgvCommAchat.CurrentRow.Cells[9].Value.ToString());
                int v_mobile = Convert.ToInt32(dgvCommAchat.CurrentRow.Cells[10].Value.ToString());
                int v_fax = Convert.ToInt32(dgvCommAchat.CurrentRow.Cells[11].Value.ToString());
                string v_email = Convert.ToString(dgvCommAchat.CurrentRow.Cells[12].Value.ToString());
                string v_sitew = Convert.ToString(dgvCommAchat.CurrentRow.Cells[13].Value.ToString());
                string v_note = Convert.ToString(dgvCommAchat.CurrentRow.Cells[14].Value.ToString());

                CommandeAchat cma = new CommandeAchat(v_code, v_fr_code, v_statut, v_date, v_date_liv, v_adresse, v_ville, v_cp, v_pays, v_fixe, v_mobile, v_fax, v_email, v_sitew, v_note);
                ModifierCommandeAchat mca = new ModifierCommandeAchat(this, cma,ac);
                mca.Show();
                ac.Enabled = false;
            }
        }

        public void supprimer()
        {
            if (dgvCommAchat.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette commande?", "Suppression!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int v_code = Convert.ToInt16(dgvCommAchat.CurrentRow.Cells[0].Value.ToString());

                    CommandeAchat cma = new CommandeAchat(v_code);
                    cma.cma_supprimer();
                    this.commandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.commandeachat);
                    MessageBox.Show("Commande supprimée!", "Suppression", MessageBoxButtons.OK);
                }
            }
        }

        private void afficherrecherche()
        {
            if (panel2.Visible == true)
            {           
                panel2.Visible = false;
                dgvCommAchat.Location = new Point(87, 12);
                dgvCommAchat.Size = new Size(759, 374);
                radioButton1.Checked = true;
                textBox1.Text = "";
                textBox1.Visible = true;
                comboBox1.Text = "";
                comboBox1.Visible = false;
                dateTimePicker1.Value = System.DateTime.Today;
                dateTimePicker1.Visible = false;
                a = true;
            }
            else
            {
                panel2.Visible = true;
                dgvCommAchat.Location = new Point(87, 88);
                dgvCommAchat.Size = new Size(759, 298);
                textBox1.Focus();
            }
        }

        private void effectuerrecherche()
        {
            if (radioButton1.Checked && textBox1.Text != "")
            {
                commandeachatBindingSource.Filter = "cma_code =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                commandeachatBindingSource.Filter = "cma_date = '" + dateTimePicker1.Value.ToString("dd / MM / yyyy") + "'";
            }
            else if (radioButton4.Checked && textBox1.Text!="")
            {
                commandeachatBindingSource.Filter = "fr_code =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                commandeachatBindingSource.Filter = "cma_statut ='" + comboBox1.Text + "%'";
            }
            else if (radioButton5.Checked && textBox1.Text != "")
            {
                commandeachatBindingSource.Filter = "cma_pays ='" + textBox1.Text + "%'";
            }
            else if (radioButton6.Checked && textBox1.Text != "")
            {
                commandeachatBindingSource.Filter = "cma_ville ='" + textBox1.Text + "%'";
            }

        }

        private void imprimer()
        {

        }

        //*********************************************************************************************************************************************

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            dateTimePicker1.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            textBox1.Text = "";
        }

        private void CommandesAchat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.commandeachat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeachatTableAdapter.Fill(this.gestioncommercialeDataSet1.commandeachat);
        }

        private void CommandesAchat_KeyUp(object sender, KeyEventArgs e)
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

        private void CommandesAchat_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
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

        private void dgvCommAchat_DoubleClick(object sender, EventArgs e)
        {
            modifier();
        }

        private void ajouterCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void modifierCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void supprimerCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void imprimerCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void rechercherCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherrecherche();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            b = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvCommAchat.Rows.Count == 0)
                e.Cancel = true;
        }

        private void dgvCommAchat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = dgvCommAchat.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }

        
       
      

    }

}

