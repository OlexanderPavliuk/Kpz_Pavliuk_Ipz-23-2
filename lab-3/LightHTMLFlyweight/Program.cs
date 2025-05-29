using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Початок заміру памʼяті
        long memoryBefore = GC.GetTotalMemory(true);

        // Зчитування тексту книги
        string[] lines = File.ReadAllLines("sample.txt");

        // Підключення фабрики тегів
        LightTagFactory factory = new();
        List<ILightNode> nodes = new();

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line))
                continue; // Пропускаємо порожні рядки

            string tag;
            if (i == 0) tag = "h1";
            else if (line.Length < 20) tag = "h2";
            else if (line.StartsWith(" ")) tag = "blockquote";
            else tag = "p";

            var flyweight = factory.GetTag(tag, DisplayType.Block, ClosingType.Paired);
            var element = new LightElementNode(flyweight);
            element.AddChild(new LightTextNode(line.Trim()));
            nodes.Add(element);
        }

        // Кінець заміру памʼяті
        long memoryAfter = GC.GetTotalMemory(true);
        double usedKb = (memoryAfter - memoryBefore) / 1024.0;

        // Вивід результатів
        Console.WriteLine("=== LightHTML output (first 10 elements) ===\n");
        for (int i = 0; i < Math.Min(10, nodes.Count); i++)
        {
            Console.WriteLine(nodes[i].InnerHTML);
        }

        Console.WriteLine($"\nTotal elements: {nodes.Count}");
        Console.WriteLine($"Unique flyweights used: {factory.Count}");
        Console.WriteLine($"Memory used: {usedKb:F2} KB");

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
