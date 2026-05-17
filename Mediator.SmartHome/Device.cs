using Mediator.SmartHome.Mediator;

namespace Mediator.SmartHome
{
    public abstract class Device(string name, ISmartHomeMediator mediator)
    {
        protected readonly ISmartHomeMediator Mediator = mediator;

        public string Name { get; } = name;
    }
}
