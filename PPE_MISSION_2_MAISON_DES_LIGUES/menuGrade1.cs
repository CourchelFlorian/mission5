﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    public partial class menuGrade1 : Form
    {
        private Form menuConnexion;
        public menuGrade1()
        {
            InitializeComponent();
        }
        public menuGrade1(Form pForm)//autre constructeur avec le formulaire de connexion en paramètre
        {
            InitializeComponent();
            menuConnexion = pForm;//attribution du menuConnexion passé en param
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ServiceDemandeDAO find = new ServiceDemandeDAO();
            find.find(dataGridView1);
        }

        private void menuGrade1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet3.etat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etatTableAdapter.Fill(this.m2l_Marco_SalimDataSet3.etat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facture factureForm = new Facture(menuConnexion, this);
            factureForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//sur le double clique de la case du tableau
        {
            //MessageBox.Show(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]));
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = comboBox1.SelectedValue;
            //MessageBox.Show("" + e.ColumnIndex);
            if ((e.ColumnIndex == 1) && ((String)dataGridView1.Rows[e.RowIndex].Cells[1].Value!="FACTURER"))//double-clique sans action si valeur = réalisé
            {
                //if
                int idServiceDemande = (int)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                int idEtat = (int)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                FormulaireModif monForm = new FormulaireModif(idServiceDemande, idEtat, dataGridView1);
                monForm.Show();
            }
        }

        private void btnDeco_Click(object sender, EventArgs e)//sur le clique du bouton deco
        {
            menuConnexion.Show();//on montre le menu de connexion  
            this.Close();//on ferme le menu actuel
        }
    }
}
