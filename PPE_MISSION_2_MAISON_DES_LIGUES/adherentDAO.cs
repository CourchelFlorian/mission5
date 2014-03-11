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
    class adherentDAO
    {
        conexion conect = new conexion();

        public bool verifUtilisateur(string login,string mdp,out int pGrade, out int pId)
        {
            bool Verif = false;
            pGrade = 888;
            pId = 0;
            try
            {
                string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=m2l_Marco_Salim ;User ID=sio2slam ;Password=";
                SqlConnection maConnexion;
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();
                SqlCommand maCommande;
                string sqlStr = "select * from adherent where login='" + login + "' AND mdp='" +mdp + "'";
                maCommande = new SqlCommand(sqlStr, maConnexion);
                maCommande.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maCommande.ExecuteReader();
                if (unJeuResultat.Read()) // lecture d’une ligne
                {
                    Verif = true;
                    pGrade = (int)unJeuResultat["idGrade"];
                    pId = (int)unJeuResultat["id"];
                }
                else
                {
                    Verif = false;
                }
            }
            catch (Exception ex)
            {

            }
            return Verif;
        }

       
        }
        
    }

