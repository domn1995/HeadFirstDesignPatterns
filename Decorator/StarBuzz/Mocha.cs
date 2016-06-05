namespace StarBuzz
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;
        public override string Description => $"{beverage.Description}, Mocha";
        public override double Cost => 0.2 + beverage.Cost;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}