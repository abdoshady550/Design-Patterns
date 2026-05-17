using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class SmartLight(ISmartHomeMediator mediator) : Device("Smart Light", mediator)
    {
        public void TurnOn()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[Light] ON");

            Console.ResetColor();
        }

        public void TurnOff()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("[Light] OFF");

            Console.ResetColor();
        }
    }
}
