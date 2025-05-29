public abstract class HeroDecorator : IHero
{
    protected IHero _baseHero;

    protected HeroDecorator(IHero hero)
    {
        _baseHero = hero;
    }

    public virtual string GetDescription() => _baseHero.GetDescription();
    public virtual int GetPower() => _baseHero.GetPower();
}
