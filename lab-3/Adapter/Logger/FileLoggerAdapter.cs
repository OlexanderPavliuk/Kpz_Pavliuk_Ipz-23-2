public class FileLoggerAdapter : ILogger
{
    private readonly FileWriter _writer;

    public FileLoggerAdapter(string filePath)
    {
        _writer = new FileWriter(filePath);
    }

    public void Log(string message)
    {
        _writer.WriteLine("[LOG] " + message);
    }

    public void Error(string message)
    {
        _writer.WriteLine("[ERROR] " + message);
    }

    public void Warn(string message)
    {
        _writer.WriteLine("[WARNING] " + message);
    }
}
