using System;

class Program
{
    static void Main(string[] args)
    {
        var runway1 = new Runway();
        var runway2 = new Runway();
        var commandCentre = new CommandCentre(new[] { runway1, runway2 });

        var aircraft1 = new Aircraft("Boeing 737", commandCentre);
        var aircraft2 = new Aircraft("Airbus A320", commandCentre);
        var aircraft3 = new Aircraft("F-16 Falcon", commandCentre);

        aircraft1.Land();
        aircraft2.Land();
        aircraft3.Land(); // цей вже не зможе приземлитися, всі смуги зайняті

        aircraft1.TakeOff();
        aircraft3.Land(); // тепер зможе

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
