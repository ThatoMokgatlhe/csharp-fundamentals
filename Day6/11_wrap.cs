using System;
using System.IO;

public class ServiceException : Exception {
    public ServiceException(string message, Exception inner) : base(message, inner) { }
}

public class FileService {
    public void Load(string path) {
        try {
            File.ReadAllText(path);
        } catch (IOException ex) {
            throw new ServiceException("Unable to load configuration", ex);
        }
    }
}

class Program {
    static void Main() {
        try {
            new FileService().Load("missing.txt");
        } catch (ServiceException ex) {
            Console.WriteLine($"Service error: {ex.Message}");
            Console.WriteLine($"Inner: {ex.InnerException?.GetType().FullName}");
        }
    }
}
