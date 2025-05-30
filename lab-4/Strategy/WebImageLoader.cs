public class WebImageLoader : IImageLoader
{
    public string Load(string href)
    {
        return $"[Loaded from web: {href}]";
    }
}
