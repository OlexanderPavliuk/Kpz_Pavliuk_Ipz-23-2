using System;

class Program
{
    static void Main(string[] args)
    {
        // Створимо <div class="container"><h1>Hello</h1><p>Paragraph</p></div>

        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        div.CssClasses.Add("container");

        var heading = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
        heading.AddChild(new LightTextNode("Welcome to LightHTML!"));

        var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
        paragraph.AddChild(new LightTextNode("This is a paragraph in our custom HTML renderer."));

        var img = new LightElementNode("img", DisplayType.Inline, ClosingType.Single);
        img.CssClasses.Add("thumbnail");

        div.AddChild(heading);
        div.AddChild(paragraph);
        div.AddChild(img);

        Console.WriteLine("=== OUTER HTML ===");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n=== INNER HTML ===");
        Console.WriteLine(div.InnerHTML);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
