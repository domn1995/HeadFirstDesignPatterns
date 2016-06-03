namespace Remote
{
    public class LivingRoomLightOffCommand : ICommand
    {
        private readonly Light light;

        public LivingRoomLightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
