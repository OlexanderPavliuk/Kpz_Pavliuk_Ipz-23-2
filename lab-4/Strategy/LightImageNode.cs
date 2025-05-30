using System;

public class LightImageNode : LightNode
{
    public string Href { get; }
    private readonly IImageLoader _loader;

    public LightImageNode(string href)
    {
        Href = href;
        _loader = href.StartsWith("http") ? new WebImageLoader() : new FileImageLoader();
    }

    public override string InnerHTML => "";
    public override string OuterHTML => $"<img src=\"{Href}\"/> // {_loader.Load(Href)}";
}
