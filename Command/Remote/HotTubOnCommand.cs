namespace Remote
{
    public class HotTubOnCommand : ICommand
    {
        private readonly HotTub hotTub;

        public HotTubOnCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void Execute()
        {
            hotTub.On();
            hotTub.Heat();
            hotTub.BubblesOn();
        }
    }
}