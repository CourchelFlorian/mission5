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
    public partial class Facture : Form
    {
        private Form menuConnexion;
        private Form menuGrade1;
        ServiceDemandeDAO factureEditer = new ServiceDemandeDAO();
        int ligue;
        int mois;
        int annee;
        public Facture()
        {
            InitializeComponent();
        }

        public Facture(Form pForm, Form pMenuGrade1)
        {
            InitializeComponent();
            menuGrade1 = pMenuGrade1;
            menuConnexion = pForm;
        }

        public Facture(Form pForm)
        {
            InitializeComponent();
            menuConnexion = pForm;
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet5.ligue'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligueTableAdapter.Fill(this.m2l_Marco_SalimDataSet5.ligue);
            for (int i=0;i <12;i ++)
            {
                DateTime date = new DateTime(2002, i+1, 2); // DATE AU HASARD SAUF POUR LE MOIS
                comboMois.Items.Insert(i,date.ToString("MMMM" ));
                comboMois.SelectedIndex = 0;
            }
            factureEditer.remplirCombo(comboAnnee);
        }

        private void comboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        private void comboAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        public void actualiserTableauFacture()
        {
            mois = comboMois.SelectedIndex + 1;
            annee = Convert.ToInt16(comboAnnee.SelectedItem);
            dataGridView1.Rows.Clear();
            factureEditer.factureEdit(dataGridView1, mois, annee);
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            menuConnexion.Show();
            this.Close();
        }

        private void Facture_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuGrade1.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            factureEditer.factureUpdate(mois, annee);
            actualiserTableauFacture();
            /*bool toto = Convert.ToBoolean(printDialog1.ShowDialog());
            if (toto==true)
            {
                MessageBox.Show("canard");
                //printDocument1.Print();
            }*/
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                //printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dataGridView1, myPaintArgs);
        }
    }
}
