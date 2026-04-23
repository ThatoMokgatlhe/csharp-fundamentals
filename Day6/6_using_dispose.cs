using System;

public class FakeResource : IDisposable
{
    private bool _disposed = false;
    public FakeResource() => Console.WriteLine("FakeResource opened.");

    public void DoWork()
    {
        if (_disposed) throw new ObjectDisposedException(nameof(FakeResource));
        throw new Exception("Work failed!");
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _disposed = true;
            Console.WriteLine("FakeResource disposed.");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            using var res = new FakeResource();
            res.DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
    }
}
