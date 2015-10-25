namespace ApplicationGestionCommerciale
{
    partial class CommandesAchat
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCommAchat = new System.Windows.Forms.DataGridView();
            this.cmacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmastatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmadateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmadatelivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmaadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmavilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmacpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmapaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmafixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmamobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmafaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmaemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmasitewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmanoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeachatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.commandeachatTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.commandeachatTableAdapter();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommAchat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeachatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(87, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 66);
            this.panel2.TabIndex = 47;
            this.panel2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Terminée",
            "Annulée"});
            this.comboBox1.Location = new System.Drawing.Point(62, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 22);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.Text = "Active";
            this.comboBox1.Visible = false;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(202, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 53);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher par";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(436, 21);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(44, 17);
            this.radioButton6.TabIndex = 52;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Ville";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(381, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 16);
            this.radioButton5.TabIndex = 51;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Pays";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(253, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(122, 16);
            this.radioButton4.TabIndex = 50;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Code Fournisseur";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Code Commande";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(128, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Date Commande";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(491, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 16);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Statut";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mots Clés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dgvCommAchat
            // 
            this.dgvCommAchat.AllowUserToAddRows = false;
            this.dgvCommAchat.AllowUserToDeleteRows = false;
            this.dgvCommAchat.AllowUserToResizeRows = false;
            this.dgvCommAchat.AutoGenerateColumns = false;
            this.dgvCommAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommAchat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmacodeDataGridViewTextBoxColumn,
            this.frcodeDataGridViewTextBoxColumn,
            this.cmastatutDataGridViewTextBoxColumn,
            this.cmadateDataGridViewTextBoxColumn,
            this.cmadatelivDataGridViewTextBoxColumn,
            this.cmaadresseDataGridViewTextBoxColumn,
            this.cmavilleDataGridViewTextBoxColumn,
            this.cmacpDataGridViewTextBoxColumn,
            this.cmapaysDataGridViewTextBoxColumn,
            this.cmafixeDataGridViewTextBoxColumn,
            this.cmamobileDataGridViewTextBoxColumn,
            this.cmafaxDataGridViewTextBoxColumn,
            this.cmaemailDataGridViewTextBoxColumn,
            this.cmasitewDataGridViewTextBoxColumn,
            this.cmanoteDataGridViewTextBoxColumn});
            this.dgvCommAchat.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCommAchat.DataSource = this.commandeachatBindingSource;
            this.dgvCommAchat.Location = new System.Drawing.Point(87, 12);
            this.dgvCommAchat.MultiSelect = false;
            this.dgvCommAchat.Name = "dgvCommAchat";
            this.dgvCommAchat.ReadOnly = true;
            this.dgvCommAchat.RowHeadersVisible = false;
            this.dgvCommAchat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommAchat.Size = new System.Drawing.Size(759, 374);
            this.dgvCommAchat.TabIndex = 48;
            this.dgvCommAchat.DoubleClick += new System.EventHandler(this.dgvCommAchat_DoubleClick);
            this.dgvCommAchat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCommAchat_MouseClick);
            // 
            // cmacodeDataGridViewTextBoxColumn
            // 
            this.cmacodeDataGridViewTextBoxColumn.DataPropertyName = "cma_code";
            this.cmacodeDataGridViewTextBoxColumn.HeaderText = "cma_code";
            this.cmacodeDataGridViewTextBoxColumn.Name = "cmacodeDataGridViewTextBoxColumn";
            this.cmacodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frcodeDataGridViewTextBoxColumn
            // 
            this.frcodeDataGridViewTextBoxColumn.DataPropertyName = "fr_code";
            this.frcodeDataGridViewTextBoxColumn.HeaderText = "fr_code";
            this.frcodeDataGridViewTextBoxColumn.Name = "frcodeDataGridViewTextBoxColumn";
            this.frcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmastatutDataGridViewTextBoxColumn
            // 
            this.cmastatutDataGridViewTextBoxColumn.DataPropertyName = "cma_statut";
            this.cmastatutDataGridViewTextBoxColumn.HeaderText = "cma_statut";
            this.cmastatutDataGridViewTextBoxColumn.Name = "cmastatutDataGridViewTextBoxColumn";
            this.cmastatutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmadateDataGridViewTextBoxColumn
            // 
            this.cmadateDataGridViewTextBoxColumn.DataPropertyName = "cma_date";
            this.cmadateDataGridViewTextBoxColumn.HeaderText = "cma_date";
            this.cmadateDataGridViewTextBoxColumn.Name = "cmadateDataGridViewTextBoxColumn";
            this.cmadateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmadatelivDataGridViewTextBoxColumn
            // 
            this.cmadatelivDataGridViewTextBoxColumn.DataPropertyName = "cma_date_liv";
            this.cmadatelivDataGridViewTextBoxColumn.HeaderText = "cma_date_liv";
            this.cmadatelivDataGridViewTextBoxColumn.Name = "cmadatelivDataGridViewTextBoxColumn";
            this.cmadatelivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmaadresseDataGridViewTextBoxColumn
            // 
            this.cmaadresseDataGridViewTextBoxColumn.DataPropertyName = "cma_adresse";
            this.cmaadresseDataGridViewTextBoxColumn.HeaderText = "cma_adresse";
            this.cmaadresseDataGridViewTextBoxColumn.Name = "cmaadresseDataGridViewTextBoxColumn";
            this.cmaadresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmavilleDataGridViewTextBoxColumn
            // 
            this.cmavilleDataGridViewTextBoxColumn.DataPropertyName = "cma_ville";
            this.cmavilleDataGridViewTextBoxColumn.HeaderText = "cma_ville";
            this.cmavilleDataGridViewTextBoxColumn.Name = "cmavilleDataGridViewTextBoxColumn";
            this.cmavilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmacpDataGridViewTextBoxColumn
            // 
            this.cmacpDataGridViewTextBoxColumn.DataPropertyName = "cma_cp";
            this.cmacpDataGridViewTextBoxColumn.HeaderText = "cma_cp";
            this.cmacpDataGridViewTextBoxColumn.Name = "cmacpDataGridViewTextBoxColumn";
            this.cmacpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmapaysDataGridViewTextBoxColumn
            // 
            this.cmapaysDataGridViewTextBoxColumn.DataPropertyName = "cma_pays";
            this.cmapaysDataGridViewTextBoxColumn.HeaderText = "cma_pays";
            this.cmapaysDataGridViewTextBoxColumn.Name = "cmapaysDataGridViewTextBoxColumn";
            this.cmapaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmafixeDataGridViewTextBoxColumn
            // 
            this.cmafixeDataGridViewTextBoxColumn.DataPropertyName = "cma_fixe";
            this.cmafixeDataGridViewTextBoxColumn.HeaderText = "cma_fixe";
            this.cmafixeDataGridViewTextBoxColumn.Name = "cmafixeDataGridViewTextBoxColumn";
            this.cmafixeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmamobileDataGridViewTextBoxColumn
            // 
            this.cmamobileDataGridViewTextBoxColumn.DataPropertyName = "cma_mobile";
            this.cmamobileDataGridViewTextBoxColumn.HeaderText = "cma_mobile";
            this.cmamobileDataGridViewTextBoxColumn.Name = "cmamobileDataGridViewTextBoxColumn";
            this.cmamobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmafaxDataGridViewTextBoxColumn
            // 
            this.cmafaxDataGridViewTextBoxColumn.DataPropertyName = "cma_fax";
            this.cmafaxDataGridViewTextBoxColumn.HeaderText = "cma_fax";
            this.cmafaxDataGridViewTextBoxColumn.Name = "cmafaxDataGridViewTextBoxColumn";
            this.cmafaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmaemailDataGridViewTextBoxColumn
            // 
            this.cmaemailDataGridViewTextBoxColumn.DataPropertyName = "cma_email";
            this.cmaemailDataGridViewTextBoxColumn.HeaderText = "cma_email";
            this.cmaemailDataGridViewTextBoxColumn.Name = "cmaemailDataGridViewTextBoxColumn";
            this.cmaemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmasitewDataGridViewTextBoxColumn
            // 
            this.cmasitewDataGridViewTextBoxColumn.DataPropertyName = "cma_sitew";
            this.cmasitewDataGridViewTextBoxColumn.HeaderText = "cma_sitew";
            this.cmasitewDataGridViewTextBoxColumn.Name = "cmasitewDataGridViewTextBoxColumn";
            this.cmasitewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmanoteDataGridViewTextBoxColumn
            // 
            this.cmanoteDataGridViewTextBoxColumn.DataPropertyName = "cma_note";
            this.cmanoteDataGridViewTextBoxColumn.HeaderText = "cma_note";
            this.cmanoteDataGridViewTextBoxColumn.Name = "cmanoteDataGridViewTextBoxColumn";
            this.cmanoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCommandeToolStripMenuItem,
            this.modifierCommandeToolStripMenuItem,
            this.supprimerCommandeToolStripMenuItem,
            this.imprimerCommandeToolStripMenuItem,
            this.rechercherCommandeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ajouterCommandeToolStripMenuItem
            // 
            this.ajouterCommandeToolStripMenuItem.Name = "ajouterCommandeToolStripMenuItem";
            this.ajouterCommandeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ajouterCommandeToolStripMenuItem.Text = "Ajouter Commande";
            this.ajouterCommandeToolStripMenuItem.Click += new System.EventHandler(this.ajouterCommandeToolStripMenuItem_Click);
            // 
            // modifierCommandeToolStripMenuItem
            // 
            this.modifierCommandeToolStripMenuItem.Name = "modifierCommandeToolStripMenuItem";
            this.modifierCommandeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modifierCommandeToolStripMenuItem.Text = "Modifier Commande";
            this.modifierCommandeToolStripMenuItem.Click += new System.EventHandler(this.modifierCommandeToolStripMenuItem_Click);
            // 
            // supprimerCommandeToolStripMenuItem
            // 
            this.supprimerCommandeToolStripMenuItem.Name = "supprimerCommandeToolStripMenuItem";
            this.supprimerCommandeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.supprimerCommandeToolStripMenuItem.Text = "Supprimer Commande";
            this.supprimerCommandeToolStripMenuItem.Click += new System.EventHandler(this.supprimerCommandeToolStripMenuItem_Click);
            // 
            // imprimerCommandeToolStripMenuItem
            // 
            this.imprimerCommandeToolStripMenuItem.Name = "imprimerCommandeToolStripMenuItem";
            this.imprimerCommandeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.imprimerCommandeToolStripMenuItem.Text = "Imprimer Commande";
            this.imprimerCommandeToolStripMenuItem.Click += new System.EventHandler(this.imprimerCommandeToolStripMenuItem_Click);
            // 
            // rechercherCommandeToolStripMenuItem
            // 
            this.rechercherCommandeToolStripMenuItem.Name = "rechercherCommandeToolStripMenuItem";
            this.rechercherCommandeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.rechercherCommandeToolStripMenuItem.Text = "Rechercher Commande";
            this.rechercherCommandeToolStripMenuItem.Click += new System.EventHandler(this.rechercherCommandeToolStripMenuItem_Click);
            // 
            // commandeachatBindingSource
            // 
            this.commandeachatBindingSource.DataMember = "commandeachat";
            this.commandeachatBindingSource.DataSource = this.gestioncommercialeDataSet1;
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
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
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
            // commandeachatTableAdapter
            // 
            this.commandeachatTableAdapter.ClearBeforeFill = true;
            // 
            // CommandesAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(854, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCommAchat);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CommandesAchat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commandes d\'achat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommandesAchat_FormClosing);
            this.Load += new System.EventHandler(this.CommandesAchat_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommandesAchat_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommAchat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandeachatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCommAchat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmastatutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmadateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmadatelivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmaadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmavilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmacpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmapaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmafixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmamobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmafaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmaemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmasitewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmanoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherCommandeToolStripMenuItem;
        public gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        public System.Windows.Forms.BindingSource commandeachatBindingSource;
        public gestioncommercialeDataSet1TableAdapters.commandeachatTableAdapter commandeachatTableAdapter;

    }
}