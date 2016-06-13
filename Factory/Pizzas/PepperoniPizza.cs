namespace Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            dough = "Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Sliced Onion");
            toppings.Add("Grated Parmesan Cheese");
        }
    }
}