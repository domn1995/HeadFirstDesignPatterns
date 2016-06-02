using System;
using SimpleRemote;

namespace RemoteControlTest
{
    public static class RemoteControlTest
    {
        public static void Main()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.Command = lightOn;
            remote.ButtonWasPressed();
            remote.Command = garageOpen;
            remote.ButtonWasPressed();

            Console.Read();
        }
    }
}