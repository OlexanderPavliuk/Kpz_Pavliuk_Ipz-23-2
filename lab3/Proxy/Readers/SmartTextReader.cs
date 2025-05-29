using System;
using System.IO;
using System.Collections.Generic;

public class SmartTextReader : ITextReader
{
    public char[][] ReadText(string path)
    {
        var lines = File.ReadAllLines(path);
        var result = new List<char[]>();

        foreach (var line in lines)
        {
            result.Add(line.ToCharArray());
        }

        return result.ToArray();
    }
}
