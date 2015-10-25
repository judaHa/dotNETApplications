namespace ApplicationGestionCommerciale
{
    partial class Clients
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
            this.codeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostalClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telFixeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telMobileClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.societeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbTransactionsClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.codeClientDataGridViewTextBoxColumn,
            this.refClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn,
            this.adresseClientDataGridViewTextBoxColumn,
            this.codepostalClientDataGridViewTextBoxColumn,
            this.villeClientDataGridViewTextBoxColumn,
            this.paysClientDataGridViewTextBoxColumn,
            this.telFixeClientDataGridViewTextBoxColumn,
            this.telMobileClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.siteClientDataGridViewTextBoxColumn,
            this.faxClientDataGridViewTextBoxColumn,
            this.societeClientDataGridViewTextBoxColumn,
            this.etatClientDataGridViewTextBoxColumn,
            this.nbTransactionsClientDataGridViewTextBoxColumn,
            this.notesClientDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 374);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // codeClientDataGridViewTextBoxColumn
            // 
            this.codeClientDataGridViewTextBoxColumn.DataPropertyName = "code_Client";
            this.codeClientDataGridViewTextBoxColumn.HeaderText = "code_Client";
            this.codeClientDataGridViewTextBoxColumn.Name = "codeClientDataGridViewTextBoxColumn";
            this.codeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refClientDataGridViewTextBoxColumn
            // 
            this.refClientDataGridViewTextBoxColumn.DataPropertyName = "ref_Client";
            this.refClientDataGridViewTextBoxColumn.HeaderText = "ref_Client";
            this.refClientDataGridViewTextBoxColumn.Name = "refClientDataGridViewTextBoxColumn";
            this.refClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "nom_Client";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "nom_Client";
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            this.nomClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            this.prenomClientDataGridViewTextBoxColumn.DataPropertyName = "prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.HeaderText = "prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            this.prenomClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseClientDataGridViewTextBoxColumn
            // 
            this.adresseClientDataGridViewTextBoxColumn.DataPropertyName = "adresse_Client";
            this.adresseClientDataGridViewTextBoxColumn.HeaderText = "adresse_Client";
            this.adresseClientDataGridViewTextBoxColumn.Name = "adresseClientDataGridViewTextBoxColumn";
            this.adresseClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codepostalClientDataGridViewTextBoxColumn
            // 
            this.codepostalClientDataGridViewTextBoxColumn.DataPropertyName = "codepostal_Client";
            this.codepostalClientDataGridViewTextBoxColumn.HeaderText = "codepostal_Client";
            this.codepostalClientDataGridViewTextBoxColumn.Name = "codepostalClientDataGridViewTextBoxColumn";
            this.codepostalClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeClientDataGridViewTextBoxColumn
            // 
            this.villeClientDataGridViewTextBoxColumn.DataPropertyName = "ville_Client";
            this.villeClientDataGridViewTextBoxColumn.HeaderText = "ville_Client";
            this.villeClientDataGridViewTextBoxColumn.Name = "villeClientDataGridViewTextBoxColumn";
            this.villeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paysClientDataGridViewTextBoxColumn
            // 
            this.paysClientDataGridViewTextBoxColumn.DataPropertyName = "pays_Client";
            this.paysClientDataGridViewTextBoxColumn.HeaderText = "pays_Client";
            this.paysClientDataGridViewTextBoxColumn.Name = "paysClientDataGridViewTextBoxColumn";
            this.paysClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telFixeClientDataGridViewTextBoxColumn
            // 
            this.telFixeClientDataGridViewTextBoxColumn.DataPropertyName = "telFixe_Client";
            this.telFixeClientDataGridViewTextBoxColumn.HeaderText = "telFixe_Client";
            this.telFixeClientDataGridViewTextBoxColumn.Name = "telFixeClientDataGridViewTextBoxColumn";
            this.telFixeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telMobileClientDataGridViewTextBoxColumn
            // 
            this.telMobileClientDataGridViewTextBoxColumn.DataPropertyName = "telMobile_Client";
            this.telMobileClientDataGridViewTextBoxColumn.HeaderText = "telMobile_Client";
            this.telMobileClientDataGridViewTextBoxColumn.Name = "telMobileClientDataGridViewTextBoxColumn";
            this.telMobileClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "email_Client";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "email_Client";
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            this.emailClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteClientDataGridViewTextBoxColumn
            // 
            this.siteClientDataGridViewTextBoxColumn.DataPropertyName = "site_Client";
            this.siteClientDataGridViewTextBoxColumn.HeaderText = "site_Client";
            this.siteClientDataGridViewTextBoxColumn.Name = "siteClientDataGridViewTextBoxColumn";
            this.siteClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxClientDataGridViewTextBoxColumn
            // 
            this.faxClientDataGridViewTextBoxColumn.DataPropertyName = "fax_Client";
            this.faxClientDataGridViewTextBoxColumn.HeaderText = "fax_Client";
            this.faxClientDataGridViewTextBoxColumn.Name = "faxClientDataGridViewTextBoxColumn";
            this.faxClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // societeClientDataGridViewTextBoxColumn
            // 
            this.societeClientDataGridViewTextBoxColumn.DataPropertyName = "societe_Client";
            this.societeClientDataGridViewTextBoxColumn.HeaderText = "societe_Client";
            this.societeClientDataGridViewTextBoxColumn.Name = "societeClientDataGridViewTextBoxColumn";
            this.societeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatClientDataGridViewTextBoxColumn
            // 
            this.etatClientDataGridViewTextBoxColumn.DataPropertyName = "etat_Client";
            this.etatClientDataGridViewTextBoxColumn.HeaderText = "etat_Client";
            this.etatClientDataGridViewTextBoxColumn.Name = "etatClientDataGridViewTextBoxColumn";
            this.etatClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbTransactionsClientDataGridViewTextBoxColumn
            // 
            this.nbTransactionsClientDataGridViewTextBoxColumn.DataPropertyName = "nbTransactions_Client";
            this.nbTransactionsClientDataGridViewTextBoxColumn.HeaderText = "nbTransactions_Client";
            this.nbTransactionsClientDataGridViewTextBoxColumn.Name = "nbTransactionsClientDataGridViewTextBoxColumn";
            this.nbTransactionsClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesClientDataGridViewTextBoxColumn
            // 
            this.notesClientDataGridViewTextBoxColumn.DataPropertyName = "notes_Client";
            this.notesClientDataGridViewTextBoxColumn.HeaderText = "notes_Client";
            this.notesClientDataGridViewTextBoxColumn.Name = "notesClientDataGridViewTextBoxColumn";
            this.notesClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.modifierClientToolStripMenuItem,
            this.supprimerClientToolStripMenuItem,
            this.imprimerClientToolStripMenuItem,
            this.rechercherClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter Client";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // modifierClientToolStripMenuItem
            // 
            this.modifierClientToolStripMenuItem.Name = "modifierClientToolStripMenuItem";
            this.modifierClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierClientToolStripMenuItem.Text = "Modifier Client";
            this.modifierClientToolStripMenuItem.Click += new System.EventHandler(this.modifierClientToolStripMenuItem_Click);
            // 
            // supprimerClientToolStripMenuItem
            // 
            this.supprimerClientToolStripMenuItem.Name = "supprimerClientToolStripMenuItem";
            this.supprimerClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.supprimerClientToolStripMenuItem.Text = "Supprimer Client";
            this.supprimerClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerClientToolStripMenuItem_Click);
            // 
            // imprimerClientToolStripMenuItem
            // 
            this.imprimerClientToolStripMenuItem.Name = "imprimerClientToolStripMenuItem";
            this.imprimerClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.imprimerClientToolStripMenuItem.Text = "Imprimer Client";
            this.imprimerClientToolStripMenuItem.Click += new System.EventHandler(this.imprimerClientToolStripMenuItem_Click);
            // 
            // rechercherClientToolStripMenuItem
            // 
            this.rechercherClientToolStripMenuItem.Name = "rechercherClientToolStripMenuItem";
            this.rechercherClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.rechercherClientToolStripMenuItem.Text = "Rechercher Client";
            this.rechercherClientToolStripMenuItem.Click += new System.EventHandler(this.rechercherClientToolStripMenuItem_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gestioncommercialeDataSet1;
            // 
            // gestioncommercialeDataSet1
            // 
            this.gestioncommercialeDataSet1.DataSetName = "gestioncommercialeDataSet1";
            this.gestioncommercialeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ApplicationGestionCommerciale.Properties.Resources.rechercher;
            this.pictureBox6.Location = new System.Drawing.Point(13, 316);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ApplicationGestionCommerciale.Properties.Resources.Imprimer;
            this.pictureBox5.Location = new System.Drawing.Point(13, 240);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ApplicationGestionCommerciale.Properties.Resources.Supprimer;
            this.pictureBox4.Location = new System.Drawing.Point(13, 164);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ApplicationGestionCommerciale.Properties.Resources.modifier;
            this.pictureBox3.Location = new System.Drawing.Point(13, 88);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ApplicationGestionCommerciale.Properties.Resources.ajouter;
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(87, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 69);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nouveau",
            "Fidele",
            "Occasionnel"});
            this.comboBox1.Location = new System.Drawing.Point(70, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 22);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Nouveau";
            this.comboBox1.Visible = false;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(210, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 53);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher par";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(261, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 18);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "Prénom";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(476, 22);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(59, 18);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.Text = "Statut";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 18);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Code Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(338, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(54, 18);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "Pays";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(108, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 18);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Référence";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(409, 22);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(49, 18);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "Ville";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(200, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 18);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Nom";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mots Clés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(854, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clients_FormClosing);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Clients_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostalClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telFixeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telMobileClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn societeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbTransactionsClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherClientToolStripMenuItem;
        public gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        public System.Windows.Forms.BindingSource clientBindingSource;
        public gestioncommercialeDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prenom_Client;
    }
}