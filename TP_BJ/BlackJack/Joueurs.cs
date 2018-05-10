using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlackJack
{
	public class Joueurs
	{

		public Joueurs(string nom)
		{
			Nom = nom;
			Main = new Main();
		}

		public string Nom
		{
			get;
			set;
		}

		public int ID
		{
			get { return netJoueur.ID; }
		}

		public Net netJoueur
		{
			get;
			private set;
		}

		public Main Main
		{
			get;
			private set;
		}

		public void JoindrePartie(string IPJoin)
		{
			Thread threadJoin = new Thread(() => creeConnection(IPJoin));
		}

		private void creeConnection(string IPJoin)
		{
			netJoueur = new Net(IPJoin);
		}
	}
}
