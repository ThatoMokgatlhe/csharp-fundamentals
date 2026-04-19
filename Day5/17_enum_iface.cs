using System;
using System.Linq;
using System.Collections.Generic;

public enum SortOrder { Asc, Desc }
public interface ISorter {
    IEnumerable<int> Sort(IEnumerable<int> items, SortOrder order);
}

public class Sorter : ISorter {
    public IEnumerable<int> Sort(IEnumerable<int> items, SortOrder order) {
        return order == SortOrder.Asc ? items.OrderBy(x => x) : items.OrderByDescending(x => x);
    }
}

class Program {
    static void Main() {
        var sorted = new Sorter().Sort(new[] { 3, 1, 2 }, SortOrder.Asc);
        Console.WriteLine(string.Join(" ", sorted));
    }
}
