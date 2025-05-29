using System;
using System.Collections.Generic;

public class Character
{
    public string Name { get; set; }
    public string BodyType { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Actions { get; set; } = new List<string>();

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Body: {BodyType}, Hair: {HairColor}, Eyes: {EyeColor}, Outfit: {Outfit}");
        Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
        Console.WriteLine($"Actions: {string.Join(", ", Actions)}");
        Console.WriteLine(new string('-', 40));
    }
}
