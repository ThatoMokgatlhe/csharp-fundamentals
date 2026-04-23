using System;

public class InvalidOrderException : Exception
{
    public int OrderId { get; }
    public InvalidOrderException(int orderId, string msg)
        : base(msg) => OrderId = orderId;
}

class Program
{
    static void Main()
    {
        try { throw new InvalidOrderException(42, "quantity cannot be zero"); }
        catch (InvalidOrderException ex)
        {
            Console.WriteLine($"Order {ex.OrderId} is invalid: {ex.Message}");
        }
    }
}
