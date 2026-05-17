namespace Mediator.SmartHome.Mediator
{
    public class SmartHomeMediator : ISmartHomeMediator
    {
        public MotionSensor MotionSensor { get; set; }
        public TemperatureSensor TemperatureSensor { get; set; }

        public SmartLight Light { get; set; }
        public SmartFan Fan { get; set; }

        public Alarm Alarm { get; set; }

        public MobileNotifier Notifier { get; set; }

        public bool IsArmed { get; set; }

        public void Notify(Device sender, string ev, object? data = null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"\n[MEDIATOR] Event Received => {ev}");

            Console.ResetColor();

            switch (ev)
            {
                case "MotionDetected":

                    Light.TurnOn();

                    Notifier.Send("Motion detected in living room");

                    if (IsArmed)
                    {
                        Alarm.Activate();
                    }

                    break;

                case "NoMotion":

                    Light.TurnOff();

                    break;

                case "HighTemperature":

                    Fan.TurnOn();

                    Notifier.Send($"High temperature: {data}°C");

                    break;

                case "NormalTemperature":

                    Fan.TurnOff();

                    break;
            }
        }
    }
}
