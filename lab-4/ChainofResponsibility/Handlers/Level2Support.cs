using System;

public class Level2Support : SupportHandler
{
    public override void HandleRequest()
    {
        Console.WriteLine("Level 2: Please choose:");
        Console.WriteLine("1 - SIM card problems\n2 - Phone configuration\n3 - Something else");
        Console.Write("Your choice: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("Level 2: SIM card support connected.");
        }
        else if (_next != null)
        {
            _next.HandleRequest();
        }
        else
        {
            Console.WriteLine("Issue not resolved. Restarting menu...\n");
        }
    }
}