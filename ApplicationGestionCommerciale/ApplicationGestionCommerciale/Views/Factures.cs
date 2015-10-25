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
    public partial class Factures : Form
    {
        Boolean b = true;
        Accueil ac;

        public Factures(Accueil ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        public Factures()
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
            int fa_code=1;
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select max(numero_Facture) from facture";
                    connection.Open();
                    fa_code = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    connection.Close();
                }
                Form a = new AjouterFacture(Convert.ToString(fa_code),this,ac);
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
                int numero_Facture = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                string date_Facture = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                double timbre_Facture = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
                double remise_Facture = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value);
                double montantHT_Facture = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                double montantTTC_Facture = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value);
                string statut_Facture = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                int Client_codeClient = Convert.ToInt16(dataGridView1.CurrentRow.Cells[7].Value);
                Facture f = new Facture(numero_Facture, date_Facture, timbre_Facture, remise_Facture, montantHT_Facture, montantTTC_Facture, statut_Facture, Client_codeClient);
                ModifierFacture m = new ModifierFacture(this, f,ac);
                m.Show();
                ac.Enabled = false;
            }
        }

        private void supprimer()
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette facture?", "Supprimer Facture", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int numero_Facture = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Facture F = new Facture(numero_Facture);
                    F.supprimerFacture();

                    this.factureTableAdapter.Fill(this.gestioncommercialeDataSet1.facture);
                }
            }
        }

        private void afficherrecherche()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                dataGridView1.Location = new Point(87, 12);
                dataGridView1.Size = new Size(759, 374);
                radioButton1.Checked = true;
                textBox1.Text = "";
                textBox1.Visible = true;
                comboBox1.Text = "Ouverte";
                comboBox1.Visible = false;
                dateTimePicker1.Value = System.DateTime.Today;
                dateTimePicker1.Visible = false;
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
            if (textBox1.Text != "" && radioButton1.Checked)
            {
                factureBindingSource.Filter = "numero_Facture =" + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                factureBindingSource.Filter = "date_Facture = '" + dateTimePicker1.Value.ToString("dd / MM / yyyy") + "'";
            }
            else if (radioButton3.Checked && textBox1.Text != "")
            {
                factureBindingSource.Filter = "Client_codeClient = " + Convert.ToInt32(textBox1.Text);
            }
            else if (radioButton4.Checked)
            {
                factureBindingSource.Filter = "statut_Facture like '" + comboBox1.Text + "%'";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Text = "Ouverte";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Text = "Ouverte";
            textBox1.Text = "";
            dateTimePicker1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Text = "Ouverte";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Focus();
        }

        private void Factures_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.facture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.factureTableAdapter.Fill(this.gestioncommercialeDataSet1.facture);    
      

        }

        private void Factures_KeyUp(object sender, KeyEventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void Factures_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = false;
            effectuerrecherche();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            effectuerrecherche();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                b = false;
                e.Handled = true;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifier();
        }

        private void ajouterFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void modifierFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void suprimerFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void imprimerFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer();
        }

        private void rechercherFactureToolStripMenuItem_Click(object sender, EventArgs e)
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
