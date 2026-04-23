using System;

public class ResourceUser
{
    public void Use(bool fail)
    {
        Console.WriteLine("Resource acquired.");
        try
        {
            if (fail) throw new Exception("Simulated failure!");
        }
        finally
        {
            Console.WriteLine("Cleanup done");
        }
    }
}

class Program
{
    static void Main()
    {
        var r = new ResourceUser();
        try { r.Use(true); } catch { }
    }
}
