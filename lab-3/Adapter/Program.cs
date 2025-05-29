using System;

class Program
{
    static void Main(string[] args)
    {
        ILogger consoleLogger = new ConsoleLogger();
        ILogger fileLogger = new FileLoggerAdapter("log.txt");

        Console.WriteLine("=== Console Logger ===");
        consoleLogger.Log("System started");
        consoleLogger.Warn("Low battery");
        consoleLogger.Error("Fatal error");

        Console.WriteLine("\n=== File Logger ===");
        fileLogger.Log("File log: started");
        fileLogger.Warn("File log: low space");
        fileLogger.Error("File log: failed");

        Console.WriteLine("Log entries written to log.txt");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
