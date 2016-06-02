using System;

namespace Remote
{
    public class Stereo
    {
        private readonly string location;
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 || value <= 11)
                {
                    volume = value;
                }
                Console.WriteLine($"{location} stereo volume set to {volume}.");
            }
        }

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On() => Console.WriteLine($"{location} stereo is on.");
        public void Off() => Console.WriteLine($"{location} stereo is off.");
        public void CdMode() => Console.WriteLine($"{location} stereo is set for CD input.");
        public void DvdMode() => Console.WriteLine($"{location} stereo is set for DVD input.");
        public void RadioMode() => Console.WriteLine($"{location} stereo is set for radio mode.");
    }
}
