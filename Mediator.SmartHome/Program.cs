using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- SMART HOME ---\n");

            SmartHomeMediator mediator = new();

            MotionSensor motionSensor = new(mediator);
            TemperatureSensor tempSensor = new(mediator);

            SmartLight light = new(mediator);
            SmartFan fan = new(mediator);

            Alarm alarm = new(mediator);

            MobileNotifier notifier = new(mediator);

            mediator.MotionSensor = motionSensor;
            mediator.TemperatureSensor = tempSensor;

            mediator.Light = light;
            mediator.Fan = fan;

            mediator.Alarm = alarm;
            mediator.Notifier = notifier;

            mediator.IsArmed = true;


            Console.WriteLine("1- Motion Detection");

            motionSensor.DetectMotion();

            Console.WriteLine();

            motionSensor.NoMotion();

            Console.WriteLine("2 - High Temperature");

            tempSensor.SetTemperature(35);

            Console.WriteLine();

            tempSensor.SetTemperature(22);

            }
    }
}
