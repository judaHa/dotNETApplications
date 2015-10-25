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
    public partial class Parametres : Form
    {
        public Parametres()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();

            t.ShowAlways = true;
            t.SetToolTip(pictureBox4, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox7, "Supprimer");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox8, "Ajouter");

            t.ShowAlways = true;
            t.SetToolTip(pictureBox10, "Supprimer");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Categorie F = new Categorie(textBox1.Text);
                F.ajouterCategorie();
                this.categorieTableAdapter.Fill(this.gestioncommercialeDataSet1.categorie);
                textBox1.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Famille F = new Famille(textBox2.Text);
                F.ajouterFamille();
                this.familleTableAdapter.Fill(this.gestioncommercialeDataSet1.famille);
                textBox2.Text = "";
            }
        }

        private void Parametres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.gestioncommercialeDataSet1.categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet1.famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.familleTableAdapter.Fill(this.gestioncommercialeDataSet1.famille);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
            pictureBox3.Visible = true;
            textBox2.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            pictureBox3.Visible = false;
            
            
          
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            pictureBox6.Visible = true;
            textBox1.Focus();
        }

     
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette famille du produit?", "Supprimer Famille", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string id_famille = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    Famille C = new Famille(id_famille);
                    C.supprimerFamille();
                    this.familleTableAdapter.Fill(this.gestioncommercialeDataSet1.famille);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Liste vide!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette catégorie?", "Supprimer Catégorie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string id_categorie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Categorie C = new Categorie(id_categorie);
                    C.supprimerCategorie();
                    this.categorieTableAdapter.Fill(this.gestioncommercialeDataSet1.categorie);
                }
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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.Location = new Point(66, 30);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.Location = new Point(70, 32);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(54, 54);
            pictureBox7.Location = new Point(135, 26);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(46, 46);
            pictureBox7.Location = new Point(139, 28);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(48, 48);
            pictureBox8.Location = new Point(65, 28);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(40, 40);
            pictureBox8.Location = new Point(69, 30);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(54, 54);
            pictureBox10.Location = new Point(135, 27);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(46, 46);
            pictureBox10.Location = new Point(139, 29);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            textBox9.Focus();
        }

        private void Parametres_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Voulez-vous quitter sans enregistrer?", "Quitter", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Hide();
            }
        }

        



    }
}
