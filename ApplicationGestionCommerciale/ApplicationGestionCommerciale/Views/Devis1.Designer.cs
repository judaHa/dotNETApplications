namespace ApplicationGestionCommerciale
{
    partial class Devis1
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
            this.dgvDevis = new System.Windows.Forms.DataGridView();
            this.dvcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientcodeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvstatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvvilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvcpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvpaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvfixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvfaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvmobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsitewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.devisTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.devisTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterDevisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierDevisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerDevisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerDevisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherDevisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevis
            // 
            this.dgvDevis.AllowUserToAddRows = false;
            this.dgvDevis.AllowUserToDeleteRows = false;
            this.dgvDevis.AllowUserToResizeRows = false;
            this.dgvDevis.AutoGenerateColumns = false;
            this.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvcodeDataGridViewTextBoxColumn,
            this.clientcodeClientDataGridViewTextBoxColumn,
            this.dvstatutDataGridViewTextBoxColumn,
            this.dvdateDataGridViewTextBoxColumn,
            this.dvadresseDataGridViewTextBoxColumn,
            this.dvvilleDataGridViewTextBoxColumn,
            this.dvcpDataGridViewTextBoxColumn,
            this.dvpaysDataGridViewTextBoxColumn,
            this.dvfixeDataGridViewTextBoxColumn,
            this.dvfaxDataGridViewTextBoxColumn,
            this.dvmobileDataGridViewTextBoxColumn,
            this.dvemailDataGridViewTextBoxColumn,
            this.dvsitewDataGridViewTextBoxColumn,
            this.dvnoteDataGridViewTextBoxColumn});
            this.dgvDevis.DataSource = this.devisBindingSource;
            this.dgvDevis.Location = new System.Drawing.Point(87, 12);
            this.dgvDevis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDevis.MultiSelect = false;
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.ReadOnly = true;
            this.dgvDevis.RowHeadersVisible = false;
            this.dgvDevis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevis.Size = new System.Drawing.Size(759, 374);
            this.dgvDevis.TabIndex = 44;
            this.dgvDevis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDevis_MouseClick);
            this.dgvDevis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDevis_MouseDoubleClick);
            // 
            // dvcodeDataGridViewTextBoxColumn
            // 
            this.dvcodeDataGridViewTextBoxColumn.DataPropertyName = "dv_code";
            this.dvcodeDataGridViewTextBoxColumn.HeaderText = "dv_code";
            this.dvcodeDataGridViewTextBoxColumn.Name = "dvcodeDataGridViewTextBoxColumn";
            this.dvcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientcodeClientDataGridViewTextBoxColumn
            // 
            this.clientcodeClientDataGridViewTextBoxColumn.DataPropertyName = "Client_codeClient";
            this.clientcodeClientDataGridViewTextBoxColumn.HeaderText = "Client_codeClient";
            this.clientcodeClientDataGridViewTextBoxColumn.Name = "clientcodeClientDataGridViewTextBoxColumn";
            this.clientcodeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvstatutDataGridViewTextBoxColumn
            // 
            this.dvstatutDataGridViewTextBoxColumn.DataPropertyName = "dv_statut";
            this.dvstatutDataGridViewTextBoxColumn.HeaderText = "dv_statut";
            this.dvstatutDataGridViewTextBoxColumn.Name = "dvstatutDataGridViewTextBoxColumn";
            this.dvstatutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvdateDataGridViewTextBoxColumn
            // 
            this.dvdateDataGridViewTextBoxColumn.DataPropertyName = "dv_date";
            this.dvdateDataGridViewTextBoxColumn.HeaderText = "dv_date";
            this.dvdateDataGridViewTextBoxColumn.Name = "dvdateDataGridViewTextBoxColumn";
            this.dvdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvadresseDataGridViewTextBoxColumn
            // 
            this.dvadresseDataGridViewTextBoxColumn.DataPropertyName = "dv_adresse";
            this.dvadresseDataGridViewTextBoxColumn.HeaderText = "dv_adresse";
            this.dvadresseDataGridViewTextBoxColumn.Name = "dvadresseDataGridViewTextBoxColumn";
            this.dvadresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvvilleDataGridViewTextBoxColumn
            // 
            this.dvvilleDataGridViewTextBoxColumn.DataPropertyName = "dv_ville";
            this.dvvilleDataGridViewTextBoxColumn.HeaderText = "dv_ville";
            this.dvvilleDataGridViewTextBoxColumn.Name = "dvvilleDataGridViewTextBoxColumn";
            this.dvvilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvcpDataGridViewTextBoxColumn
            // 
            this.dvcpDataGridViewTextBoxColumn.DataPropertyName = "dv_cp";
            this.dvcpDataGridViewTextBoxColumn.HeaderText = "dv_cp";
            this.dvcpDataGridViewTextBoxColumn.Name = "dvcpDataGridViewTextBoxColumn";
            this.dvcpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvpaysDataGridViewTextBoxColumn
            // 
            this.dvpaysDataGridViewTextBoxColumn.DataPropertyName = "dv_pays";
            this.dvpaysDataGridViewTextBoxColumn.HeaderText = "dv_pays";
            this.dvpaysDataGridViewTextBoxColumn.Name = "dvpaysDataGridViewTextBoxColumn";
            this.dvpaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvfixeDataGridViewTextBoxColumn
            // 
            this.dvfixeDataGridViewTextBoxColumn.DataPropertyName = "dv_fixe";
            this.dvfixeDataGridViewTextBoxColumn.HeaderText = "dv_fixe";
            this.dvfixeDataGridViewTextBoxColumn.Name = "dvfixeDataGridViewTextBoxColumn";
            this.dvfixeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvfaxDataGridViewTextBoxColumn
            // 
            this.dvfaxDataGridViewTextBoxColumn.DataPropertyName = "dv_fax";
            this.dvfaxDataGridViewTextBoxColumn.HeaderText = "dv_fax";
            this.dvfaxDataGridViewTextBoxColumn.Name = "dvfaxDataGridViewTextBoxColumn";
            this.dvfaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvmobileDataGridViewTextBoxColumn
            // 
            this.dvmobileDataGridViewTextBoxColumn.DataPropertyName = "dv_mobile";
            this.dvmobileDataGridViewTextBoxColumn.HeaderText = "dv_mobile";
            this.dvmobileDataGridViewTextBoxColumn.Name = "dvmobileDataGridViewTextBoxColumn";
            this.dvmobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvemailDataGridViewTextBoxColumn
            // 
            this.dvemailDataGridViewTextBoxColumn.DataPropertyName = "dv_email";
            this.dvemailDataGridViewTextBoxColumn.HeaderText = "dv_email";
            this.dvemailDataGridViewTextBoxColumn.Name = "dvemailDataGridViewTextBoxColumn";
            this.dvemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvsitewDataGridViewTextBoxColumn
            // 
            this.dvsitewDataGridViewTextBoxColumn.DataPropertyName = "dv_sitew";
            this.dvsitewDataGridViewTextBoxColumn.HeaderText = "dv_sitew";
            this.dvsitewDataGridViewTextBoxColumn.Name = "dvsitewDataGridViewTextBoxColumn";
            this.dvsitewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvnoteDataGridViewTextBoxColumn
            // 
            this.dvnoteDataGridViewTextBoxColumn.DataPropertyName = "dv_note";
            this.dvnoteDataGridViewTextBoxColumn.HeaderText = "dv_note";
            this.dvnoteDataGridViewTextBoxColumn.Name = "dvnoteDataGridViewTextBoxColumn";
            this.dvnoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataMember = "devis";
            this.devisBindingSource.DataSource = this.gestioncommercialeDataSet1;
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
            this.pictureBox6.Location = new System.Drawing.Point(13, 317);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ApplicationGestionCommerciale.Properties.Resources.Imprimer;
            this.pictureBox5.Location = new System.Drawing.Point(13, 241);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ApplicationGestionCommerciale.Properties.Resources.Supprimer;
            this.pictureBox4.Location = new System.Drawing.Point(13, 165);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ApplicationGestionCommerciale.Properties.Resources.modifier;
            this.pictureBox3.Location = new System.Drawing.Point(13, 89);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
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
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(87, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 66);
            this.panel2.TabIndex = 48;
            this.panel2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Actif",
            "Terminé",
            "Annulé"});
            this.comboBox1.Location = new System.Drawing.Point(62, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 22);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.Text = "Actif";
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
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Location = new System.Drawing.Point(205, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 53);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher par";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(462, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Statut";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(391, 21);
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
            this.radioButton5.Location = new System.Drawing.Point(324, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 16);
            this.radioButton5.TabIndex = 51;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Pays";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(19, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Code Devis";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(110, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Code Client";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(220, 22);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(82, 16);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Date Devis";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mots Clés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // devisTableAdapter
            // 
            this.devisTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDevisToolStripMenuItem,
            this.modifierDevisToolStripMenuItem,
            this.supprimerDevisToolStripMenuItem,
            this.imprimerDevisToolStripMenuItem,
            this.rechercherDevisToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ajouterDevisToolStripMenuItem
            // 
            this.ajouterDevisToolStripMenuItem.Name = "ajouterDevisToolStripMenuItem";
            this.ajouterDevisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ajouterDevisToolStripMenuItem.Text = "Ajouter Devis";
            this.ajouterDevisToolStripMenuItem.Click += new System.EventHandler(this.ajouterDevisToolStripMenuItem_Click);
            // 
            // modifierDevisToolStripMenuItem
            // 
            this.modifierDevisToolStripMenuItem.Name = "modifierDevisToolStripMenuItem";
            this.modifierDevisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modifierDevisToolStripMenuItem.Text = "Modifier Devis";
            this.modifierDevisToolStripMenuItem.Click += new System.EventHandler(this.modifierDevisToolStripMenuItem_Click);
            // 
            // supprimerDevisToolStripMenuItem
            // 
            this.supprimerDevisToolStripMenuItem.Name = "supprimerDevisToolStripMenuItem";
            this.supprimerDevisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.supprimerDevisToolStripMenuItem.Text = "Supprimer Devis";
            this.supprimerDevisToolStripMenuItem.Click += new System.EventHandler(this.supprimerDevisToolStripMenuItem_Click);
            // 
            // imprimerDevisToolStripMenuItem
            // 
            this.imprimerDevisToolStripMenuItem.Name = "imprimerDevisToolStripMenuItem";
            this.imprimerDevisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.imprimerDevisToolStripMenuItem.Text = "Imprimer Devis";
            this.imprimerDevisToolStripMenuItem.Click += new System.EventHandler(this.imprimerDevisToolStripMenuItem_Click);
            // 
            // rechercherDevisToolStripMenuItem
            // 
            this.rechercherDevisToolStripMenuItem.Name = "rechercherDevisToolStripMenuItem";
            this.rechercherDevisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rechercherDevisToolStripMenuItem.Text = "Rechercher Devis";
            this.rechercherDevisToolStripMenuItem.Click += new System.EventHandler(this.rechercherDevisToolStripMenuItem_Click);
            // 
            // Devis1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(854, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDevis);
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
            this.Name = "Devis1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devis1_FormClosing);
            this.Load += new System.EventHandler(this.Devis1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Devis1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevis;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientcodeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvstatutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvvilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvcpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvpaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvfixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvfaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvmobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsitewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterDevisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierDevisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerDevisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerDevisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherDevisToolStripMenuItem;
        public gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        public gestioncommercialeDataSet1TableAdapters.devisTableAdapter devisTableAdapter;
    }
}