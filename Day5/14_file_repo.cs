using System;
using System.IO;
using System.Collections.Generic;

public class FileRepository {
    public void AddRecord(string path, string record) {
        File.AppendAllText(path, record + Environment.NewLine);
        Console.WriteLine($"Added record to {path}");
    }
    public IEnumerable<string> ReadAll(string path) => File.ReadAllLines(path);
}

class Program {
    static void Main() {
        new FileRepository().AddRecord("repo.txt", "item1");
    }
}
