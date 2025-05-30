using System;

class Program
{
    static void Main(string[] args)
    {
        var imageFromWeb = new LightImageNode("https://i.pinimg.com/736x/63/b2/0f/63b20ff6d6e5453d8f742cf1578619c0.jpg");
        var imageFromFile = new LightImageNode("images/photo.jpg");

        Console.WriteLine("=== Image from Web ===");
        Console.WriteLine(imageFromWeb.OuterHTML);

        Console.WriteLine("\n=== Image from File ===");
        Console.WriteLine(imageFromFile.OuterHTML);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
