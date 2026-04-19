using System;

public class OldLogger {
    public void Log(string s) => Console.WriteLine($"OldLogger received: {s}");
}

public interface INewLogger { void Write(string m); }

public class OldLoggerAdapter : INewLogger {
    private OldLogger _old;
    public OldLoggerAdapter(OldLogger old) => _old = old;
    public void Write(string m) => _old.Log(m);
}

class Program {
    static void Main() {
        INewLogger logger = new OldLoggerAdapter(new OldLogger());
        logger.Write("hello");
    }
}
