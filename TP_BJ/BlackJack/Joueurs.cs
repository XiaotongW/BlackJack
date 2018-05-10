using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Partie
{
<<<<<<< HEAD
   
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
=======

	class Joueurs
	{
		Main mainJoueur;
		Net netJoueur;
		public delegate void AjouterCarte();
		public AjouterCarte delegateAjoutCarte;

		public Joueurs(string nom)
		{
			Nom = nom;
			mainJoueur = new Main();
			delegateAjoutCarte = new AjouterCarte(recevoirCarte);
		}

		public string Nom
		{
			get;
			private set;
		}

		public int ID
		{
			get { return netJoueur.ID; }
		}

		public void JoindrePartie(string IPJoin)
		{
			Thread threadJoin = new Thread(() => creeConnection(IPJoin));
		}
		private void creeConnection(string IPJoin)
		{
			netJoueur = new Net(IPJoin);
		}

		public void recevoirCarte()
		{
			// Methode appeler par le deleger AjouterCarte
			string[] infoCarte; // message : IDJoueur;figureCarte;typeCarte
			infoCarte =  netJoueur.recevoirMessage().Split(new char[1] {';'});
			mainJoueur.ajouterCarte(int.Parse(infoCarte[1]),infoCarte[2]);
		}
	}
>>>>>>> 9c2c5961ecda68ce802e63ce9ebae2bacab5f2e0
}
