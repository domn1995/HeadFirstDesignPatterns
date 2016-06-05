namespace StarBuzz
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;
        public override string Description => $"{beverage.Description}, Whip";
        public override double Cost => 0.10 + beverage.Cost;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}