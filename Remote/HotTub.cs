using System;

namespace Remote
{
    public class HotTub
    {
        private Boolean on;
        public int Temperature { get; set; }

        public HotTub() { }

        public void On() => on = true;
        public void Off() => on = false;

        public void BubblesOn()
        {
            if (on)
            {
                Console.WriteLine("Hot tub is bubbling!");
            }
        }

        public void BubblesOff()
        {
            if (on)
            {
                Console.WriteLine("Hot tub is not bubbling.");
            }
        }

        public void JetsOn()
        {
            if (on)
            {
                Console.WriteLine("Hot tub jets are on.");
            }
        }

        public void JetsOff()
        {
            if (on)
            {
                Console.WriteLine("Hot tub jets are off.");
            }
        }

        public void Heat()
        {
            Temperature = 105;
            Console.WriteLine($"Hot tub is heating to a steaming {Temperature} degrees.");
        }

        public void Cool()
        {
            Temperature = 98;
            Console.WriteLine($"Hot tub is cooling to {Temperature} degrees.");
        }
    }
}
