namespace StarBuzz
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage beverage;
        public override string Description => $"{beverage.Description}, Milk";
        public override double Cost => 0.10 + beverage.Cost;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}