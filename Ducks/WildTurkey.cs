namespace Ducks
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            System.Console.WriteLine("Gobble gobble.");
        }

        public void Fly()
        {
            System.Console.WriteLine("I'm flying a short distance.");
        }
    }
}