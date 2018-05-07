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
		//StreamReader readJ2, readJ3, readJ4;
		//StreamWriter writeJ2, writeJ3, writeJ4;
		StreamReader reader;
		StreamWriter writer;
		IPAddress AddrIP;
		string stringIP;
		int NbJoueur;
		bool IsHost;
		int IDJoueur;

		public Net(bool IsHost, int nbJoueurs)
		{
			listener = new TcpListener(IPAddress.Any, Port);
			listener.Start();
			socketClient = listener.AcceptSocket();
			if (socketClient.Connected)
			{
				nsFlux = new NetworkStream(socketClient.Accept());
				reader = new StreamReader(nsFlux);
				writer = new StreamWriter(nsFlux);
			}

			this.IsHost = IsHost;
			NbJoueur = nbJoueurs;
		}
		public Net()
		{

			try
			{
				client = new TcpClient(stringIP, Port);
				IsHost = false;
				nsFlux = client.GetStream();
				reader = new StreamReader(nsFlux);
				writer = new StreamWriter(nsFlux);

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

		public void Host(int nbJoueurs)
		{

		}

		public void envoyerMessage(string message, int IDJoueur)
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

		public string recevoirMessage(int IDJoueur)
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

			return leMessage;
		}
	}
}
