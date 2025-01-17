using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_difficulté.Items.Add("Facile");
            comboBox_difficulté.Items.Add("Moyen");
            comboBox_difficulté.Items.Add("Difficile");
            comboBox_difficulté.Items.Add("Enfer");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            
            if (txt_Nom.Text !="" && txt_Prenom.Text !="")
            {
                string result = "Bonjour ";
                result += txt_Prenom.Text + " " + txt_Nom.Text + "\r\n La difficultés sélectionnée est: " + comboBox_difficulté.SelectedItem;
                txt_afficher.Text = result;

            }
            else
            {
                MessageBox.Show("Aucun nom ou prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void comboBox_difficulté_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_difficulté.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_Nom.Font = new Font(lbl_Nom.Font, FontStyle.Bold);
                lbl_Prenom.Font = new Font(lbl_Prenom.Font, FontStyle.Bold);
                lbl_Difficulte.Font = new Font(lbl_Difficulte.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
                lbl_Nom.Font = new Font(lbl_Nom.Font, FontStyle.Regular);
                lbl_Prenom.Font = new Font(lbl_Prenom.Font, FontStyle.Regular);
                lbl_Difficulte.Font = new Font(lbl_Difficulte.Font, FontStyle.Regular);
            }
        }

        
    }
}
