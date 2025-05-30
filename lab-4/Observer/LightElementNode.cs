using System;
using System.Collections.Generic;
using System.Text;

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType Display { get; set; }
    public ClosingType Closing { get; set; }
    public List<string> CssClasses { get; set; } = new();
    public List<LightNode> Children { get; set; } = new();

    private Dictionary<string, List<Action>> _eventListeners = new();

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }

    public void AddChild(LightNode node)
    {
        Children.Add(node);
    }

    public void AddEventListener(string eventType, Action callback)
    {
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action>();
        }
        _eventListeners[eventType].Add(callback);
    }

    public void TriggerEvent(string eventType)
    {
        if (_eventListeners.ContainsKey(eventType))
        {
            foreach (var callback in _eventListeners[eventType])
            {
                callback.Invoke();
            }
        }
    }

    private string GetClassString()
    {
        return CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
    }

    public override string InnerHTML
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML);
            }
            return sb.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            string classAttr = GetClassString();
            if (Closing == ClosingType.Single)
                return $"<{TagName}{classAttr}/>";

            return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
        }
    }
}
