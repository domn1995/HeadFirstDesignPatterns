namespace Ducks
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack.");
        }

        public void Fly()
        {
            System.Console.WriteLine("I'm flying.");
        }
    }
}