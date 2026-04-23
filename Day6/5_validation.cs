using System;

public class ValidationException : Exception {
    public string Field { get; }
    public ValidationException(string field, string message) : base(message) { Field = field; }
}

public static class Validator {
    public static void ValidateAge(int age) {
        if (age < 0) throw new ValidationException("Age", "Age must be non-negative");
    }
}

class Program {
    static void Main() {
        try {
            Validator.ValidateAge(-3);
        } catch (ValidationException ex) {
            Console.WriteLine($"Validation failed ({ex.Field}): {ex.Message}");
        }
    }
}
