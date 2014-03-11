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
    public partial class menuGrade0 : Form
    {
        private int idadherent;
        public menuGrade0()
        {
            InitializeComponent();
        }
        public menuGrade0(int pId)
        {
            InitializeComponent();
            idadherent = pId;
        }
        


        private void buttDemanderService_Click(object sender, EventArgs e)
        {
            this.Size=new Size(319, 373);
            labelDate.Visible = true;
            calendrierService.Visible = true;
            labelService.Visible = true;
            comboService.Visible = true;
            buttValiderDemande.Visible = true;
            labelHeure.Visible = true;
            comboHeure.Visible = true;
            labelMin.Visible = true;
            comboMin.Visible = true;
        }

        private void menuGrade0_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet2.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter2.Fill(this.m2l_Marco_SalimDataSet2.typeService);
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet1.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter1.Fill(this.m2l_Marco_SalimDataSet1.typeService);
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter.Fill(this.m2l_Marco_SalimDataSet.typeService);
            for (int i = 0; i < 23; i++)
            {
                comboHeure.Items.Insert(i, i + 1);
            }
            for (int j = 0; j < 60; j++)
            {
                comboMin.Items.Insert(j, j + 1);
            }

        }

        private void buttValiderDemande_Click(object sender, EventArgs e)
        {
            string dateDeDemande;
            int service;
            dateDeDemande = calendrierService.Value.ToString();
            service = Convert.ToInt32(comboService.SelectedValue);
            ServiceDemandeDAO addService = new ServiceDemandeDAO();
            if (addService.create(idadherent, service, dateDeDemande, Convert.ToString(comboHeure.SelectedIndex + 1), Convert.ToString(comboMin.SelectedIndex + 1)))
            {
                MessageBox.Show("Le service à bien été demandé");
            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
    }
}
