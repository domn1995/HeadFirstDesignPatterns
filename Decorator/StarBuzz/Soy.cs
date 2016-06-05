namespace StarBuzz
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;
        public override string Description => $"{beverage.Description}, Soy";
        public override double Cost => 0.15 + beverage.Cost;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}