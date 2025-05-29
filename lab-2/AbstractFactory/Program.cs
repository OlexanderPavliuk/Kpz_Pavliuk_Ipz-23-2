class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== IProne Factory ===");
        TestFactory(new IProneFactory());

        Console.WriteLine("=== Kiaomi Factory ===");
        TestFactory(new KiaomiFactory());

        Console.WriteLine("=== Balaxy Factory ===");
        TestFactory(new BalaxyFactory());
    }

    static void TestFactory(IDeviceFactory factory)
    {
        var laptop = factory.CreateLaptop();
        var netbook = factory.CreateNetbook();
        var ebook = factory.CreateEBook();
        var phone = factory.CreateSmartphone();

        laptop.ShowSpecs();
        netbook.ShowSpecs();
        ebook.ShowSpecs();
        phone.ShowSpecs();

        Console.WriteLine(new string('-', 40));
        Console.ReadLine();
    }
}
