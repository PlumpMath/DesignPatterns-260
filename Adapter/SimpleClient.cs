namespace Adapter
{
    internal class SimpleClient
    {
        private ComplexClient oldClient;
        public bool IsConnected { get { return oldClient.Connected; } }

        public SimpleClient()
        {
            this.oldClient = new ComplexClient();
        }

        public void SimpleConnect()
        {
            oldClient.Channel = 10;
            oldClient.ConnectUsingPassword("admin", "admin");
        }
    }
}