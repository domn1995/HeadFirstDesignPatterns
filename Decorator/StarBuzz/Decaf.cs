namespace StarBuzz
{
    public class Decaf : Beverage
    {
        public override double Cost => 1.05;

        public Decaf()
        {
            Description = "Decaf Coffee";
        }
    }
}