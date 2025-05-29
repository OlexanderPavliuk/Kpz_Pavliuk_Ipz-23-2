using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення героя-воїна
        IHero hero = new Warrior();

        // Додавання інвентаря через декоратори
        hero = new Sword(hero);
        hero = new Armor(hero);
        hero = new Amulet(hero);

        Console.WriteLine("=== Equipped Hero ===");
        Console.WriteLine("Description: " + hero.GetDescription());
        Console.WriteLine("Total Power: " + hero.GetPower());

        // Інший герой
        IHero mage = new Cloak(new Amulet(new Mage()));

        Console.WriteLine("\n=== Equipped Mage ===");
        Console.WriteLine("Description: " + mage.GetDescription());
        Console.WriteLine("Total Power: " + mage.GetPower());

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
