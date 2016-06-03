namespace Remote
{
    public class LivingRoomLightOnCommand : ICommand
    {
        private readonly Light light;

        public LivingRoomLightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}