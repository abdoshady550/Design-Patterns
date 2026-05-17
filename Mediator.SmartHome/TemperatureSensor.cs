using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class TemperatureSensor(ISmartHomeMediator mediator) : Device("Temperature Sensor", mediator)
    {
        public void SetTemperature(int temp)
        {
            Console.WriteLine($"[Sensor] Temperature = {temp}°C");

            if (temp >= 30)
            {
                Mediator.Notify(this, "HighTemperature", temp);
            }
            else
            {
                Mediator.Notify(this, "NormalTemperature");
            }
        }
    }
}
