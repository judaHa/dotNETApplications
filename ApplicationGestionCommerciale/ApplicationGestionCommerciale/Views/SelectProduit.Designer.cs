namespace ApplicationGestionCommerciale
{
    partial class SelectProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricantproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reffabricantproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleidFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieidCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitcritiqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockminproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockmaxproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksecuriteproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockdisponibleproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delaiapprovproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magasinproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplacementproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeconservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixmoyenproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventeproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVAproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.produitTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.produitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproduitDataGridViewTextBoxColumn,
            this.libelleproduitDataGridViewTextBoxColumn,
            this.designationproduitDataGridViewTextBoxColumn,
            this.uniteproduitDataGridViewTextBoxColumn,
            this.fabricantproduitDataGridViewTextBoxColumn,
            this.reffabricantproduitDataGridViewTextBoxColumn,
            this.poidsproduitDataGridViewTextBoxColumn,
            this.volumeproduitDataGridViewTextBoxColumn,
            this.familleidFamilleDataGridViewTextBoxColumn,
            this.categorieidCategorieDataGridViewTextBoxColumn,
            this.produitcritiqueDataGridViewTextBoxColumn,
            this.stockminproduitDataGridViewTextBoxColumn,
            this.stockmaxproduitDataGridViewTextBoxColumn,
            this.stocksecuriteproduitDataGridViewTextBoxColumn,
            this.stockdisponibleproduitDataGridViewTextBoxColumn,
            this.delaiapprovproduitDataGridViewTextBoxColumn,
            this.magasinproduitDataGridViewTextBoxColumn,
            this.emplacementproduitDataGridViewTextBoxColumn,
            this.dureeconservationDataGridViewTextBoxColumn,
            this.prixmoyenproduitDataGridViewTextBoxColumn,
            this.prixventeproduitDataGridViewTextBoxColumn,
            this.tVAproduitDataGridViewTextBoxColumn,
            this.remiseproduitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 317);
            this.dataGridView1.TabIndex = 205;
            // 
            // codeproduitDataGridViewTextBoxColumn
            // 
            this.codeproduitDataGridViewTextBoxColumn.DataPropertyName = "code_produit";
            this.codeproduitDataGridViewTextBoxColumn.HeaderText = "code_produit";
            this.codeproduitDataGridViewTextBoxColumn.Name = "codeproduitDataGridViewTextBoxColumn";
            this.codeproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleproduitDataGridViewTextBoxColumn
            // 
            this.libelleproduitDataGridViewTextBoxColumn.DataPropertyName = "libelle_produit";
            this.libelleproduitDataGridViewTextBoxColumn.HeaderText = "libelle_produit";
            this.libelleproduitDataGridViewTextBoxColumn.Name = "libelleproduitDataGridViewTextBoxColumn";
            this.libelleproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationproduitDataGridViewTextBoxColumn
            // 
            this.designationproduitDataGridViewTextBoxColumn.DataPropertyName = "designation_produit";
            this.designationproduitDataGridViewTextBoxColumn.HeaderText = "designation_produit";
            this.designationproduitDataGridViewTextBoxColumn.Name = "designationproduitDataGridViewTextBoxColumn";
            this.designationproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniteproduitDataGridViewTextBoxColumn
            // 
            this.uniteproduitDataGridViewTextBoxColumn.DataPropertyName = "unite_produit";
            this.uniteproduitDataGridViewTextBoxColumn.HeaderText = "unite_produit";
            this.uniteproduitDataGridViewTextBoxColumn.Name = "uniteproduitDataGridViewTextBoxColumn";
            this.uniteproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabricantproduitDataGridViewTextBoxColumn
            // 
            this.fabricantproduitDataGridViewTextBoxColumn.DataPropertyName = "fabricant_produit";
            this.fabricantproduitDataGridViewTextBoxColumn.HeaderText = "fabricant_produit";
            this.fabricantproduitDataGridViewTextBoxColumn.Name = "fabricantproduitDataGridViewTextBoxColumn";
            this.fabricantproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reffabricantproduitDataGridViewTextBoxColumn
            // 
            this.reffabricantproduitDataGridViewTextBoxColumn.DataPropertyName = "ref_fabricant_produit";
            this.reffabricantproduitDataGridViewTextBoxColumn.HeaderText = "ref_fabricant_produit";
            this.reffabricantproduitDataGridViewTextBoxColumn.Name = "reffabricantproduitDataGridViewTextBoxColumn";
            this.reffabricantproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poidsproduitDataGridViewTextBoxColumn
            // 
            this.poidsproduitDataGridViewTextBoxColumn.DataPropertyName = "poids_produit";
            this.poidsproduitDataGridViewTextBoxColumn.HeaderText = "poids_produit";
            this.poidsproduitDataGridViewTextBoxColumn.Name = "poidsproduitDataGridViewTextBoxColumn";
            this.poidsproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeproduitDataGridViewTextBoxColumn
            // 
            this.volumeproduitDataGridViewTextBoxColumn.DataPropertyName = "volume_produit";
            this.volumeproduitDataGridViewTextBoxColumn.HeaderText = "volume_produit";
            this.volumeproduitDataGridViewTextBoxColumn.Name = "volumeproduitDataGridViewTextBoxColumn";
            this.volumeproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familleidFamilleDataGridViewTextBoxColumn
            // 
            this.familleidFamilleDataGridViewTextBoxColumn.DataPropertyName = "Famille_idFamille";
            this.familleidFamilleDataGridViewTextBoxColumn.HeaderText = "Famille_idFamille";
            this.familleidFamilleDataGridViewTextBoxColumn.Name = "familleidFamilleDataGridViewTextBoxColumn";
            this.familleidFamilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieidCategorieDataGridViewTextBoxColumn
            // 
            this.categorieidCategorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie_idCategorie";
            this.categorieidCategorieDataGridViewTextBoxColumn.HeaderText = "Categorie_idCategorie";
            this.categorieidCategorieDataGridViewTextBoxColumn.Name = "categorieidCategorieDataGridViewTextBoxColumn";
            this.categorieidCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitcritiqueDataGridViewTextBoxColumn
            // 
            this.produitcritiqueDataGridViewTextBoxColumn.DataPropertyName = "produit_critique";
            this.produitcritiqueDataGridViewTextBoxColumn.HeaderText = "produit_critique";
            this.produitcritiqueDataGridViewTextBoxColumn.Name = "produitcritiqueDataGridViewTextBoxColumn";
            this.produitcritiqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockminproduitDataGridViewTextBoxColumn
            // 
            this.stockminproduitDataGridViewTextBoxColumn.DataPropertyName = "stock_min_produit";
            this.stockminproduitDataGridViewTextBoxColumn.HeaderText = "stock_min_produit";
            this.stockminproduitDataGridViewTextBoxColumn.Name = "stockminproduitDataGridViewTextBoxColumn";
            this.stockminproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockmaxproduitDataGridViewTextBoxColumn
            // 
            this.stockmaxproduitDataGridViewTextBoxColumn.DataPropertyName = "stock_max_produit";
            this.stockmaxproduitDataGridViewTextBoxColumn.HeaderText = "stock_max_produit";
            this.stockmaxproduitDataGridViewTextBoxColumn.Name = "stockmaxproduitDataGridViewTextBoxColumn";
            this.stockmaxproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocksecuriteproduitDataGridViewTextBoxColumn
            // 
            this.stocksecuriteproduitDataGridViewTextBoxColumn.DataPropertyName = "stock_securite_produit";
            this.stocksecuriteproduitDataGridViewTextBoxColumn.HeaderText = "stock_securite_produit";
            this.stocksecuriteproduitDataGridViewTextBoxColumn.Name = "stocksecuriteproduitDataGridViewTextBoxColumn";
            this.stocksecuriteproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockdisponibleproduitDataGridViewTextBoxColumn
            // 
            this.stockdisponibleproduitDataGridViewTextBoxColumn.DataPropertyName = "stock_disponible_produit";
            this.stockdisponibleproduitDataGridViewTextBoxColumn.HeaderText = "stock_disponible_produit";
            this.stockdisponibleproduitDataGridViewTextBoxColumn.Name = "stockdisponibleproduitDataGridViewTextBoxColumn";
            this.stockdisponibleproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delaiapprovproduitDataGridViewTextBoxColumn
            // 
            this.delaiapprovproduitDataGridViewTextBoxColumn.DataPropertyName = "delai_approv_produit";
            this.delaiapprovproduitDataGridViewTextBoxColumn.HeaderText = "delai_approv_produit";
            this.delaiapprovproduitDataGridViewTextBoxColumn.Name = "delaiapprovproduitDataGridViewTextBoxColumn";
            this.delaiapprovproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magasinproduitDataGridViewTextBoxColumn
            // 
            this.magasinproduitDataGridViewTextBoxColumn.DataPropertyName = "magasin_produit";
            this.magasinproduitDataGridViewTextBoxColumn.HeaderText = "magasin_produit";
            this.magasinproduitDataGridViewTextBoxColumn.Name = "magasinproduitDataGridViewTextBoxColumn";
            this.magasinproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emplacementproduitDataGridViewTextBoxColumn
            // 
            this.emplacementproduitDataGridViewTextBoxColumn.DataPropertyName = "emplacement_produit";
            this.emplacementproduitDataGridViewTextBoxColumn.HeaderText = "emplacement_produit";
            this.emplacementproduitDataGridViewTextBoxColumn.Name = "emplacementproduitDataGridViewTextBoxColumn";
            this.emplacementproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dureeconservationDataGridViewTextBoxColumn
            // 
            this.dureeconservationDataGridViewTextBoxColumn.DataPropertyName = "duree_conservation";
            this.dureeconservationDataGridViewTextBoxColumn.HeaderText = "duree_conservation";
            this.dureeconservationDataGridViewTextBoxColumn.Name = "dureeconservationDataGridViewTextBoxColumn";
            this.dureeconservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixmoyenproduitDataGridViewTextBoxColumn
            // 
            this.prixmoyenproduitDataGridViewTextBoxColumn.DataPropertyName = "prix_moyen_produit";
            this.prixmoyenproduitDataGridViewTextBoxColumn.HeaderText = "prix_moyen_produit";
            this.prixmoyenproduitDataGridViewTextBoxColumn.Name = "prixmoyenproduitDataGridViewTextBoxColumn";
            this.prixmoyenproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixventeproduitDataGridViewTextBoxColumn
            // 
            this.prixventeproduitDataGridViewTextBoxColumn.DataPropertyName = "prix_vente_produit";
            this.prixventeproduitDataGridViewTextBoxColumn.HeaderText = "prix_vente_produit";
            this.prixventeproduitDataGridViewTextBoxColumn.Name = "prixventeproduitDataGridViewTextBoxColumn";
            this.prixventeproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tVAproduitDataGridViewTextBoxColumn
            // 
            this.tVAproduitDataGridViewTextBoxColumn.DataPropertyName = "TVA_produit";
            this.tVAproduitDataGridViewTextBoxColumn.HeaderText = "TVA_produit";
            this.tVAproduitDataGridViewTextBoxColumn.Name = "tVAproduitDataGridViewTextBoxColumn";
            this.tVAproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseproduitDataGridViewTextBoxColumn
            // 
            this.remiseproduitDataGridViewTextBoxColumn.DataPropertyName = "remise_produit";
            this.remiseproduitDataGridViewTextBoxColumn.HeaderText = "remise_produit";
            this.remiseproduitDataGridViewTextBoxColumn.Name = "remiseproduitDataGridViewTextBoxColumn";
            this.remiseproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "produit";
            this.produitBindingSource.DataSource = this.gestioncommercialeDataSet1;
            // 
            // gestioncommercialeDataSet1
            // 
            this.gestioncommercialeDataSet1.DataSetName = "gestioncommercialeDataSet1";
            this.gestioncommercialeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ApplicationGestionCommerciale.Properties.Resources.Action_ok_icon;
            this.pictureBox4.Location = new System.Drawing.Point(161, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 204;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationGestionCommerciale.Properties.Resources.Actions_list_add_icon;
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 201;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApplicationGestionCommerciale.Properties.Resources.edit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(68, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 202;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApplicationGestionCommerciale.Properties.Resources.Actions_edit_delete_icon;
            this.pictureBox3.Location = new System.Drawing.Point(115, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 203;
            this.pictureBox3.TabStop = false;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // SelectProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélectionner Produit";
            this.Load += new System.EventHandler(this.SelectProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private gestioncommercialeDataSet1TableAdapters.produitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricantproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reffabricantproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleidFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieidCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitcritiqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockminproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockmaxproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocksecuriteproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockdisponibleproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delaiapprovproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magasinproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplacementproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeconservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixmoyenproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventeproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVAproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseproduitDataGridViewTextBoxColumn;
    }
}