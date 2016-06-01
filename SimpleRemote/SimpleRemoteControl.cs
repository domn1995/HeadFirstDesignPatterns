namespace SimpleRemote
{
    /// <summary>
    /// This is the invoker.
    /// </summary>
    public class SimpleRemoteControl
    {
        private ICommand slot;
        public ICommand Command
        {
            set
            {
                slot = value;
            }
        }

        public SimpleRemoteControl() { }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}