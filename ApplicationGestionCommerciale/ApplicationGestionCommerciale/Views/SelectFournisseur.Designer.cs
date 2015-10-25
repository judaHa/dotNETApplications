namespace ApplicationGestionCommerciale
{
    partial class SelectFournisseur
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
            this.idFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villefournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telmobileFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteInternetFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.fournisseurTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.fournisseurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
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
            this.idFournisseurDataGridViewTextBoxColumn,
            this.refFournisseurDataGridViewTextBoxColumn,
            this.nomFournisseurDataGridViewTextBoxColumn,
            this.prenomFournisseurDataGridViewTextBoxColumn,
            this.adresseFournisseurDataGridViewTextBoxColumn,
            this.codePostalFournisseurDataGridViewTextBoxColumn,
            this.villefournisseurDataGridViewTextBoxColumn,
            this.paysFournisseurDataGridViewTextBoxColumn,
            this.telFournisseurDataGridViewTextBoxColumn,
            this.telmobileFournisseurDataGridViewTextBoxColumn,
            this.emailFournisseurDataGridViewTextBoxColumn,
            this.faxFournisseurDataGridViewTextBoxColumn,
            this.siteInternetFournisseurDataGridViewTextBoxColumn,
            this.etatFournisseurDataGridViewTextBoxColumn,
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn,
            this.noteFournisseurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fournisseurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 317);
            this.dataGridView1.TabIndex = 210;
            // 
            // idFournisseurDataGridViewTextBoxColumn
            // 
            this.idFournisseurDataGridViewTextBoxColumn.DataPropertyName = "idFournisseur";
            this.idFournisseurDataGridViewTextBoxColumn.HeaderText = "idFournisseur";
            this.idFournisseurDataGridViewTextBoxColumn.Name = "idFournisseurDataGridViewTextBoxColumn";
            this.idFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refFournisseurDataGridViewTextBoxColumn
            // 
            this.refFournisseurDataGridViewTextBoxColumn.DataPropertyName = "ref_Fournisseur";
            this.refFournisseurDataGridViewTextBoxColumn.HeaderText = "ref_Fournisseur";
            this.refFournisseurDataGridViewTextBoxColumn.Name = "refFournisseurDataGridViewTextBoxColumn";
            this.refFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomFournisseurDataGridViewTextBoxColumn
            // 
            this.nomFournisseurDataGridViewTextBoxColumn.DataPropertyName = "nom_Fournisseur";
            this.nomFournisseurDataGridViewTextBoxColumn.HeaderText = "nom_Fournisseur";
            this.nomFournisseurDataGridViewTextBoxColumn.Name = "nomFournisseurDataGridViewTextBoxColumn";
            this.nomFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomFournisseurDataGridViewTextBoxColumn
            // 
            this.prenomFournisseurDataGridViewTextBoxColumn.DataPropertyName = "prenom_Fournisseur";
            this.prenomFournisseurDataGridViewTextBoxColumn.HeaderText = "prenom_Fournisseur";
            this.prenomFournisseurDataGridViewTextBoxColumn.Name = "prenomFournisseurDataGridViewTextBoxColumn";
            this.prenomFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseFournisseurDataGridViewTextBoxColumn
            // 
            this.adresseFournisseurDataGridViewTextBoxColumn.DataPropertyName = "adresse_Fournisseur";
            this.adresseFournisseurDataGridViewTextBoxColumn.HeaderText = "adresse_Fournisseur";
            this.adresseFournisseurDataGridViewTextBoxColumn.Name = "adresseFournisseurDataGridViewTextBoxColumn";
            this.adresseFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalFournisseurDataGridViewTextBoxColumn
            // 
            this.codePostalFournisseurDataGridViewTextBoxColumn.DataPropertyName = "codePostal_Fournisseur";
            this.codePostalFournisseurDataGridViewTextBoxColumn.HeaderText = "codePostal_Fournisseur";
            this.codePostalFournisseurDataGridViewTextBoxColumn.Name = "codePostalFournisseurDataGridViewTextBoxColumn";
            this.codePostalFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villefournisseurDataGridViewTextBoxColumn
            // 
            this.villefournisseurDataGridViewTextBoxColumn.DataPropertyName = "ville_fournisseur";
            this.villefournisseurDataGridViewTextBoxColumn.HeaderText = "ville_fournisseur";
            this.villefournisseurDataGridViewTextBoxColumn.Name = "villefournisseurDataGridViewTextBoxColumn";
            this.villefournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paysFournisseurDataGridViewTextBoxColumn
            // 
            this.paysFournisseurDataGridViewTextBoxColumn.DataPropertyName = "pays_Fournisseur";
            this.paysFournisseurDataGridViewTextBoxColumn.HeaderText = "pays_Fournisseur";
            this.paysFournisseurDataGridViewTextBoxColumn.Name = "paysFournisseurDataGridViewTextBoxColumn";
            this.paysFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telFournisseurDataGridViewTextBoxColumn
            // 
            this.telFournisseurDataGridViewTextBoxColumn.DataPropertyName = "tel_Fournisseur";
            this.telFournisseurDataGridViewTextBoxColumn.HeaderText = "tel_Fournisseur";
            this.telFournisseurDataGridViewTextBoxColumn.Name = "telFournisseurDataGridViewTextBoxColumn";
            this.telFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telmobileFournisseurDataGridViewTextBoxColumn
            // 
            this.telmobileFournisseurDataGridViewTextBoxColumn.DataPropertyName = "telmobile_Fournisseur";
            this.telmobileFournisseurDataGridViewTextBoxColumn.HeaderText = "telmobile_Fournisseur";
            this.telmobileFournisseurDataGridViewTextBoxColumn.Name = "telmobileFournisseurDataGridViewTextBoxColumn";
            this.telmobileFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailFournisseurDataGridViewTextBoxColumn
            // 
            this.emailFournisseurDataGridViewTextBoxColumn.DataPropertyName = "email_Fournisseur";
            this.emailFournisseurDataGridViewTextBoxColumn.HeaderText = "email_Fournisseur";
            this.emailFournisseurDataGridViewTextBoxColumn.Name = "emailFournisseurDataGridViewTextBoxColumn";
            this.emailFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxFournisseurDataGridViewTextBoxColumn
            // 
            this.faxFournisseurDataGridViewTextBoxColumn.DataPropertyName = "fax_Fournisseur";
            this.faxFournisseurDataGridViewTextBoxColumn.HeaderText = "fax_Fournisseur";
            this.faxFournisseurDataGridViewTextBoxColumn.Name = "faxFournisseurDataGridViewTextBoxColumn";
            this.faxFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteInternetFournisseurDataGridViewTextBoxColumn
            // 
            this.siteInternetFournisseurDataGridViewTextBoxColumn.DataPropertyName = "siteInternet_Fournisseur";
            this.siteInternetFournisseurDataGridViewTextBoxColumn.HeaderText = "siteInternet_Fournisseur";
            this.siteInternetFournisseurDataGridViewTextBoxColumn.Name = "siteInternetFournisseurDataGridViewTextBoxColumn";
            this.siteInternetFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatFournisseurDataGridViewTextBoxColumn
            // 
            this.etatFournisseurDataGridViewTextBoxColumn.DataPropertyName = "etat_Fournisseur";
            this.etatFournisseurDataGridViewTextBoxColumn.HeaderText = "etat_Fournisseur";
            this.etatFournisseurDataGridViewTextBoxColumn.Name = "etatFournisseurDataGridViewTextBoxColumn";
            this.etatFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbtransactionsFournisseurDataGridViewTextBoxColumn
            // 
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn.DataPropertyName = "nb_transactions_Fournisseur";
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn.HeaderText = "nb_transactions_Fournisseur";
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn.Name = "nbtransactionsFournisseurDataGridViewTextBoxColumn";
            this.nbtransactionsFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteFournisseurDataGridViewTextBoxColumn
            // 
            this.noteFournisseurDataGridViewTextBoxColumn.DataPropertyName = "note_Fournisseur";
            this.noteFournisseurDataGridViewTextBoxColumn.HeaderText = "note_Fournisseur";
            this.noteFournisseurDataGridViewTextBoxColumn.Name = "noteFournisseurDataGridViewTextBoxColumn";
            this.noteFournisseurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "fournisseur";
            this.fournisseurBindingSource.DataSource = this.gestioncommercialeDataSet1;
            // 
            // gestioncommercialeDataSet1
            // 
            this.gestioncommercialeDataSet1.DataSetName = "gestioncommercialeDataSet1";
            this.gestioncommercialeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ApplicationGestionCommerciale.Properties.Resources.Action_ok_icon;
            this.pictureBox4.Location = new System.Drawing.Point(161, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 209;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationGestionCommerciale.Properties.Resources.Actions_list_add_icon;
            this.pictureBox1.Location = new System.Drawing.Point(22, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 206;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApplicationGestionCommerciale.Properties.Resources.edit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(68, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 207;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApplicationGestionCommerciale.Properties.Resources.Actions_edit_delete_icon;
            this.pictureBox3.Location = new System.Drawing.Point(115, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 208;
            this.pictureBox3.TabStop = false;
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // SelectFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectFournisseur";
            this.Text = "Sélectionner Fournisseur";
            this.Load += new System.EventHandler(this.SelectFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private gestioncommercialeDataSet1TableAdapters.fournisseurTableAdapter fournisseurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villefournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telmobileFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteInternetFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtransactionsFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteFournisseurDataGridViewTextBoxColumn;
    }
}