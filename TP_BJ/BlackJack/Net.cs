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
		TcpListener listener;
		TcpClient client;
		NetworkStream nsFlux;
		Socket socketClient;
		StreamReader readJ2, readJ3, readJ4;
		StreamWriter writeJ2, writeJ3, writeJ4;
		IPAddress AddrIP;
		string stringIP;
		int NbJoueur;
		bool IsHost;

		public Net(bool IsHost, int IDJoueurs)
		{
			listener = new TcpListener(IPAddress.Any, Port);

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
			for (int i = 2; i <= nbJoueurs; i++)
			{
				listener.Start();
				client = listener.AcceptTcpClient();
				switch (i)
				{
					case 2:
						writeJ2 = new StreamWriter(nsFlux);
						readJ2 = new StreamReader(nsFlux);
						break;
					case 3:
						writeJ3 = new StreamWriter(nsFlux);
						readJ3 = new StreamReader(nsFlux);
						break;
					case 4:
						writeJ4 = new StreamWriter(nsFlux);
						readJ4 = new StreamReader(nsFlux);
						break;
				}
			}
		}

		public void envoyerMessage(string message, int IDJoueur)
		{
			// envoi une message à une joueur/personne
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
			catch
			{

			}

			return leMessage;
		}
	}
}
