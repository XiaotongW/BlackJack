using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   class Main
   {
        List<Cartes> listCarte;
        public Main()
        {
            listCarte = new List<Cartes>();
        }

        public void ajouterCarte(int figure, string type)
        {
            if (listCarte.Count < 5)
                listCarte.Add(new Cartes(type,figure,calculerSomme()));
            
        }
        public int calculerSomme()
        {
                int somme = 0;
                for (int i= 0; i < listCarte.Count; i++)
                {
                    somme = listCarte.ElementAt<Cartes>(i).Valeur;
                }
            return somme;
        }
        public void resetMain()
        {
            listCarte.Clear();
        }
   }
}
