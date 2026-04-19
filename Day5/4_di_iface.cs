using System;

public interface ILogger { void Log(string msg); }

public class ConsoleLogger : ILogger {
    public void Log(string msg) => Console.WriteLine(msg);
}

public class Service {
    private ILogger _logger;
    public Service(ILogger logger) => _logger = logger;
    public void DoWork() {
        _logger.Log("Service started");
        _logger.Log("Service finished");
    }
}

class Program {
    static void Main() {
        new Service(new ConsoleLogger()).DoWork();
    }
}
