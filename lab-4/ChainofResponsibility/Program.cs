using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var final = new FinalSupport();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(final);

            level1.HandleRequest();

            Console.Write("\nRepeat? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;

            Console.Clear();
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}