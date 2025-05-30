using System;

class Program
{
    static void Main(string[] args)
    {
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        div.CssClasses.Add("container");

        var heading = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
        heading.AddChild(new LightTextNode("Welcome to LightHTML!"));

        var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
        paragraph.AddChild(new LightTextNode("This is a paragraph in our custom HTML renderer."));

        var img = new LightElementNode("img", DisplayType.Inline, ClosingType.Single);
        img.CssClasses.Add("thumbnail");

        // Event listeners
        heading.AddEventListener("click", () => Console.WriteLine("Heading clicked!"));
        img.AddEventListener("mouseover", () => Console.WriteLine("Mouse over image!"));

        div.AddChild(heading);
        div.AddChild(paragraph);
        div.AddChild(img);

        Console.WriteLine("=== OUTER HTML ===");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n=== INNER HTML ===");
        Console.WriteLine(div.InnerHTML);

        Console.WriteLine("\n=== SIMULATING EVENTS ===");
        heading.TriggerEvent("click");
        img.TriggerEvent("mouseover");

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
