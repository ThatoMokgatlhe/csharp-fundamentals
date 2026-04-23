using System;
using System.IO;

public static class ExceptionLogger {
    public static void Log(Exception ex, string path) {
        File.AppendAllText(path, $"{ex.Message}\n{ex.StackTrace}\n");
        Console.WriteLine($"Exception logged to {path}");
    }
}

class Program {
    static void Main() {
        try {
            throw new Exception("Test error");
        } catch (Exception ex) {
            ExceptionLogger.Log(ex, "error.log");
        }
    }
}
