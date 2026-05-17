using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public class MotionSensor(ISmartHomeMediator mediator) : Device("Motion Sensor", mediator)
    {
        public void DetectMotion()
        {
            Console.WriteLine("[Sensor] Motion detected");

            Mediator.Notify(this, "MotionDetected");
        }

        public void NoMotion()
        {
            Console.WriteLine("[Sensor] No motion");

            Mediator.Notify(this, "NoMotion");
        }
    }
}