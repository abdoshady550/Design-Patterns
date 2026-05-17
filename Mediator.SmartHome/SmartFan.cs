using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class SmartFan(ISmartHomeMediator mediator) : Device("Smart Fan", mediator)
    {
        public void TurnOn()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("[Fan] ON");

            Console.ResetColor();
        }

        public void TurnOff()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("[Fan] OFF");

            Console.ResetColor();
        }
    }
}
