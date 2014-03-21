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
    class ServiceDemandeDAO
    {
        public Boolean create(int idAdherent, int idService, string dateDemande, string heure, string min)
        {
            Boolean DemandeLibre = true;
            string[] split = dateDemande.Split(new Char[] { ' ' });
            string date = split[0];
            string newDate = date + " " + heure + ":" + min;
            SqlCommand maRequete;
            SqlCommand existeDeja;
            // La requête compte le nombre de lignes 
            string requete = "SELECT COUNT(*) AS nb FROM serviceDemande WHERE idAdherent = " + idAdherent + " AND dateDemande ='" + newDate + "' AND idService = " + idService;
            string sqlStr = "INSERT INTO serviceDemande (idAdherent, idService, dateDemande) VALUES(" + idAdherent + "," + idService + ",'" + newDate + "')";
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=bddGestServKestCourc ;User ID=sio2slam ;Password=";
            SqlConnection maConnexion;
            try
            {
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);

                // Création d'un objet SqlCommand
                existeDeja = new SqlCommand(requete, maConnexion);
                // Ce sera du texte
                existeDeja.CommandType = CommandType.Text;
                // Execution de la requête (reader car SELECT)
                SqlDataReader verifDate = existeDeja.ExecuteReader();

                // Si la requête retourne quelque chose 
                if (verifDate.Read()) // If car une seule ligne retournée
                {
                    // On récupère le nombre de ligne
                    int nb = (int)verifDate["nb"];
                    // Si la ligne existe déjà on affiche une erreur
                    if (nb >= 1)
                    {
                        DemandeLibre = false;
                        MessageBox.Show("La demande a déjà été demandée");
                    }
                    else
                    {
                        // On ferme la requête sinon l'insertion ne fonctionne pas
                        verifDate.Close();
                        // On exécute la requête d'insertion
                        maRequete.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {

            }
            return DemandeLibre;
        }

        public DataGridView find(DataGridView pTableau)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT adherent.nomAdherent, etat.libelleEtat, etat.id AS idEtat, typeService.libelleService, typeService.prix, serviceDemande.dateDemande, serviceDemande.id AS idServiceDemande, adherent.id AS Expr1, etat.id AS Expr2, typeService.id AS Expr3 FROM serviceDemande INNER JOIN adherent ON serviceDemande.idAdherent = adherent.id INNER JOIN etat ON serviceDemande.idEtat = etat.id INNER JOIN typeService ON serviceDemande.idService = typeService.id";
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=bddGestServKestCourc ;User ID=sio2slam ;Password=";
            SqlConnection maConnexion;
            try
            {

                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                while (unJeuResultat.Read()) // lecture d’une ligne
                {
                    pTableau.Rows.Add((string)unJeuResultat["nomAdherent"], (string)unJeuResultat["libelleEtat"], (string)unJeuResultat["libelleService"], (string)unJeuResultat["prix"], (DateTime)unJeuResultat["dateDemande"], (int)unJeuResultat["Expr3"], (int)unJeuResultat["Expr1"], (int)unJeuResultat["idServiceDemande"], (int)unJeuResultat["idEtat"]);
                }

            }
            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return pTableau;
        }

        public Boolean update(int idSericedemande,int idEtat)
        {
            
            SqlCommand maRequete;
            string sqlStr = "UPDATE serviceDemande SET idEtat = "+idEtat+" WHERE (id = "+idSericedemande+")";
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=bddGestServKestCourc ;User ID=sio2slam ;Password=";
            SqlConnection maConnexion;
            try
            {
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;

                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            return true;
        }

        public DataGridView factureEdit(DataGridView pTableau,int mois,int annee)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT ligue.id AS idLigue, ligue.libelleLigue AS nomLigue, adherent.nomAdherent, etat.libelleEtat, typeService.libelleService, typeService.prix, serviceDemande.dateDemande FROM adherent INNER JOIN serviceDemande ON adherent.id = serviceDemande.idAdherent INNER JOIN typeService ON serviceDemande.idService = typeService.id INNER JOIN ligue ON adherent.idLigue = ligue.id INNER JOIN etat ON serviceDemande.idEtat = etat.id WHERE (MONTH(serviceDemande.dateDemande) = " + mois + ") AND (etat.id = 1) AND (YEAR(serviceDemande.dateDemande) = " + annee + ")";
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=bddGestServKestCourc ;User ID=sio2slam ;Password=";
            SqlConnection maConnexion;
            try
            {

                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                bool bReturn = unJeuResultat.Read();
                while (bReturn) // lecture d’une ligne
                {
                    double total = 0;
                    int idLigue = (int)unJeuResultat["idLigue"];
                    while (bReturn==true && (int)unJeuResultat["idLigue"] == idLigue)
                    {
                        pTableau.Rows.Add((string)unJeuResultat["nomLigue"], (string)unJeuResultat["nomAdherent"], (string)unJeuResultat["libelleEtat"], (string)unJeuResultat["libelleService"], (string)unJeuResultat["prix"]);
                        total += Convert.ToDouble((string)unJeuResultat["prix"]);
                        bReturn = unJeuResultat.Read();
                        
                    }
                    pTableau.Rows.Add("", "", "", "", total);
                    pTableau.Rows.Add();
                }
            }
            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return pTableau;
        }

        public ComboBox remplirCombo(ComboBox cmbAnne)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT DISTINCT YEAR(dateDemande) AS annee FROM serviceDemande";
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=bddGestServKestCourc ;User ID=sio2slam ;Password=";
            SqlConnection maConnexion;
            try
            {
                int i = 0;
                int annee;
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                while (unJeuResultat.Read()) // lecture d’une ligne
                {
                    annee = (int)unJeuResultat["annee"];
                    cmbAnne.Items.Insert(i,annee);
                    cmbAnne.SelectedIndex = i;
                    i++;
                    
                }

            }


            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return cmbAnne;
        }
    }
}
