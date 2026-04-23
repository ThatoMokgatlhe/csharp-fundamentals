using System;

public class DataAccessException : Exception
{
    public DataAccessException(string message, Exception inner)
        : base(message, inner) { }
}

public class DbClient
{
    public void Query(string sql)
    {
        try
        {
            throw new InvalidOperationException("Connection timeout.");
        }
        catch (Exception ex)
        {
            throw new DataAccessException($"Query failed: [{sql}]", ex);
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            new DbClient().Query("SELECT * FROM users");
        }
        catch (DataAccessException ex)
        {
            Console.WriteLine($"DAE: {ex.Message}");
            Console.WriteLine($"Inner: {ex.InnerException?.Message}");
        }
    }
}
