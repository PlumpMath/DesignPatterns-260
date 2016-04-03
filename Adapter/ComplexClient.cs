namespace Adapter
{
    internal class ComplexClient : IOldInterface
    {
        public ComplexClient()
        {
        }

        public bool Connected { get; private set; }

        public void ConnectUsingPassword(string key, string password)
        {
            Connected = key == "admin" && password == "admin" && (Channel == 10 || Channel == 12);
        }

        public int Channel { get; set; }
    }
}