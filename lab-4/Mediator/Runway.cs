using System;

public class Runway
{
    public readonly Guid Id = Guid.NewGuid();
    public Aircraft? IsBusyWithAircraft { get; set; }

    public void HighLightRed() => Console.WriteLine($"Runway {Id} is busy!");
    public void HighLightGreen() => Console.WriteLine($"Runway {Id} is free!");
}