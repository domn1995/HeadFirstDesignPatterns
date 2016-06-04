namespace Remote
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.CdMode();
            stereo.Volume = 11;
        }
    }
}
