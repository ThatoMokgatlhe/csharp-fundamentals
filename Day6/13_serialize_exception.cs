using System;
using System.IO;

public static class ExceptionSerializer
{
    public static void Save(Exception ex, string path)
    {
        string content = $"Message: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
        File.AppendAllText(path, content);
        Console.WriteLine($"Exception saved to {path}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            int x = int.Parse("not-a-number");
        }
        catch (Exception ex)
        {
            ExceptionSerializer.Save(ex, "ex.txt");
        }
    }
}
