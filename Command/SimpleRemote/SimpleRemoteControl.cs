namespace SimpleRemote
{
    /// <summary>
    /// This is the invoker.
    /// </summary>
    public class SimpleRemoteControl
    {
        private ICommand slot;
        public ICommand Command { get; set; }

        public SimpleRemoteControl() { }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}