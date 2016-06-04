namespace Remote
{
    public class RemoteControl
    {
        private const int REMOTE_SIZE = 7;
        private readonly ICommand[] onCommands;
        private readonly ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[REMOTE_SIZE];
            offCommands = new ICommand[REMOTE_SIZE];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < REMOTE_SIZE; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot) => onCommands[slot].Execute();
        public void OffButtonWasPushed(int slot) => offCommands[slot].Execute();

        public override string ToString()
        {
            string s = "\n------ Remote Control ------\n";
            for (int i = 0; i < REMOTE_SIZE; i++)
            {
                s += $"[slot {i}] {onCommands[i].GetType().Name}      {offCommands[i].GetType().Name}\n";
            }
            return s;
        }
    }
}
