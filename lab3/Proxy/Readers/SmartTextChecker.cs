using System;

public class SmartTextChecker : ITextReader
{
    private readonly SmartTextReader _reader = new SmartTextReader();

    public char[][] ReadText(string path)
    {
        Console.WriteLine($"[INFO] Opening file: {path}");
        var result = _reader.ReadText(path);
        Console.WriteLine($"[INFO] File read successfully: {path}");
        Console.WriteLine($"[INFO] Closing file: {path}");

        int lineCount = result.Length;
        int charCount = 0;
        foreach (var line in result)
        {
            charCount += line.Length;
        }

        Console.WriteLine($"[INFO] Lines: {lineCount}, Characters: {charCount}");
        return result;
    }
}
