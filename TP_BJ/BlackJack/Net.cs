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
		static TcpListener listener;
		TcpClient client;
		NetworkStream nsFlux;
		Socket socketClient;
		StreamReader readJ2, readJ3, readJ4;
		StreamWriter writeJ2, writeJ3, writeJ4;
		StreamReader reader;
		StreamWriter writer;
		IPAddress AddrIP;
		string stringIP;
		int NbJoueur;
		bool IsHost;
		int IDJoueur;

		public Net(bool IsHost, int nbJoueurs) // Crée Host
		{
			this.IsHost = IsHost;
			NbJoueur = nbJoueurs;
			listener = new TcpListener(IPAddress.Any, Port);
			listener.Start();
			int nbConnect = 1;
			do
			{
				socketClient = listener.AcceptSocket();
				nsFlux = new NetworkStream(socketClient);
				if (socketClient.Connected)
				{
					switch (nbConnect)
					{
						case 1:
							readJ2 = new StreamReader(nsFlux);
							writeJ2 = new StreamWriter(nsFlux);
							envoyerMessage((nbConnect + 1).ToString(), nbConnect + 1);
							break;
						case 2:
							readJ3 = new StreamReader(nsFlux);
							writeJ3 = new StreamWriter(nsFlux);
							envoyerMessage((nbConnect + 1).ToString(), nbConnect + 1);
							break;
						case 3:
							readJ4 = new StreamReader(nsFlux);
							writeJ4 = new StreamWriter(nsFlux);
							envoyerMessage((nbConnect + 1).ToString(), nbConnect + 1);
							break;
					}
					nbConnect++;
				}

			} while (nbConnect != NbJoueur);

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
			catch (Exception e)
			{

				MessageBox.Show(e.ToString());
			}

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

		public string recevoirMessage()
		{
			string leMessage = "";
			try
			{
				leMessage = reader.ReadLine();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
				reader.Close();
			}
			MessageBox.Show(leMessage);
			return leMessage;
		}
	}
}
