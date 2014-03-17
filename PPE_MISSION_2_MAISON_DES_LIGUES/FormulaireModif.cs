using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    public partial class FormulaireModif : Form
    {
        private int idService;
        private int idEtat;
        private DataGridView tableau;

        public FormulaireModif()
        {
            InitializeComponent();
        }
        public FormulaireModif(int idServ,int pIdEtat,DataGridView pTableau)
        {
            idService = idServ;
            idEtat = pIdEtat;
            tableau = pTableau;
            InitializeComponent();
        }

        private void FormulaireModif_Load(object sender, EventArgs e)
        {

            if (idEtat == 0)
            {
                labelChangement.Text = "Passer ce service en état Validé";
            }
            if (idEtat == 3)
            {
                labelChangement.Text = "Passer ce service en état Réalisé";
            }
            if (idEtat == 1)
            {
                labelChangement.Text = "Passer ce service en état Facturé";
            }
            // TODO: cette ligne de code charge les données dans la table 'bddGestServKestCourcDataSet.etat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etatTableAdapter1.Fill(this.bddGestServKestCourcDataSet.etat);
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet4.etat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.etatTableAdapter.Fill(this.m2l_Marco_SalimDataSet4.etat);
        }

        private void buttValiderChangement_Click_1(object sender, EventArgs e)
        {
            int unEtat = 0;

            if (idEtat == 0)
            {
                unEtat = 3;
            }
            if (idEtat == 3)
            {
                unEtat = 1;
            }
            if (idEtat == 1)
            {
                unEtat = 2;
            }
            ServiceDemandeDAO mettreAjour = new ServiceDemandeDAO();
            mettreAjour.update(idService,unEtat);
            tableau.Rows.Clear();
            mettreAjour.find(tableau);
            this.Close();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.etatTableAdapter1.FillBy(this.bddGestServKestCourcDataSet.etat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
    }
}
