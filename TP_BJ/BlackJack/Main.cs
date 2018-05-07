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
                newCarte = new Cartes(newCarte.Type,newCarte.Valeur,calculerSomme());
                listCarte.Add(newCarte);
            }
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
