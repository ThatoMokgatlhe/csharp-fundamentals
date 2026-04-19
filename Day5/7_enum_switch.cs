using System;

public enum LogLevel { Debug, Info, Warning, Error }
public class Logger {
    public void Log(LogLevel level, string message) {
        Console.WriteLine($"[{level.ToString().ToUpper()}] {message}");
    }
}

class Program {
    static void Main() {
        new Logger().Log(LogLevel.Warning, "Disk space low");
    }
}
