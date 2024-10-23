
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;


TcpListener listener = new TcpListener(IPAddress.Any, 7);
listener.Start();

while (true) ;
{
	TcpClient socket = listener.AcceptTcpClient();
	IPEndPoint externalEndPoint = socket.Client.RemoteEndPoint as IPEndPoint;

	Task.Run(() => HandleClient(socket));
}

void HandleClient(TcpClient socket)
{
	//[Klassen] [Angivet instans af NS] = [Angivet instanst af socket] [Metode til at give/få strøm af data]
	NetworkStream networkStream = socket.GetStream();

	StreamReader reader = new StreamReader(networkStream);
	StreamWriter writer = new StreamWriter(networkStream);

	try
	{
		while (socket.Connected)
		{

			string? commandresponse = reader.ReadLine();

			if (commandresponse == null) break;

			writer.WriteLine("Insert numbers");
			writer.Flush();

			string? numberInput = reader.ReadLine();
			if (numberInput == null) break;

			string[] numbers

		}
	}

}

