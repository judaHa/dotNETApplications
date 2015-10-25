namespace ApplicationGestionCommerciale
{
    partial class Factures
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
            this.numeroFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timbreFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantHTFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantTTCFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientcodeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSet1 = new ApplicationGestionCommerciale.gestioncommercialeDataSet1();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.factureTableAdapter = new ApplicationGestionCommerciale.gestioncommercialeDataSet1TableAdapters.factureTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFactureDataGridViewTextBoxColumn,
            this.dateFactureDataGridViewTextBoxColumn,
            this.timbreFactureDataGridViewTextBoxColumn,
            this.remiseFactureDataGridViewTextBoxColumn,
            this.montantHTFactureDataGridViewTextBoxColumn,
            this.montantTTCFactureDataGridViewTextBoxColumn,
            this.statutFactureDataGridViewTextBoxColumn,
            this.clientcodeClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 374);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // numeroFactureDataGridViewTextBoxColumn
            // 
            this.numeroFactureDataGridViewTextBoxColumn.DataPropertyName = "numero_Facture";
            this.numeroFactureDataGridViewTextBoxColumn.HeaderText = "numero_Facture";
            this.numeroFactureDataGridViewTextBoxColumn.Name = "numeroFactureDataGridViewTextBoxColumn";
            this.numeroFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFactureDataGridViewTextBoxColumn
            // 
            this.dateFactureDataGridViewTextBoxColumn.DataPropertyName = "date_Facture";
            this.dateFactureDataGridViewTextBoxColumn.HeaderText = "date_Facture";
            this.dateFactureDataGridViewTextBoxColumn.Name = "dateFactureDataGridViewTextBoxColumn";
            this.dateFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timbreFactureDataGridViewTextBoxColumn
            // 
            this.timbreFactureDataGridViewTextBoxColumn.DataPropertyName = "timbre_Facture";
            this.timbreFactureDataGridViewTextBoxColumn.HeaderText = "timbre_Facture";
            this.timbreFactureDataGridViewTextBoxColumn.Name = "timbreFactureDataGridViewTextBoxColumn";
            this.timbreFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseFactureDataGridViewTextBoxColumn
            // 
            this.remiseFactureDataGridViewTextBoxColumn.DataPropertyName = "remise_Facture";
            this.remiseFactureDataGridViewTextBoxColumn.HeaderText = "remise_Facture";
            this.remiseFactureDataGridViewTextBoxColumn.Name = "remiseFactureDataGridViewTextBoxColumn";
            this.remiseFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantHTFactureDataGridViewTextBoxColumn
            // 
            this.montantHTFactureDataGridViewTextBoxColumn.DataPropertyName = "montantHT_Facture";
            this.montantHTFactureDataGridViewTextBoxColumn.HeaderText = "montantHT_Facture";
            this.montantHTFactureDataGridViewTextBoxColumn.Name = "montantHTFactureDataGridViewTextBoxColumn";
            this.montantHTFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantTTCFactureDataGridViewTextBoxColumn
            // 
            this.montantTTCFactureDataGridViewTextBoxColumn.DataPropertyName = "montantTTC_Facture";
            this.montantTTCFactureDataGridViewTextBoxColumn.HeaderText = "montantTTC_Facture";
            this.montantTTCFactureDataGridViewTextBoxColumn.Name = "montantTTCFactureDataGridViewTextBoxColumn";
            this.montantTTCFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statutFactureDataGridViewTextBoxColumn
            // 
            this.statutFactureDataGridViewTextBoxColumn.DataPropertyName = "statut_Facture";
            this.statutFactureDataGridViewTextBoxColumn.HeaderText = "statut_Facture";
            this.statutFactureDataGridViewTextBoxColumn.Name = "statutFactureDataGridViewTextBoxColumn";
            this.statutFactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientcodeClientDataGridViewTextBoxColumn
            // 
            this.clientcodeClientDataGridViewTextBoxColumn.DataPropertyName = "Client_codeClient";
            this.clientcodeClientDataGridViewTextBoxColumn.HeaderText = "Client_codeClient";
            this.clientcodeClientDataGridViewTextBoxColumn.Name = "clientcodeClientDataGridViewTextBoxColumn";
            this.clientcodeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "facture";
            this.factureBindingSource.DataSource = this.gestioncommercialeDataSet1;
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
            this.pictureBox6.TabIndex = 32;
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
            this.pictureBox5.TabIndex = 31;
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
            this.pictureBox4.TabIndex = 30;
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
            this.pictureBox3.TabIndex = 29;
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
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(87, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 66);
            this.panel2.TabIndex = 46;
            this.panel2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(235, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 54);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher par";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Numéro Facture";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Date Facture";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(385, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Statut Facture";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(269, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Code Client";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ouverte",
            "Comptabilisée"});
            this.comboBox1.Location = new System.Drawing.Point(81, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 22);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Text = "Ouverte";
            this.comboBox1.Visible = false;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mots Clés";
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterFactureToolStripMenuItem,
            this.modifierFactureToolStripMenuItem,
            this.suprimerFactureToolStripMenuItem,
            this.imprimerFactureToolStripMenuItem,
            this.rechercherFactureToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ajouterFactureToolStripMenuItem
            // 
            this.ajouterFactureToolStripMenuItem.Name = "ajouterFactureToolStripMenuItem";
            this.ajouterFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterFactureToolStripMenuItem.Text = "Ajouter Facture";
            this.ajouterFactureToolStripMenuItem.Click += new System.EventHandler(this.ajouterFactureToolStripMenuItem_Click);
            // 
            // modifierFactureToolStripMenuItem
            // 
            this.modifierFactureToolStripMenuItem.Name = "modifierFactureToolStripMenuItem";
            this.modifierFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.modifierFactureToolStripMenuItem.Text = "Modifier Facture";
            this.modifierFactureToolStripMenuItem.Click += new System.EventHandler(this.modifierFactureToolStripMenuItem_Click);
            // 
            // suprimerFactureToolStripMenuItem
            // 
            this.suprimerFactureToolStripMenuItem.Name = "suprimerFactureToolStripMenuItem";
            this.suprimerFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.suprimerFactureToolStripMenuItem.Text = "Supprimer Facture";
            this.suprimerFactureToolStripMenuItem.Click += new System.EventHandler(this.suprimerFactureToolStripMenuItem_Click);
            // 
            // imprimerFactureToolStripMenuItem
            // 
            this.imprimerFactureToolStripMenuItem.Name = "imprimerFactureToolStripMenuItem";
            this.imprimerFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.imprimerFactureToolStripMenuItem.Text = "Imprimer Facture";
            this.imprimerFactureToolStripMenuItem.Click += new System.EventHandler(this.imprimerFactureToolStripMenuItem_Click);
            // 
            // rechercherFactureToolStripMenuItem
            // 
            this.rechercherFactureToolStripMenuItem.Name = "rechercherFactureToolStripMenuItem";
            this.rechercherFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rechercherFactureToolStripMenuItem.Text = "Rechercher Facture";
            this.rechercherFactureToolStripMenuItem.Click += new System.EventHandler(this.rechercherFactureToolStripMenuItem_Click);
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(854, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Factures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Factures_FormClosing);
            this.Load += new System.EventHandler(this.Factures_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Factures_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timbreFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantHTFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantTTCFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientcodeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherFactureToolStripMenuItem;
        public gestioncommercialeDataSet1 gestioncommercialeDataSet1;
        public gestioncommercialeDataSet1TableAdapters.factureTableAdapter factureTableAdapter;

    }
}