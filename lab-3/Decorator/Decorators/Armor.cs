public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription() => _baseHero.GetDescription() + " + Armor";
    public override int GetPower() => _baseHero.GetPower() + 3;
}