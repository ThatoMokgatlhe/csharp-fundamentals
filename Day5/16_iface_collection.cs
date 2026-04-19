using System;
using System.Collections.Generic;

public interface IProcessor { string Process(string s); }
public class UpperProcessor : IProcessor {
    public string Process(string s) => s.ToUpper();
}
public class ReverseProcessor : IProcessor {
    public string Process(string s) {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

public class Pipeline {
    private IEnumerable<IProcessor> _processors;
    public Pipeline(IEnumerable<IProcessor> processors) => _processors = processors;
    public string Run(string input) {
        string res = input;
        foreach(var p in _processors) res = p.Process(res);
        return res;
    }
}

class Program {
    static void Main() {
        var processors = new List<IProcessor> { new UpperProcessor(), new ReverseProcessor() };
        string res = new Pipeline(processors).Run("hello");
        Console.WriteLine($"HELLO -> {res}");
    }
}
