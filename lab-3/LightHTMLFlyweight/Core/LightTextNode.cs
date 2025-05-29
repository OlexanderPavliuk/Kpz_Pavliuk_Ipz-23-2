public class LightTextNode : ILightNode
{
    private string _text;

    public LightTextNode(string text)
    {
        _text = text;
    }

    public string OuterHTML => _text;
    public string InnerHTML => _text;
}