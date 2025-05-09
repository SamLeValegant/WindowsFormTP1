namespace WindowsFormTP1.Vue
{
    partial class afficherDonnees
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
            this.gbRechercheBDD = new System.Windows.Forms.GroupBox();
            this.comboRechercheDiff = new System.Windows.Forms.ComboBox();
            this.txtRecherchemot = new System.Windows.Forms.TextBox();
            this.lblRechercheDiff = new System.Windows.Forms.Label();
            this.lblRechercheMot = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjoutQuestion = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbBoxDiffAjoutModif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifierQuestion = new System.Windows.Forms.Button();
            this.btnSupprimerQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.gbRechercheBDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRechercheBDD
            // 
            this.gbRechercheBDD.Controls.Add(this.comboRechercheDiff);
            this.gbRechercheBDD.Controls.Add(this.txtRecherchemot);
            this.gbRechercheBDD.Controls.Add(this.lblRechercheDiff);
            this.gbRechercheBDD.Controls.Add(this.lblRechercheMot);
            this.gbRechercheBDD.Location = new System.Drawing.Point(50, 36);
            this.gbRechercheBDD.Name = "gbRechercheBDD";
            this.gbRechercheBDD.Size = new System.Drawing.Size(318, 141);
            this.gbRechercheBDD.TabIndex = 1;
            this.gbRechercheBDD.TabStop = false;
            // 
            // comboRechercheDiff
            // 
            this.comboRechercheDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRechercheDiff.FormattingEnabled = true;
            this.comboRechercheDiff.Location = new System.Drawing.Point(65, 95);
            this.comboRechercheDiff.Name = "comboRechercheDiff";
            this.comboRechercheDiff.Size = new System.Drawing.Size(176, 21);
            this.comboRechercheDiff.TabIndex = 3;
            this.comboRechercheDiff.SelectedIndexChanged += new System.EventHandler(this.comboRechercheDiff_SelectedIndexChanged);
            // 
            // txtRecherchemot
            // 
            this.txtRecherchemot.Location = new System.Drawing.Point(65, 40);
            this.txtRecherchemot.Name = "txtRecherchemot";
            this.txtRecherchemot.Size = new System.Drawing.Size(176, 20);
            this.txtRecherchemot.TabIndex = 2;
            this.txtRecherchemot.TextChanged += new System.EventHandler(this.txtRecherchemot_TextChanged);
            // 
            // lblRechercheDiff
            // 
            this.lblRechercheDiff.AutoSize = true;
            this.lblRechercheDiff.Location = new System.Drawing.Point(123, 79);
            this.lblRechercheDiff.Name = "lblRechercheDiff";
            this.lblRechercheDiff.Size = new System.Drawing.Size(48, 13);
            this.lblRechercheDiff.TabIndex = 1;
            this.lblRechercheDiff.Text = "Difficulté";
            // 
            // lblRechercheMot
            // 
            this.lblRechercheMot.AutoSize = true;
            this.lblRechercheMot.Location = new System.Drawing.Point(98, 24);
            this.lblRechercheMot.Name = "lblRechercheMot";
            this.lblRechercheMot.Size = new System.Drawing.Size(100, 13);
            this.lblRechercheMot.TabIndex = 0;
            this.lblRechercheMot.Text = "Recherche de mots";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Location = new System.Drawing.Point(1338, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(29, 23);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjoutQuestion
            // 
            this.btnAjoutQuestion.Location = new System.Drawing.Point(712, 223);
            this.btnAjoutQuestion.Name = "btnAjoutQuestion";
            this.btnAjoutQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutQuestion.TabIndex = 17;
            this.btnAjoutQuestion.Text = "Ajouter";
            this.btnAjoutQuestion.UseVisualStyleBackColor = true;
            this.btnAjoutQuestion.Click += new System.EventHandler(this.btnAjoutQuestion_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(50, 203);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(656, 454);
            this.dgvQuestions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbBoxDiffAjoutModif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(876, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 454);
            this.panel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Difficulté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proposition de réponse";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(98, 72);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 66);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(36, 270);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(223, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(36, 296);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cbBoxDiffAjoutModif
            // 
            this.cbBoxDiffAjoutModif.FormattingEnabled = true;
            this.cbBoxDiffAjoutModif.Location = new System.Drawing.Point(36, 366);
            this.cbBoxDiffAjoutModif.Name = "cbBoxDiffAjoutModif";
            this.cbBoxDiffAjoutModif.Size = new System.Drawing.Size(223, 21);
            this.cbBoxDiffAjoutModif.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout / Modification";
            // 
            // btnModifierQuestion
            // 
            this.btnModifierQuestion.Location = new System.Drawing.Point(712, 252);
            this.btnModifierQuestion.Name = "btnModifierQuestion";
            this.btnModifierQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnModifierQuestion.TabIndex = 21;
            this.btnModifierQuestion.Text = "Modifier";
            this.btnModifierQuestion.UseVisualStyleBackColor = true;
            this.btnModifierQuestion.Click += new System.EventHandler(this.btnModifierQuestion_Click);
            // 
            // btnSupprimerQuestion
            // 
            this.btnSupprimerQuestion.Location = new System.Drawing.Point(712, 281);
            this.btnSupprimerQuestion.Name = "btnSupprimerQuestion";
            this.btnSupprimerQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerQuestion.TabIndex = 22;
            this.btnSupprimerQuestion.Text = "Supprimer";
            this.btnSupprimerQuestion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bonne réponse";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(336, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(336, 299);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(336, 248);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(336, 273);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // afficherDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btnSupprimerQuestion);
            this.Controls.Add(this.btnModifierQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAjoutQuestion);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbRechercheBDD);
            this.Controls.Add(this.dgvQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "afficherDonnees";
            this.Text = "Form2";
            this.gbRechercheBDD.ResumeLayout(false);
            this.gbRechercheBDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRechercheBDD;
        private System.Windows.Forms.ComboBox comboRechercheDiff;
        private System.Windows.Forms.TextBox txtRecherchemot;
        private System.Windows.Forms.Label lblRechercheDiff;
        private System.Windows.Forms.Label lblRechercheMot;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjoutQuestion;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbBoxDiffAjoutModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnModifierQuestion;
        private System.Windows.Forms.Button btnSupprimerQuestion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}