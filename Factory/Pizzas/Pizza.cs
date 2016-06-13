using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzas
{
    public abstract class Pizza
    {
        protected List<string> toppings = new List<string>();
        protected string dough;
        protected string sauce;
        public string Name { get; set; }

        public void Prepare() => Console.WriteLine($"Preparing {Name}");
        public void Bake() => Console.WriteLine($"Baking {Name}");
        public void Cut() => Console.WriteLine($"Cutting {Name}");
        public void Box() => Console.WriteLine($"Boxing {Name}");
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---- {Name} ----\n");
            sb.AppendLine($"{dough}\n");
            sb.AppendLine($"{sauce}\n");
            foreach (string topping in toppings)
            {
                sb.AppendLine($"{topping}\n");
            }
            return sb.ToString();
        }
    }
}