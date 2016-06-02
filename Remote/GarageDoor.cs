using System;

namespace Remote
{
    public class GarageDoor
    {
        public enum GarageDoorState { Up, Down, Stopped }
        public GarageDoorState DoorState { get; private set; }
        public enum LightState { On, Off }
        public LightState State { get; private set; }

        private readonly string location;

        public GarageDoor(string location)
        {
            this.location = location;
        }

        public void Up()
        {
            DoorState = GarageDoorState.Up;
            Console.WriteLine($"{location} garage door is {DoorState}.");
        }

        public void Down()
        {
            DoorState = GarageDoorState.Down;
            Console.WriteLine($"{location} garage door is {DoorState}.");
        }

        public void Stop()
        {
            DoorState = GarageDoorState.Stopped;
            Console.WriteLine($"{location} garage door is {DoorState}.");
        }

        public void LightOn()
        {
            State = LightState.On;
            Console.WriteLine($"{location} garage light is {State}.");
        }

        public void LightOff()
        {
            State = LightState.Off;
            Console.WriteLine($"{location} garage light is {State}.");
        }
    }
}