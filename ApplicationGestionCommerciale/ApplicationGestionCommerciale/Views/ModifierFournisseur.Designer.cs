namespace ApplicationGestionCommerciale
{
    partial class ModifierFournisseur
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbNouveau = new System.Windows.Forms.RadioButton();
            this.rbInactif = new System.Windows.Forms.RadioButton();
            this.rbActif = new System.Windows.Forms.RadioButton();
            this.txtadresse = new System.Windows.Forms.RichTextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcodepostal = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnotes = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApplicationGestionCommerciale.Properties.Resources.annulerLeave;
            this.pictureBox2.Location = new System.Drawing.Point(346, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 132;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationGestionCommerciale.Properties.Resources.enregistrerLeave;
            this.pictureBox1.Location = new System.Drawing.Point(145, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // rbNouveau
            // 
            this.rbNouveau.AutoSize = true;
            this.rbNouveau.Location = new System.Drawing.Point(246, 461);
            this.rbNouveau.Name = "rbNouveau";
            this.rbNouveau.Size = new System.Drawing.Size(76, 18);
            this.rbNouveau.TabIndex = 14;
            this.rbNouveau.TabStop = true;
            this.rbNouveau.Text = "Nouveau";
            this.rbNouveau.UseVisualStyleBackColor = true;
            // 
            // rbInactif
            // 
            this.rbInactif.AutoSize = true;
            this.rbInactif.Location = new System.Drawing.Point(434, 461);
            this.rbInactif.Name = "rbInactif";
            this.rbInactif.Size = new System.Drawing.Size(61, 18);
            this.rbInactif.TabIndex = 16;
            this.rbInactif.TabStop = true;
            this.rbInactif.Text = "Inactif";
            this.rbInactif.UseVisualStyleBackColor = true;
            // 
            // rbActif
            // 
            this.rbActif.AutoSize = true;
            this.rbActif.Location = new System.Drawing.Point(350, 461);
            this.rbActif.Name = "rbActif";
            this.rbActif.Size = new System.Drawing.Size(52, 18);
            this.rbActif.TabIndex = 15;
            this.rbActif.TabStop = true;
            this.rbActif.Text = "Actif";
            this.rbActif.UseVisualStyleBackColor = true;
            // 
            // txtadresse
            // 
            this.txtadresse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtadresse.Location = new System.Drawing.Point(200, 111);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(367, 41);
            this.txtadresse.TabIndex = 4;
            this.txtadresse.Text = "";
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(200, 287);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(367, 21);
            this.txtfax.TabIndex = 10;
            this.txtfax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfax_KeyPress);
            // 
            // txtsite
            // 
            this.txtsite.Location = new System.Drawing.Point(200, 339);
            this.txtsite.Name = "txtsite";
            this.txtsite.Size = new System.Drawing.Size(367, 21);
            this.txtsite.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(200, 313);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(367, 21);
            this.txtemail.TabIndex = 11;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // txtcodepostal
            // 
            this.txtcodepostal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcodepostal.Location = new System.Drawing.Point(200, 158);
            this.txtcodepostal.Name = "txtcodepostal";
            this.txtcodepostal.Size = new System.Drawing.Size(367, 21);
            this.txtcodepostal.TabIndex = 5;
            this.txtcodepostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodepostal_KeyPress);
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttel.Location = new System.Drawing.Point(200, 236);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(367, 21);
            this.txttel.TabIndex = 8;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // txtville
            // 
            this.txtville.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtville.Location = new System.Drawing.Point(200, 184);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(367, 21);
            this.txtville.TabIndex = 6;
            // 
            // txtprenom
            // 
            this.txtprenom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtprenom.Location = new System.Drawing.Point(200, 85);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(367, 21);
            this.txtprenom.TabIndex = 3;
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnom.Location = new System.Drawing.Point(200, 59);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(367, 21);
            this.txtnom.TabIndex = 2;
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(200, 379);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(370, 71);
            this.txtnotes.TabIndex = 13;
            this.txtnotes.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(84, 382);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 14);
            this.label16.TabIndex = 150;
            this.label16.Text = "Notes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(84, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 14);
            this.label14.TabIndex = 149;
            this.label14.Text = "Etat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(84, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 14);
            this.label12.TabIndex = 148;
            this.label12.Text = "Fax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(84, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 14);
            this.label11.TabIndex = 147;
            this.label11.Text = "Website";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(84, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 146;
            this.label10.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(84, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 145;
            this.label9.Text = "Code Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(84, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 144;
            this.label8.Text = "Tél. Fixe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(84, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 143;
            this.label7.Text = "Pays";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(84, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 142;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(84, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 141;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(84, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 140;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(84, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 139;
            this.label3.Text = "Nom";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afghanistan",
            "Afrique du Sud",
            "Albanie",
            "Algérie",
            "Allemagne",
            "Andorre",
            "Angola",
            "Antigua-et-Barbuda",
            "Arabie saoudite",
            "Argentine",
            "Arménie",
            "Australie",
            "Autriche",
            "Azerbaïdjan",
            "Bahamas",
            "Bahreïn",
            "Bangladesh",
            "Barbade",
            "Belgique",
            "Belize",
            "Bénin",
            "Bhoutan",
            "Biélorussie",
            "Birmanie",
            "Bolivie",
            "Bosnie-Herzégovine",
            "Botswana",
            "Brésil",
            "Brunei",
            "Bulgarie",
            "BurkinaFaso",
            "Burundi",
            "Cambodge",
            "Cameroun",
            "Canada",
            "Cap-Vert",
            "Centrafrique",
            "Chili",
            "Chypre",
            "Colombie",
            "Comores",
            "Congo-Brazzaville",
            "Corée du Nord",
            "Corée du Sud",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatie",
            "Cuba",
            "Danemark",
            "Djibouti",
            "Dominique",
            "Guinée",
            "Libye",
            "Chine",
            "Égypte",
            "Émirats arabes unis",
            "Équateur",
            "Érythrée",
            "Espagne",
            "Estonie",
            "États-Unis",
            "Éthiopie",
            "Fidji",
            "Finlande",
            "France",
            "Gabon",
            "Gambie",
            "Géorgie",
            "Ghana",
            "Grèce",
            "Grenade",
            "Guatemala",
            "Guernesey",
            "Guinée-Bissau",
            "Guinéeéquatoriale",
            "Guyana",
            "Haïti",
            "Honduras",
            "Hongrie",
            "Île de Man",
            "Îles Cook",
            "Îles Salomon",
            "Inde",
            "Indonésie",
            "Irak",
            "Iran",
            "Irlande",
            "Islande",
            "Italie",
            "Jamaïque",
            "Japon",
            "Jersey",
            "Jordanie",
            "Kazakhstan",
            "Kenya",
            "Kirghizistan",
            "Kiribati",
            "Koweït",
            "LaosLaos",
            "Lesotho",
            "Lettonie",
            "Liban",
            "Libéria",
            "Liechtenstein",
            "Lituanie",
            "Luxembourg",
            "Macédoine",
            "Madagascar",
            "Malaisie",
            "Malawi",
            "Maldives",
            "Mali",
            "Malte",
            "Maroc",
            "Marshall",
            "Maurice",
            "Mauritanie",
            "Mexique",
            "Micronésie",
            "Moldavie",
            "Monaco",
            "Mongolie",
            "Monténégro",
            "Mozambique",
            "Namibie",
            "Nauru",
            "Népal",
            "Nicaragua",
            "Nigeria",
            "Niger",
            "Niué",
            "Norvège",
            "Nouvelle-Zélande",
            "Oman",
            "Ouganda",
            "Ouzbékistan",
            "Pakistan",
            "Palaos",
            "Palestine",
            "Panamá",
            "Papouasie-Nouvelle-Guinée",
            "Paraguay",
            "Pays-Bas",
            "Pérou",
            "Philippines",
            "Pologne",
            "Portugal",
            "Qatar",
            "République démocratique du Congo",
            "République dominicaine",
            "République tchèque",
            "Roumanie",
            "Royaume-Uni",
            "Russie",
            "Rwanda",
            "Saint-Christophe-et-Niévès",
            "Sainte-Lucie",
            "Saint-Marin",
            "Saint-Vincent-et-lesGrenadines",
            "SalvadorSalvador",
            "Samoa",
            "SãoTomé-et-Principe",
            "Sénégal",
            "SerbieSerbie",
            "Seychelles",
            "SierraLeone",
            "Singapour",
            "Slovaquie",
            "Slovénie",
            "Somalie",
            "Soudan",
            "SriLanka",
            "Suède",
            "Suisse",
            "Suriname",
            "Swaziland",
            "Syrie",
            "Tadjikistan",
            "Taïwan",
            "Tanzanie",
            "Tchad",
            "Thaïlande",
            "Timororiental",
            "Togo",
            "Tonga",
            "Trinité-et-Tobago",
            "Tunisie",
            "Turkménistan",
            "Turquie",
            "Tuvalu",
            "Ukraine",
            "Uruguay",
            "Vatican",
            "Venezuela",
            "Vietnam",
            "Yémen",
            "Zambie",
            "Zimbabwe"});
            this.comboBox1.Location = new System.Drawing.Point(200, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 22);
            this.comboBox1.TabIndex = 7;
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(200, 10);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(367, 21);
            this.txtcode.TabIndex = 0;
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(84, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 166;
            this.label2.Text = "Code Fournisseur";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(200, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(84, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 168;
            this.label1.Text = "Tél. Mobile";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(200, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(84, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 14);
            this.label13.TabIndex = 170;
            this.label13.Text = "CIN / Référence";
            // 
            // ModifierFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 575);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbNouveau);
            this.Controls.Add(this.rbInactif);
            this.Controls.Add(this.rbActif);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtfax);
            this.Controls.Add(this.txtsite);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcodepostal);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ModifierFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier Fournisseurs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifierFournisseur_FormClosing);
            this.Load += new System.EventHandler(this.ModifierFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbNouveau;
        private System.Windows.Forms.RadioButton rbInactif;
        private System.Windows.Forms.RadioButton rbActif;
        private System.Windows.Forms.RichTextBox txtadresse;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txtsite;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcodepostal;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.RichTextBox txtnotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
    }
}