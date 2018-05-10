//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net.Sockets;
//using System.Net;
//using System.IO;
//using System.Windows.Forms;

namespace BlackJack
{ // A retirer du projet
	class NetClient
	{
		//	const int Port = 8000;
		//	TcpClient Client;
		//	StreamReader readClient;
		//	StreamWriter writeClient;
		//	NetworkStream nsClient;
		//	IPAddress AddrIP;
		//	string stringIP;

		//	public NetClient()
		//	{

		//	}
		//	public string IP
		//	{
		//		set
		//		{
		//			stringIP = value;
		//			AddrIP = IPAddress.Parse(stringIP);
		//		}
		//	}
		//	public void joindre()
		//	{
		//		try
		//		{
		//			IPEndPoint ipEnd = new IPEndPoint(AddrIP, Port);
		//			Client = new TcpClient(stringIP, Port);
		//			nsClient = Client.GetStream();
		//		}
		//		catch
		//		{
		//			MessageBox.Show("Failed to connect to server at" + stringIP);
		//		}
		//	}

		//	public void envoyerMessage(string message)
		//	{
		//		writeClient = new StreamWriter(nsClient);
		//		writeClient.WriteLine(message);
		//		writeClient.Flush();
		//	}

		//	public string recevoirMessage()
		//	{
		//		string leMessage = "";
		//		if (nsClient != null)
		//		{
		//			readClient = new StreamReader(nsClient);
		//			leMessage = readClient.ReadLine();
		//		}
		//		return leMessage;

		//	}
	}
}
