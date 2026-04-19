using System;
using System.IO;

public class FileWriter {
    public void WriteText(string path, string content) {
        File.WriteAllText(path, content);
        Console.WriteLine($"Wrote {content.Length} bytes to {path}");
    }
}

class Program {
    static void Main() {
        new FileWriter().WriteText("output.txt", "Hello File");
    }
}
