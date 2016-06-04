namespace StarBuzz
{
    public class HouseBlend : Beverage
    {
        public override double Cost => 0.89;

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
    }
}