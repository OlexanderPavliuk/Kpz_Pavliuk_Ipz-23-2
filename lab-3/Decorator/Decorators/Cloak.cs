public class Cloak : HeroDecorator
{
    public Cloak(IHero hero) : base(hero) { }

    public override string GetDescription() => _baseHero.GetDescription() + " + Cloak";
    public override int GetPower() => _baseHero.GetPower() + 4;
}