using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie
{
   class Paquet
   {
     
        int nbPaquet;
        List<Cartes> listPaquet;
        Random rand; 
        public Paquet(int p_nbPaquet)
        {
            nbPaquet = p_nbPaquet;
            listPaquet = new List<Cartes>();
            rand = new Random(DateTime.Now.Millisecond); //seed pour la carte piger
            creerLesPaquets();
        }
        public void creerLesPaquets()
        {
            for (int indPaquet = 0; indPaquet < nbPaquet; indPaquet++)
            {
                creerUnPaquet();
            }
        }
        public void creerUnPaquet()
        {
            for (int indFig = 1; indFig <= 13; indFig++)//boucle sur les figures
            {
                listPaquet.Add(new Cartes("Coeur", indFig));
                listPaquet.Add(new Cartes("Carreaux", indFig));
                listPaquet.Add(new Cartes("Trefle", indFig));
                listPaquet.Add(new Cartes("Pique", indFig));
            }
        }
        public Cartes PigerCarte()
        {
            int indRand = rand.Next(52 * nbPaquet);
            Cartes TmpCarte = listPaquet.ElementAt<Cartes>(indRand);
            listPaquet.RemoveAt(indRand);
            return TmpCarte;
        }
   }
}
