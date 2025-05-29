public class HeroBuilder : ICharacterBuilder
{
    protected Character character = new Character();

    public ICharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }

    public ICharacterBuilder SetBody(string body)
    {
        character.BodyType = body;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        character.HairColor = color;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string color)
    {
        character.EyeColor = color;
        return this;
    }

    public ICharacterBuilder SetOutfit(string outfit)
    {
        character.Outfit = outfit;
        return this;
    }

    public ICharacterBuilder AddItem(string item)
    {
        character.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddAction(string action)
    {
        character.Actions.Add("Good: " + action);
        return this;
    }

    public Character Build()
    {
        return character;
    }
}
