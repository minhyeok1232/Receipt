public class Coffee
{
    public string Name { get; private set; }
    public int Price   { get; private set; }
    public int Cost    { get; private set; }

    public Coffee(string name, int price, int cost)
    {
        Name  = name;
        Price = price;
        Cost  = cost;
    }
}