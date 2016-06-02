using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote
{
    public class CeilingFan
    {
        public enum FanLevel { Off, Low, Medium, High }
        private readonly string location;
        public FanLevel Level { get; private set; }

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void Off()
        {
            Level = FanLevel.Off;
            Console.WriteLine($"{location} ceiling fan is {Level}.");
        }

        public void Low()
        {
            Level = FanLevel.Low;
            Console.WriteLine($"{location} ceiling fan is on {Level}.");
        }

        public void Medium()
        {
            Level = FanLevel.Medium;
            Console.WriteLine($"{location} ceiling fan is on {Level}.");
        }

        public void High()
        {
            Level = FanLevel.High;
            Console.WriteLine($"{location} ceiling fan is on {Level}.");
        }
    }
}
