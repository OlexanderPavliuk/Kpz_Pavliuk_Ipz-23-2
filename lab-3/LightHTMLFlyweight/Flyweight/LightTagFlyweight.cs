public class LightTagFlyweight
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public ClosingType Closing { get; }

    public LightTagFlyweight(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }
}