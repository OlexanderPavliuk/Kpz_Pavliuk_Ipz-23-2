using System;

class Program
{
    static void Main(string[] args)
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circleVector = new Circle(vector);
        Shape squareRaster = new Square(raster);
        Shape triangleVector = new Triangle(vector);
        Shape triangleRaster = new Triangle(raster);

        Console.WriteLine("=== Drawing shapes ===");
        circleVector.Draw();
        squareRaster.Draw();
        triangleVector.Draw();
        triangleRaster.Draw();

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
