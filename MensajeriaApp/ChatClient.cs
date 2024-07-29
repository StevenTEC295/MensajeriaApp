using System;
using System.Net.Sockets;
using System.Text;

public class ChatClient
{
    private readonly int targetPort;

    public ChatClient(int targetPort)
    {
        this.targetPort = targetPort;
    }

    public void SendMessage(string message)
    {
        using (TcpClient client = new TcpClient("localhost", targetPort))
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
        }
    }
}
