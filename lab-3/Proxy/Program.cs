using System;

class Program
{
    static void Main(string[] args)
    {
        string allowedPath = "sample.txt";
        string blockedPath = "secret_blocked.txt";

        // Створення тестових файлів
        File.WriteAllText(allowedPath, "Hello\nWorld");
        File.WriteAllText(blockedPath, "You shouldn't see this.");

        Console.WriteLine("=== SmartTextChecker ===");
        ITextReader checker = new SmartTextChecker();
        var result = checker.ReadText(allowedPath);

        Console.WriteLine("\n=== SmartTextReaderLocker ===");
        ITextReader locker = new SmartTextReaderLocker("secret_.*\\.txt");
        locker.ReadText(blockedPath);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
