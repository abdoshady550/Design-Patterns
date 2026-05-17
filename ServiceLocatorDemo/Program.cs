using ServiceLocatorDemo.Services;

namespace ServiceLocatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        RegisterServices();

        OrderService orderService = new();

        orderService.PlaceOrder();
    }

        static void RegisterServices()
        {
            ServiceLocator.Register<ILogger>(new ConsoleLogger());

            ServiceLocator.Register<IPaymentService>(new CashPaymentService());

            ServiceLocator.Register<INotificationService>(new EmailNotificationService());
        }
    }
}
