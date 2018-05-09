using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie
{
   
   class Joueurs
   {
        string nomJoueur;
        //string idJoueur;
        Main mainJoueur;
		Net Network;
        public Joueurs(string nom)
        {
            nomJoueur = nom;
			//idJoueur = id;
			//Network = new Net();
            mainJoueur = new Main();
        }
    }
}
