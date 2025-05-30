using System;

public class FinalSupport : SupportHandler
{
    public override void HandleRequest()
    {
        Console.WriteLine("Final Level: Please choose:");
        Console.WriteLine("1 - Speak to human agent\n2 - Exit");
        Console.Write("Your choice: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("You are being connected to a human agent...");
        }
        else
        {
            Console.WriteLine("Thank you for using support system.");
        }
    }
}