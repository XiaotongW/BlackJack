using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace BlackJack
{
	class Net
	{
		const int Port = 8000;
		static TcpListener listener;
		TcpClient client;
		NetworkStream nsFlux;
		Socket socketClient;
		StreamReader readJ2, readJ3, readJ4; // Reader Serveur
		StreamWriter writeJ2, writeJ3, writeJ4; // Writer Serveur
		StreamReader reader; // Reader Client
		StreamWriter writer; // writer Client
		IPAddress AddrIP;
		string stringIP;
		int NbJoueur;
		int IDJoueur;
		bool IsHost;

		public Net(int nbJoueurs) // Crée Host
		{
			IsHost = true;
			NbJoueur = nbJoueurs;
			listener = new TcpListener(IPAddress.Any, Port);
			listener.Start();
			ID = 1;
			int nbConnect = 2;

			while (nbConnect != NbJoueur+1) // Boucle jusqu'a ce que tous les joueur soient connecter 
			{
				socketClient = listener.AcceptSocket();
				if (socketClient.Connected)
				{
					nsFlux = new NetworkStream(socketClient);
					switch (nbConnect)
					{
						case 2:
							readJ2 = new StreamReader(nsFlux);
							writeJ2 = new StreamWriter(nsFlux);
							envoyerMessage(nbConnect.ToString(), nbConnect); // Envoi L'ID au joueur 2
							break;
						case 3:
							readJ3 = new StreamReader(nsFlux);
							writeJ3 = new StreamWriter(nsFlux);
							envoyerMessage(nbConnect.ToString(), nbConnect); // Envoi L'ID au joueur 3
							break;
						case 4:
							readJ4 = new StreamReader(nsFlux);
							writeJ4 = new StreamWriter(nsFlux);
							envoyerMessage(nbConnect.ToString(), nbConnect); // Envoi L'ID au joueur 4
							break;
					}
					nbConnect++;
				}
			}
		}
		public Net(string IPaddr) // crée Client
		{
			try
			{
				IP = IPaddr;
				client = new TcpClient(stringIP, Port);
				IsHost = false;
				nsFlux = client.GetStream();
				reader = new StreamReader(nsFlux);
				writer = new StreamWriter(nsFlux);
				int.TryParse(recevoirMessage(), out IDJoueur);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public bool Hosting
		{
			get { return IsHost; }
		}

		public int ID
		{
			set { IDJoueur = value; }
			get { return IDJoueur; }
		}

		public string IP
		{
			set
			{
				stringIP = value;
				AddrIP = IPAddress.Parse(stringIP);
			}
		}

		public void envoyerMessage(string message, int IDJoueur)
		{
			// Envoyer Message pour le Serveur à un Client.
			try
			{
				switch (IDJoueur)
				{
					case 2:
						writeJ2.WriteLine(message);
						writeJ2.Flush();
						break;
					case 3:
						writeJ3.WriteLine(message);
						writeJ3.Flush();
						break;
					case 4:
						writeJ4.WriteLine(message);
						writeJ4.Flush();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void envoyerMessage(string message)
		{
			// Envoyer Message du client à l'Host
			try
			{
				writer.WriteLine("{0},{1}", IDJoueur, message);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
				writer.Close();
			}
			finally
			{
				writer.Flush();
			}
		}
		public string recevoirMessage(int IDJoueur)
		{
			// Reception de message pour le Serveur d'un client
			string leMessage = "";
			try
			{
				switch (IDJoueur)
				{
					case 2:
						leMessage = readJ2.ReadLine();
						break;
					case 3:
						leMessage = readJ3.ReadLine();
						break;
					case 4:
						leMessage = readJ4.ReadLine();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return leMessage;
		}
		public string recevoirMessage()
		{
			// Reception de message pour le client
			string leMessage = "";
			try
			{
				leMessage = reader.ReadLine();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				reader.Close();
			}
			MessageBox.Show(leMessage);
			return leMessage;
		}
	}
}
