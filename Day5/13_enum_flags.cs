using System;

[Flags]
public enum Permissions { None=0, Read=1, Write=2, Execute=4 }

public static class PermHelper {
    public static Permissions Parse(string s) => Enum.Parse<Permissions>(s, true);
    public static string Describe(Permissions p) => p.ToString();
}

class Program {
    static void Main() {
        var p = PermHelper.Parse("Read,Write");
        Console.WriteLine($"Permissions: {PermHelper.Describe(p)}");
    }
}
