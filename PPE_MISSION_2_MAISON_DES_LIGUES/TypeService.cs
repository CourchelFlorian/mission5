using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    class TypeService
    {
        private Int32 id;
        private String libelleService;
        private Double prix;

        public TypeService(Int32 pId, String pLibelleService, Double pPrix)
        {
            id = pId;
            libelleService = pLibelleService;
            prix = pPrix;
        }

        public String getLibelle()
        {
            return (libelleService);
        }

        public Double getPrix()
        {
            return (prix);
        }

        public void setLibelle(String pLibelle)
        {
            pLibelle = libelleService;
        }
        public void setPrix(Double pPrix)
        {
            pPrix = prix;
        }

    }
}
