using System;
using System.Collections.Generic;

public interface IRepository<T> { void Add(T item); T Get(int index); }
public class InMemoryRepository<T> : IRepository<T> {
    private List<T> _items = new();
    public void Add(T item) => _items.Add(item);
    public T Get(int index) => _items[index];
}

class Program {
    static void Main() {
        var repo = new InMemoryRepository<string>();
        repo.Add("alpha");
        repo.Add("beta");
        Console.WriteLine(repo.Get(1));
    }
}
