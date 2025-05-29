public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetBody(string body);
    ICharacterBuilder SetHairColor(string color);
    ICharacterBuilder SetEyeColor(string color);
    ICharacterBuilder SetOutfit(string outfit);
    ICharacterBuilder AddItem(string item);
    ICharacterBuilder AddAction(string action);
    Character Build();
}
