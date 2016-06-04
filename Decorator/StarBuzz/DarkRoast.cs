namespace StarBuzz
{
    public class DarkRoast : Beverage
    {
        public override double Cost => 0.99;

        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }
    }
}