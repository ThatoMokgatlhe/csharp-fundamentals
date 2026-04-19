using System;

public enum Mode { Read, Write, Append }

public static class ModeHelper {
    public static Mode Parse(string s) => Enum.Parse<Mode>(s, true);
    public static string Describe(Mode m) => m switch {
        Mode.Read => "reads content",
        Mode.Write => "writes new content",
        Mode.Append => "appends content",
        _ => "unknown"
    };
}

class Program {
    static void Main() {
        Mode m = ModeHelper.Parse("Write");
        Console.WriteLine($"Mode: {m} ({ModeHelper.Describe(m)})");
    }
}
