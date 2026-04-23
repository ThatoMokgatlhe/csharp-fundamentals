using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var tasks = new Task[]
        {
            Task.Run(() => throw new InvalidOperationException("Task A failed")),
            Task.Run(() => throw new ArgumentException("Task B failed"))
        };

        try
        {
            Task.WaitAll(tasks);
        }
        catch (AggregateException ae)
        {
            foreach (var inner in ae.InnerExceptions)
                Console.WriteLine($"[AggEx] {inner.GetType().Name}: {inner.Message}");
        }
    }
}
