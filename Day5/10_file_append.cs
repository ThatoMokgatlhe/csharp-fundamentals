using System;
using System.IO;

public class FileAppender {
    public void Append(string path, string line) {
        File.AppendAllText(path, line + Environment.NewLine);
        Console.WriteLine($"Appended 1 line to {path}");
    }
}

class Program {
    static void Main() {
        new FileAppender().Append("log.txt", "New entry");
    }
}
