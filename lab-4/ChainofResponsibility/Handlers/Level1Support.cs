using System;

public class Level1Support : SupportHandler
{
    public override void HandleRequest()
    {
        Console.WriteLine("Welcome to Mobile Support System");
        Console.WriteLine("1 - Internet issues\n2 - Billing\n3 - Something else");
        Console.Write("Your choice: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("Level 1: Internet support connected.");
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