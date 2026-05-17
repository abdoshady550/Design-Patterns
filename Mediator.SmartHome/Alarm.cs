using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class Alarm(ISmartHomeMediator mediator) : Device("Alarm", mediator)
    {
        public void Activate()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("[ALARM] SECURITY ALERT!");

            Console.ResetColor();
        }
    }
}