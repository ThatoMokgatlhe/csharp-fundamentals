using System;

public static class RetryHelper
{
    public static bool Run(Func<bool> action, int retries)
    {
        int attempt = 0;
        while (attempt < retries)
        {
            try
            {
                attempt++;
                if (action()) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attempt {attempt} failed: {ex.Message}");
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        int callCount = 0;
        bool result = RetryHelper.Run(() =>
        {
            callCount++;
            if (callCount < 3) throw new Exception("Not ready yet");
            Console.WriteLine($"Success on attempt {callCount}");
            return true;
        }, 5);

        Console.WriteLine($"Result: {result}");
    }
}
