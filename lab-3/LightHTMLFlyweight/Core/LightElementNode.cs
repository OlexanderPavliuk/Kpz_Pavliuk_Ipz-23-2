using System.Text;

public class LightElementNode : ILightNode
{
    private LightTagFlyweight _tag;
    private List<ILightNode> _children = new();

    public LightElementNode(LightTagFlyweight tag)
    {
        _tag = tag;
    }

    public void AddChild(ILightNode node)
    {
        _children.Add(node);
    }

    public string InnerHTML
    {
        get
        {
            StringBuilder sb = new();
            foreach (var child in _children)
            {
                sb.Append(child.OuterHTML);
            }
            return sb.ToString();
        }
    }

    public string OuterHTML
    {
        get
        {
            if (_tag.Closing == ClosingType.Single)
                return $"<{_tag.TagName}/>`";

            return $"<{_tag.TagName}>{InnerHTML}</{_tag.TagName}>";
        }
    }
}