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
        string idJoueur;
        Main mainJoueur;
        public Joueurs(string nom, string id)
        {
            nomJoueur = nom;
            idJoueur = id;
            mainJoueur = new Main();
        }
    }
}
