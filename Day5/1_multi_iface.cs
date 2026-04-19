using System;

public interface ISerializable { string Serialize(); }
public interface IDeserializable { void Deserialize(string s); }

public class DataObject : ISerializable, IDeserializable {
    private string _data;
    public string Serialize() => _data;
    public void Deserialize(string s) => _data = s;
}

class Program {
    static void Main() {
        var obj = new DataObject();
        obj.Deserialize("Name=Bob;Age=30");
        Console.WriteLine($"Serialized: {obj.Serialize()}");
    }
}
