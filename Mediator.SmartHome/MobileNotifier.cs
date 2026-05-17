using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class MobileNotifier(ISmartHomeMediator mediator) : Device("Mobile Notifier", mediator)
    {
        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"[Mobile Notification] {message}");

            Console.ResetColor();
        }
    }
}
