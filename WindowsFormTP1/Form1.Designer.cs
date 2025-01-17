namespace WindowsFormTP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.lbl_rep = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.lbl_Difficulte = new System.Windows.Forms.Label();
            this.comboBox_difficulté = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_afficher
            // 
            this.txt_afficher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Location = new System.Drawing.Point(468, 168);
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(339, 20);
            this.txt_afficher.TabIndex = 0;
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(401, 171);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(50, 13);
            this.lbl_rep.TabIndex = 1;
            this.lbl_rep.Text = "Réponse";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(521, 363);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Push Me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(401, 221);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nom.TabIndex = 3;
            this.lbl_Nom.Text = "Nom :";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(401, 275);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_Prenom.TabIndex = 4;
            this.lbl_Prenom.Text = "Prénom :";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(507, 218);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(124, 20);
            this.txt_Nom.TabIndex = 5;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(507, 272);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(124, 20);
            this.txt_Prenom.TabIndex = 6;
            // 
            // lbl_Difficulte
            // 
            this.lbl_Difficulte.AutoSize = true;
            this.lbl_Difficulte.Location = new System.Drawing.Point(401, 323);
            this.lbl_Difficulte.Name = "lbl_Difficulte";
            this.lbl_Difficulte.Size = new System.Drawing.Size(57, 13);
            this.lbl_Difficulte.TabIndex = 7;
            this.lbl_Difficulte.Text = "Difficulté : ";
            // 
            // comboBox_difficulté
            // 
            this.comboBox_difficulté.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_difficulté.FormattingEnabled = true;
            this.comboBox_difficulté.Location = new System.Drawing.Point(507, 320);
            this.comboBox_difficulté.Name = "comboBox_difficulté";
            this.comboBox_difficulté.Size = new System.Drawing.Size(124, 21);
            this.comboBox_difficulté.TabIndex = 8;
            this.comboBox_difficulté.SelectedIndexChanged += new System.EventHandler(this.comboBox_difficulté_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1177, 723);
            this.Controls.Add(this.comboBox_difficulté);
            this.Controls.Add(this.lbl_Difficulte);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_rep);
            this.Controls.Add(this.txt_afficher);
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.Label lbl_Difficulte;
        private System.Windows.Forms.ComboBox comboBox_difficulté;
    }
}

