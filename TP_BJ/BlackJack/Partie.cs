using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie
{
	public class Partie
	{
		Joueurs[] TJoueur;
		Paquet paquet;//paquet
		PartieForm formPartie;

		public Partie(int nbJoueur) // Constructeur pour host
		{
			TJoueur = new Joueurs[nbJoueur];
			paquet = new Paquet(2);
			formPartie = new PartieForm();
			formPartie.Show();
		}

		public Partie()//Counstrusteur pour client
		{
			TJoueur = new Joueurs[4];
			formPartie = new PartieForm();
			formPartie.Show();
		}

		public void RecevoirNomJoueur()
		{
			
		}
		public void EnvoyerCarte()
		{

		}
		public void RecevoirCarte()
		{

		}
	}
}
