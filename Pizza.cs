public class Pizza
{
    // Private instance variables
    private string size;
    private int cheeseToppings;
    private int pepperoniToppings;
    private int hamToppings;

    // Constructor(s) that set all of the instance variables
    public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
    {
        this.size = size;
        this.cheeseToppings = cheeseToppings;
        this.pepperoniToppings = pepperoniToppings;
        this.hamToppings = hamToppings;
    }

    // Properties using get and set methods
    public string Size
    {
        get { return size; }
        set { size = value; }
    }

    public int CheeseToppings
    {
        get { return cheeseToppings; }
        set { cheeseToppings = value; }
    }

    public int PepperoniToppings
    {
        get { return pepperoniToppings; }
        set { pepperoniToppings = value; }
    }

    public int HamToppings
    {
        get { return hamToppings; }
        set { hamToppings = value; }
    }

    // Method to calculate the cost of the pizza
    public double CalcCost()
    {
        double cost = 0;

        switch (size.ToLower())
        {
            case "small":
                cost = 10 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                break;
            case "medium":
                cost = 12 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                break;
            case "large":
                cost = 14 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                break;
            default:
                Console.WriteLine("Invalid size specified. Using default cost for small pizza.");
                cost = 10 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                break;
        }

        return cost;
    }

    // Method to get description of the pizza
    public string GetDescription()
    {
        return $"Pizza Size: {size}, Cheese Toppings: {cheeseToppings}, Pepperoni Toppings: {pepperoniToppings}, Ham Toppings: {hamToppings}";
    }
}
