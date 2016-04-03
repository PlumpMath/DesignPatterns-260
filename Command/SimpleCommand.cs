namespace Command
{
    internal class SimpleCommand : ICommand
    {
        public bool WasExecuted { get; set; }
        public void Execute()
        {
            WasExecuted = true;
        }
    }
}