using System.IO;

public class FileWriter
{
    private readonly string _filePath;

    public FileWriter(string path)
    {
        _filePath = path;
    }

    public void Write(string text)
    {
        File.AppendAllText(_filePath, text);
    }

    public void WriteLine(string text)
    {
        File.AppendAllText(_filePath, text + "\n");
    }
}
