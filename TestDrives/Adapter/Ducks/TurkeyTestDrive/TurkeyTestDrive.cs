using System;
using Ducks;

namespace TurkeyTestDrive
{
    public static class TurkeyTestDrive
    {
        public static void Main()
        {
            MallardDuck duck = new MallardDuck();
            ITurkey duckAdapter = new DuckAdapter(duck);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }

            // Waits for the user to press a key before exiting the console window.
            Console.Read();
        }
    }
}