namespace Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            dough = "Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Shredded Mozzarella");
            toppings.Add("Grated Parmesan");
            toppings.Add("Diced Onion");
            toppings.Add("Sliced Mushrooms");
            toppings.Add("Sliced Red Pepper");
            toppings.Add("Sliced Black Olives");
        }
    }
}