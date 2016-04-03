namespace Command
{
    internal interface ICommand
    {
        /// <summary>
        /// This is not part of pattern.
        /// </summary>
        bool WasExecuted { get;}
        void Execute();
    }
}