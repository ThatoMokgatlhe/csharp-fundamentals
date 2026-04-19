using System;

public abstract class Shape {
    public abstract void PrintArea(double r);
}
public class Circle : Shape {
    public override void PrintArea(double r) => Console.WriteLine($"Circle area: {Math.PI * r * r:F4}");
}
public class Rectangle : Shape {
    public override void PrintArea(double w) => Console.WriteLine($"Rectangle area: {w * w}");
}

public interface IShapeFactory { Shape Create(string kind); }
public class ShapeFactory : IShapeFactory {
    public Shape Create(string kind) => kind.ToLower() switch {
        "circle" => new Circle(),
        _ => new Rectangle()
    };
}

class Program {
    static void Main() {
        var s = new ShapeFactory().Create("circle");
        s.PrintArea(2);
    }
}
