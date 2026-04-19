using System;
using System.IO;

public class FileReader {
    public string[] ReadLines(string path) => File.ReadAllLines(path);
}

class Program {
    static void Main() {
        File.WriteAllText("input.txt", "line1\nline2");
        var lines = new FileReader().ReadLines("input.txt");
        foreach(var l in lines) Console.WriteLine(l);
    }
}
