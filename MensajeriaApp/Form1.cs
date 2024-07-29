namespace MensajeriaApp
{
    public partial class Form1 : Form
    {
        private ChatServer chatServer;
        private ChatClient chatClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int targetPort = int.Parse(txtTargetPort.Text);
            chatClient = new ChatClient(targetPort);
            string message = txtMessage.Text;
            chatClient.SendMessage(message);
            AppendMessage($"Enviado: {message}");
            txtMessage.Clear();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int listenPort = int.Parse(txtListenPort.Text);
            chatServer = new ChatServer(listenPort, OnMessageReceived);
            chatServer.Start();
            AppendMessage($"Servidor iniciado en el puerto {listenPort}");
        }
        private void OnMessageReceived(string message)
        {
            Invoke(new Action(() => AppendMessage($"Recibido: {message}")));
        }
        private void AppendMessage(string message)
        {
            txtMessages.AppendText(message + Environment.NewLine);
        }
    }
}
