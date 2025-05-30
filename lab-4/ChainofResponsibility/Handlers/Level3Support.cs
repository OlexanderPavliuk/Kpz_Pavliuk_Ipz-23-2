using System;

public class Level3Support : SupportHandler
{
    public override void HandleRequest()
    {
        Console.WriteLine("Level 3: Please choose:");
        Console.WriteLine("1 - Device warranty\n2 - Lost phone\n3 - Something else");
        Console.Write("Your choice: ");
        string input = Console.ReadLine();

        if (input == "2")
        {
            Console.WriteLine("Level 3: Lost phone support connected.");
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