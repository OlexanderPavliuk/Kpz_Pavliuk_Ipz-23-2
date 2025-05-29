using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення "родини" вірусів (3 покоління)
        var root = new Virus("Alpha", "Corona", 2.5, 3);

        var child1 = new Virus("Beta", "Corona", 1.2, 2);
        var child2 = new Virus("Gamma", "Corona", 1.0, 2);

        var grandChild1 = new Virus("Delta", "Corona", 0.8, 1);
        var grandChild2 = new Virus("Omicron", "Corona", 0.7, 1);

        child1.Children.Add(grandChild1);
        child2.Children.Add(grandChild2);

        root.Children.Add(child1);
        root.Children.Add(child2);

        Console.WriteLine("=== Original Virus Family ===");
        root.Display();

        // Клонування
        var clone = root.Clone();

        Console.WriteLine("\n=== Cloned Virus Family ===");
        clone.Display();

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
