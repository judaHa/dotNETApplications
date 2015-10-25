namespace Devis
{
    partial class RechercheDevis
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
            this.lMotsCles = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lRechPAr = new System.Windows.Forms.Label();
            this.rbCodeDevis = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lMotsCles
            // 
            this.lMotsCles.AutoSize = true;
            this.lMotsCles.Location = new System.Drawing.Point(33, 50);
            this.lMotsCles.Name = "lMotsCles";
            this.lMotsCles.Size = new System.Drawing.Size(53, 13);
            this.lMotsCles.TabIndex = 0;
            this.lMotsCles.Text = "Mots Clés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lRechPAr
            // 
            this.lRechPAr.AutoSize = true;
            this.lRechPAr.Location = new System.Drawing.Point(21, 112);
            this.lRechPAr.Name = "lRechPAr";
            this.lRechPAr.Size = new System.Drawing.Size(87, 13);
            this.lRechPAr.TabIndex = 2;
            this.lRechPAr.Text = "Rechercher par :";
            // 
            // rbCodeDevis
            // 
            this.rbCodeDevis.AutoSize = true;
            this.rbCodeDevis.Location = new System.Drawing.Point(124, 110);
            this.rbCodeDevis.Name = "rbCodeDevis";
            this.rbCodeDevis.Size = new System.Drawing.Size(80, 17);
            this.rbCodeDevis.TabIndex = 3;
            this.rbCodeDevis.TabStop = true;
            this.rbCodeDevis.Text = "Code Devis";
            this.rbCodeDevis.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(321, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(124, 133);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(215, 133);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(321, 133);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // RechercheDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbCodeDevis);
            this.Controls.Add(this.lRechPAr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lMotsCles);
            this.Name = "RechercheDevis";
            this.Text = "Recherche Devis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMotsCles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lRechPAr;
        private System.Windows.Forms.RadioButton rbCodeDevis;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}