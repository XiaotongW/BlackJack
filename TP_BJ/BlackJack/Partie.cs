using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	public class Partie
	{
		Joueurs[] TJoueur;
		Paquet paquet;//paquet
		PartieForm formPartie;
		int JoueurTour;
		public delegate void RecevoirNom(string nomJoueur);
		public RecevoirNom NomJoueur;

		public Partie(int nbJoueur, int nbPaquet, int Min, int Max, int ArgentDebut) // Constructeur pour host
		{
			TJoueur = new Joueurs[nbJoueur];
			paquet = new Paquet(nbPaquet);
			JoueurTour = 1;
			formPartie = new PartieForm(this);
			formPartie.Show();
		}

		public Partie()//Counstrusteur pour client
		{
			TJoueur = new Joueurs[4];
			for (int i=0; i < 4; i++)
			{
				TJoueur[i] = null;
			}
			formPartie = new PartieForm(this);
			formPartie.Show();
		}

		public void RecevoirNomJoueur(string Nom)
		{
			//IDJoueur;Nom Joueur
			String[] nomJoueur = Nom.Split(new char[1] { ';' });
			TJoueur[int.Parse(nomJoueur[0])].Nom = nomJoueur[1];
		}
		public void distribuerInfo(int IDReception, int Next, string message)
		{
			do
			{
				//TJoueur[Next].
			} while (Next != IDReception);
		}
		public void RecevoirCarte(string carteRecut)
		{
			string[] infoCarte; // message : IDJoueur;figureCarte;typeCarte
			infoCarte = carteRecut.Split(new char[1] { ';' });
			TJoueur[int.Parse(infoCarte[0])].main.ajouterCarte(int.Parse(infoCarte[1]), infoCarte[2]);
		}
	}
}
