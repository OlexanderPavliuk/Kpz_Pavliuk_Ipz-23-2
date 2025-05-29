public class CharacterDirector
{
    public Character BuildKnight(ICharacterBuilder builder)
    {
        return builder
            .SetName("Arthas")
            .SetBody("Muscular")
            .SetHairColor("Blonde")
            .SetEyeColor("Blue")
            .SetOutfit("Holy Armor")
            .AddItem("Sword of Light")
            .AddItem("Shield")
            .AddAction("Saved villagers")
            .AddAction("Defeated dark wizard")
            .Build();
    }

    public Character BuildDemon(ICharacterBuilder builder)
    {
        return builder
            .SetName("Ravager")
            .SetBody("Monstrous")
            .SetHairColor("Black")
            .SetEyeColor("Red")
            .SetOutfit("Dark Cloak")
            .AddItem("Cursed Blade")
            .AddItem("Soul Amulet")
            .AddAction("Burned the city")
            .AddAction("Summoned undead")
            .Build();
    }
}
