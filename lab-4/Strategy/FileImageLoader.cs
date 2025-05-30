public class FileImageLoader : IImageLoader
{
    public string Load(string href)
    {
        return $"[Loaded from file system: {href}]";
    }
}
