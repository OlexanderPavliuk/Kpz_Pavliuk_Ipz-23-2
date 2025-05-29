public class ConsoleLogger : ILogger
{
    private readonly Logger _logger = new Logger();

    public void Log(string message) => _logger.Log(message);
    public void Error(string message) => _logger.Error(message);
    public void Warn(string message) => _logger.Warn(message);
}
