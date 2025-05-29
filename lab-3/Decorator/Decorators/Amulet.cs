public class Amulet : HeroDecorator
{
    public Amulet(IHero hero) : base(hero) { }

    public override string GetDescription() => _baseHero.GetDescription() + " + Amulet";
    public override int GetPower() => _baseHero.GetPower() + 2;
}