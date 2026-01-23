namespace Dependency_Injection
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
            => Console.WriteLine($"[LOG] {message}");
    }

}
