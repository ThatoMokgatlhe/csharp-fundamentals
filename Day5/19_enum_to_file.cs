using System;
using System.IO;

public enum Color { Red, Green, Blue }

public static class ColorStore {
    public static void Save(string path, Color c) {
        File.WriteAllText(path, c.ToString());
        Console.WriteLine($"Saved Color: {c}");
    }
    public static Color Load(string path) => Enum.Parse<Color>(File.ReadAllText(path));
}

class Program {
    static void Main() {
        ColorStore.Save("color.txt", Color.Green);
    }
}
