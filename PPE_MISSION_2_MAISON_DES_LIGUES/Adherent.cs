using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    class Adherent
    {
        private Int32 num;
        private String nomAdherent;
        private Int32 idLigue;
        private Int32 idGrade;
        private String login;
        private String mdp;

        public Adherent(Int32 pNum, String pNomAdherent, Int32 pIdLigue, Int32 pIdGrade, String pLogin, String pMdp)
        {
            num = pNum;
            nomAdherent = pNomAdherent;
            idLigue = pIdLigue;
            idGrade = pIdGrade;
            login = pLogin;
            mdp = pMdp;
        }

        public Int32 getNum()
        {
            return (num);
        }


        public String getNomAdherent()
        {
            return (nomAdherent);
        }

        public Int32 getIdLigue()
        {
            return (idLigue);
        }

        public Int32 getIdGrade()
        {
            return (idGrade);
        }

        public String getLogin()
        {
            return (login);
        }

        public String getMdp()
        {
            return (mdp);
        }

        public void setNomAdherent(String pUnNom)
        {
            pUnNom = nomAdherent;
        }

        public void setLogin(String pLogin)
        {
            pLogin = login;
        }
        public void setMdp(String pMdp)
        {
            pMdp = mdp;
        }
    }
}
