using System;
using System.IO;
using System.Collections.Generic;

public interface IConfigProvider { T Get<T>(string key); }

public class ConfigProvider : IConfigProvider {
    private Dictionary<string, string> _d = new();
    public ConfigProvider(string path) {
        foreach(var l in File.ReadAllLines(path)) {
            var p = l.Split('=');
            if(p.Length==2) _d[p[0].Trim()] = p[1].Trim();
        }
    }
    public T Get<T>(string key) => (T)Enum.Parse(typeof(T), _d[key], true);
}

public enum Mode { Read, Write, Append }

class Program {
    static void Main() {
        File.WriteAllText("config.txt", "Mode=Write");
        var cfg = new ConfigProvider("config.txt");
        Console.WriteLine($"Mode -> {cfg.Get<Mode>("Mode")}");
    }
}
