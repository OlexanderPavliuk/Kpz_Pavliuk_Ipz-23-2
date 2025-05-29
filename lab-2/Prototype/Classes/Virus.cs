using System;
using System.Collections.Generic;

public class Virus
{
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
    }

    // Метод для глибокого клонування
    public Virus Clone()
    {
        var clone = new Virus(Name, Species, Weight, Age);

        foreach (var child in Children)
        {
            clone.Children.Add(child.Clone());
        }

        return clone;
    }

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}Name: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}");
        foreach (var child in Children)
        {
            child.Display(indent + "  ");
        }
    }
}
