namespace Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            dough = "Thin Crust";
            sauce = "White Garlic Sauce";
            toppings.Add("Clams");
            toppings.Add("Grated Parmesan Cheese");
        }
    }
}