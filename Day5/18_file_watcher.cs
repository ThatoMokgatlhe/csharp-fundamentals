using System;

public interface IFileWatcher { void Start(string path); }

public class SimpleWatcher : IFileWatcher {
    public void Start(string path) => Console.WriteLine($"Started watching {path}");
}

class Program {
    static void Main() {
        new SimpleWatcher().Start("somefolder");
    }
}
