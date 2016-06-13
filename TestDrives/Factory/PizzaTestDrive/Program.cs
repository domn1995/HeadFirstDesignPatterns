using System;
using Pizzas;

namespace PizzaTestDrive
{
    public static class PizzaTestDrive
    {
        public static void Main()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine($"We ordered a {pizza.Name}\n");
            Console.WriteLine(pizza);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine($"We ordered a {pizza.Name}\n");
            Console.WriteLine(pizza);

            // Prevents the console application from closing until it receives user input.
            Console.Read();
        }
    }
}