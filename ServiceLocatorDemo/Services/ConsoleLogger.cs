namespace ServiceLocatorDemo.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
    
            Console.WriteLine($"[LOG] {message}");
    
            Console.ResetColor();
        }
    }
}
