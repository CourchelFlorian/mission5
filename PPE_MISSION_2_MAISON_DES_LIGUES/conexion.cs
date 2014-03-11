using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    public partial class conexion : Form
    {
        public conexion()
        {
            InitializeComponent();
            
        }

        private void buttConexion_Click(object sender, EventArgs e)
        {
            int grade;
            int id;
            adherentDAO verif = new adherentDAO();
            if (verif.verifUtilisateur(textID.Text, textMdp.Text, out grade, out id))
            {
                if (grade == 1)
                {
                    // MENU RESPONSABLE
                    menuGrade1 menu1 = new menuGrade1();
                    menu1.Show();
                }
                else
                {
                    // MENU UTILISATEUR
                    menuGrade0 menu0 = new menuGrade0(id);
                    menu0.Show();
                }
            }
            else
            {
                // FENETRE MESSAGE ERREUR
                erreurAuthen erreur = new erreurAuthen();
                erreur.Show();
            }
            
        }

        private void conexion_Load(object sender, EventArgs e)
        {

        }        
    }
}
