using System;

class Program
{
    static void Main(string[] args)
    {
        var director = new CharacterDirector();

        var hero = director.BuildKnight(new HeroBuilder());
        var enemy = director.BuildDemon(new EnemyBuilder());

        Console.WriteLine("=== HERO ===");
        hero.Show();

        Console.WriteLine("=== ENEMY ===");
        enemy.Show();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
