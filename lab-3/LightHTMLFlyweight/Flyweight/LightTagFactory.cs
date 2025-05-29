using System.Collections.Generic;

public class LightTagFactory
{
    private Dictionary<string, LightTagFlyweight> _flyweights = new();

    public LightTagFlyweight GetTag(string tagName, DisplayType display, ClosingType closing)
    {
        string key = $"{tagName}_{display}_{closing}";
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new LightTagFlyweight(tagName, display, closing);
        }
        return _flyweights[key];
    }

    public int Count => _flyweights.Count;
}