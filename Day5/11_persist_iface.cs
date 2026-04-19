using System;
using System.IO;

public interface IPersist { void Save(string path); }
public class User : IPersist {
    public string Name { get; set; } = "Bob";
    public int Age { get; set; } = 42;
    public void Save(string path) {
        File.WriteAllText(path, $"{Name} {Age}");
        Console.WriteLine($"Saved user to {path}");
    }
}

class Program {
    static void Main() {
        new User().Save("user.txt");
    }
}
