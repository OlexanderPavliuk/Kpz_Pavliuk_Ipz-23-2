class Money
{
    public int Whole { get; private set; }
    public int Cents { get; private set; }

    public Money(int whole, int cents)
    {
        SetValue(whole, cents);
    }

    public void SetValue(int whole, int cents)
    {
        Whole = whole + cents / 100;
        Cents = cents % 100;
    }

    public void Display()
    {
        Console.WriteLine($"{Whole}.{Cents:D2}");
    }

    public void Decrease(int totalCents)
    {
        int currentCents = Whole * 100 + Cents - totalCents;
        SetValue(currentCents / 100, currentCents % 100);
    }
}