using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    class Ligue
    {
        private Int32 numLigue;
        private String libelleLigue;

        public Ligue(Int32 pNumLigue, String pLibelleLigue)
        {
            numLigue = pNumLigue;
            libelleLigue = pLibelleLigue;
        }

        private Int32 getNumLigue()
        {
            return (numLigue);
        }

        private String getLibelleLigue()
        {
            return (libelleLigue);
        }
        private void setLibelleLigue(String pLibelle)
        {
            pLibelle = libelleLigue;
        }
    
    }
}
