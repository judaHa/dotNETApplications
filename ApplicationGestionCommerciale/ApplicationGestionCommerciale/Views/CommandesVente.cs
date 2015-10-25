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
    public partial class CommandesVente : Form
    {
        Boolean a = true;
        Boolean b = true;
        Accueil ac;

        public CommandesVente(Accueil ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        public CommandesVente()
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
            int cmv_code = 1;
            try
            {
                if (dgvCommVente.Rows.Count != 0)
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(cmv_code) from commandevente";
                    connection.Open();
                    cmv_code = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }
                Form acv = new AjouterCommandeVente(Convert.ToString(cmv_code),this);
                acv.Show();
                ac.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void modifier()
        {
            if (dgvCommVente.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int v_code = Convert.ToInt16(dgvCommVente.CurrentRow.Cells[0].Value.ToString());
                int v_cl_code = Convert.ToInt16(dgvCommVente.CurrentRow.Cells[1].Value.ToString());
                string v_statut = Convert.ToString(dgvCommVente.CurrentRow.Cells[2].Value.ToString());
                String v_date = Convert.ToString(dgvCommVente.CurrentRow.Cells[3].Value.ToString());
                String v_date_liv = Convert.ToString(dgvCommVente.CurrentRow.Cells[4].Value.ToString());
                string v_adresse = Convert.ToString(dgvCommVente.CurrentRow.Cells[5].Value.ToString());
                string v_ville = Convert.ToString(dgvCommVente.CurrentRow.Cells[6].Value.ToString());
                int v_cp = Convert.ToInt32(dgvCommVente.CurrentRow.Cells[7].Value.ToString());
                string v_pays = Convert.ToString(dgvCommVente.CurrentRow.Cells[8].Value.ToString());
                int v_fixe = Convert.ToInt32(dgvCommVente.CurrentRow.Cells[9].Value.ToString());
                int v_mobile = Convert.ToInt32(dgvCommVente.CurrentRow.Cells[10].Value.ToString());
                int v_fax = Convert.ToInt32(dgvCommVente.CurrentRow.Cells[11].Value.ToString());
                string v_email = Convert.ToString(dgvCommVente.CurrentRow.Cells[12].Value.ToString());
                string v_sitew = Convert.ToString(dgvCommVente.CurrentRow.Cells[13].Value.ToString());
                string v_note = Convert.ToString(dgvCommVente.CurrentRow.Cells[14].Value.ToString());
                double v_frais = Convert.ToDouble(dgvCommVente.CurrentRow.Cells[15].Value.ToString());

                CommandeVente cmv = new CommandeVente(v_code, v_cl_code, v_statut, v_date, v_date_liv, v_adresse, v_ville, v_cp, v_pays, v_fixe, v_mobile, v_fax, v_email, v_sitew, v_note, v_frais);
                ModifierCommandeVente mcv = new ModifierCommandeVente(this, cmv,ac);
                mcv.Show();
                ac.Enabled = false;
            }
        }

        public void supprimer()
        {
            if (dgvCommVente.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette commande?", "Suppression!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int v_code = Convert.ToInt32(dgvCommVente.CurrentRow.Cells[0].Value.ToString());

                    CommandeVente cmv = new CommandeVente(v_code);
                    cmv.cmv_supprimer();
                    this.commandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.commandevente);
                    MessageBox.Show("Commande supprimée!", "Suppression", MessageBoxButtons.OK);
                }
            }
        }

        public void afficherrecherche()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                dgvCommVente.Location = new Point(87, 12);
                dgvCommVente.Size = new Size(759, 374);
                radioButton1.Checked = true;
                textBox1.Text = "";
                textBox1.Visible = true;
                comboBox1.Text = "";
                comboBox1.Visible = false;
                dateTimePicker1.Value = System.DateTime.Today;
                dateTimePicker1.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                dgvCommVente.Location = new Point(87, 88);
                dgvCommVente.Size = new Size(759, 298);
                textBox1.Focus();
            }
        }
        private void effectuerrecherche()
        {
            if (radioButton1.Checked && textBox1.Text!="")
            {
                    commandeventeBindingSource.Filter = "cmv_code =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                commandeventeBindingSource.Filter = "cmv_date = '" + dateTimePicker1.Value.ToString("dd / MM / yyyy") + "'";
            }
            else if (radioButton4.Checked && textBox1.Text != "")
            {
                    commandeventeBindingSource.Filter = "cl_code =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                commandeventeBindingSource.Filter = "cmv_statut ='" + comboBox1.Text + "%'";
            }
            else if (radioButton5.Checked && textBox1.Text != "")
            {
                commandeventeBindingSource.Filter = "cmv_pays ='" + textBox1.Text + "%'";
            }
            else if (radioButton6.Checked && textBox1.Text != "")
            {
                commandeventeBindingSource.Filter = "cmv_ville ='" + textBox1.Text + "%'";
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
            dateTimePicker1.Focus();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            a = true;
            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a= true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Text = "Active";
            comboBox1.Visible = false;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void CommandesVente_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.commandevente'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeventeTableAdapter.Fill(this.gestioncommercialeDataSet1.commandevente);
        }


        private void CommandesVente_KeyUp(object sender, KeyEventArgs e)
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

        private void CommandesVente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvCommVente_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvCommVente_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = dgvCommVente.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvCommVente.Rows.Count == 0)
                e.Cancel = true;
        }
     

    }

}

