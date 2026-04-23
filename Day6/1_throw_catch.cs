using System;

public class OrderProcessor {
    public void Process(int orderId) {
        if (orderId < 0) throw new InvalidOrderException(orderId, "quantity cannot be zero");
        Console.WriteLine($"Order {orderId} processed.");
    }
}

public class InvalidOrderException : Exception {
    public int OrderId { get; }
    public InvalidOrderException(int orderId, string message) : base(message) { OrderId = orderId; }
}

class Program {
    static void Main() {
        try {
            new OrderProcessor().Process(-5);
        } catch (InvalidOrderException ex) {
            Console.WriteLine($"Caught InvalidOrderException: Order {ex.OrderId} is invalid");
        }
    }
}
