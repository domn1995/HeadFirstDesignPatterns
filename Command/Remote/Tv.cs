using System;

namespace Remote
{
    public class Tv
    {
        public string Location { get; private set; }

        public string Channel { get; set; }

        public Tv(string location)
        {
            Location = location;
        }

        public void On() => Console.WriteLine("TV is on.");
        public void Off() => Console.WriteLine("TV is off.");
    }
}