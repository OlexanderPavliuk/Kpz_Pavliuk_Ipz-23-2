public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription() => _baseHero.GetDescription() + " + Sword";
    public override int GetPower() => _baseHero.GetPower() + 5;
}