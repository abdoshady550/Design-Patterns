namespace ServiceLocatorDemo.Services
{
    public class EmailNotificationService: INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }
}
