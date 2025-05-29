class Product
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public Money Price { get; private set; }

    public Product(string name, string unit, Money price)
    {
        Name = name;
        Unit = unit;
        Price = price;
    }

    public void ReducePrice(int cents)
    {
        Price.Decrease(cents);
    }

    public void Display()
    {
        Console.Write($"{Name} ({Unit}) - Ціна: ");
        Price.Display();
    }
}