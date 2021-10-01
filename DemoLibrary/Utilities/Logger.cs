namespace DemoLibrary.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {DateTime.Now:yyyy-MM-ddThh:mm:ss.fff} { message }");
        }
    }
}
