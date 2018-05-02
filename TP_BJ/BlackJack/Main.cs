using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie
{
   class Main
   {
        List<Cartes> listCarte;
        public Main()
        {
            listCarte = new List<Cartes>();
        }

        public void ajouterCarte(Cartes newCarte)
        {
            if (listCarte.Count < 5)
            {
                listCarte.Add(newCarte);
            }
        }
        public void resetMain()
        {
            listCarte.Clear();
        }
   }
}
