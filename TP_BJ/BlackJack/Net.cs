using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Partie
{
	class Net
	{
		const int Port = 8000;
		TcpListener Listener1, Listener2, Listener3, Listener4;
		TcpClient Client;
		NetworkStream nsClient, nsJ1, nsJ2, nsJ3, nsJ4;
		Socket socketJ1, socketJ2, socketJ3, socketJ4;
		StreamReader readJ1, readJ2, readJ3, readJ4;
		StreamWriter writeJ1, writeJ2, writeJ3, writeJ4;
		IPAddress AddrIP;
		string stringIP;
		int NbJoueur;

		public Net(int nombreJoueur)
		{
			NbJoueur = nombreJoueur;
		}
		public Net()
		{
			NbJoueur = 1;
		}
		public string IP
		{
			set
			{
				stringIP = value;
				AddrIP = IPAddress.Parse(stringIP);
			}
		}

		public void Host(int nbJoueurs)
		{
			switch (i)
			{
				case 4:
					Listener4 = new TcpListener(AddrIP, Port);
					Listener4.Start()
					socketJ4 = Listener4.AcceptSocket();
					break;
				case 3:
					Listener3 = new TcpListener(AddrIP, Port);
					socketJ3 = Listener3.AcceptSocket();
					break;
				case 2:
					Listener2 = new TcpListener(AddrIP, Port);
					socketJ2 = Listener2.AcceptSocket();
					break;
				case 1:
					Listener1 = new TcpListener(AddrIP, Port);
					socketJ1 = Listener1.AcceptSocket();
					break;
			}
		}
		public void envoyerTous(string message)
		{
			// envoie un message à tous les joueurs
			try
			{
				writeJ1 = new StreamWriter(nsJ1);
				writeJ1.WriteLine(message);
				writeJ1.Flush();
				writeJ2 = new StreamWriter(nsJ2);
				writeJ2.WriteLine(message);
				writeJ2.Flush();
				writeJ3 = new StreamWriter(nsJ3);
				writeJ3.WriteLine(message);
				writeJ3.Flush();
				writeJ4 = new StreamWriter(nsJ4);
				writeJ4.WriteLine(message);
				writeJ4.Flush();
			}
			catch
			{

			}
		}
		public void envoyerMessage(string message, int IDJoueur)
		{
			// envoi une message à une joueur/personne
			try
			{
				switch (IDJoueur)
				{
					case 1:
						writeJ1 = new StreamWriter(nsJ1);
						writeJ1.WriteLine(message);
						writeJ1.Flush();
						break;
					case 2:
						writeJ2 = new StreamWriter(nsJ2);
						writeJ2.WriteLine(message);
						writeJ2.Flush();
						break;
					case 3:
						writeJ3 = new StreamWriter(nsJ3);
						writeJ3.WriteLine(message);
						writeJ3.Flush();
						break;
					case 4:
						writeJ4 = new StreamWriter(nsJ4);
						writeJ4.WriteLine(message);
						writeJ4.Flush();
						break;
				}

			}
			catch
			{

			}
		}

		public string recevoirMessage(int IDJoueur)
		{
			string leMessage = "";
			try
			{
				switch (IDJoueur)
				{
					case 1:
						readJ1 = new StreamReader(nsJ1);
						leMessage = readJ1.ReadLine();
						break;
					case 2:
						readJ2 = new StreamReader(nsJ2);
						leMessage = readJ2.ReadLine();
						break;
					case 3:
						readJ3 = new StreamReader(nsJ3);
						leMessage = readJ3.ReadLine();
						break;
					case 4:
						readJ4 = new StreamReader(nsJ3);
						leMessage = readJ4.ReadLine();
						break;
				}
			}
			catch
			{

			}

			return leMessage;
		}
	}
}
