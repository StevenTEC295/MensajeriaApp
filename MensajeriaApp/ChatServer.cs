using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class ChatServer
{
    private readonly int listenPort;
    private readonly Action<string> onMessageReceived;

    public ChatServer(int listenPort, Action<string> onMessageReceived)
    {
        this.listenPort = listenPort;
        this.onMessageReceived = onMessageReceived;
    }

    public void Start()
    {
        Thread serverThread = new Thread(new ThreadStart(Run));
        serverThread.IsBackground = true;
        serverThread.Start();
    }

    private void Run()
    {
        TcpListener listener = new TcpListener(IPAddress.Any, listenPort);
        listener.Start();
        while (true)
        {
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            onMessageReceived(message);
        }
    }
}
