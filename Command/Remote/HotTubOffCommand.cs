namespace Remote
{
    public class HotTubOffCommand : ICommand
    {
        private readonly HotTub hotTub;

        public HotTubOffCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void Execute()
        {
            hotTub.Cool();
            hotTub.Off();
        }
    }
}