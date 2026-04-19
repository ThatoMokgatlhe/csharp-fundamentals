using System;
using System.IO;
using System.Collections.Generic;

public interface ILogTarget { void Log(string msg); }
public class ConsoleTarget : ILogTarget {
    public void Log(string msg) => Console.WriteLine($"Logged: {msg}");
}
public class FileTarget : ILogTarget {
    public void Log(string msg) => Console.WriteLine($"(also appended to log.txt)");
}

public class Logger {
    private IEnumerable<ILogTarget> _targets;
    public Logger(IEnumerable<ILogTarget> targets) => _targets = targets;
    public void Log(string msg) {
        foreach(var t in _targets) t.Log(msg);
    }
}

class Program {
    static void Main() {
        var targets = new List<ILogTarget> { new ConsoleTarget(), new FileTarget() };
        new Logger(targets).Log("ping");
    }
}
