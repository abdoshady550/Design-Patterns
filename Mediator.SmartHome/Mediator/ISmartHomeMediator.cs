using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.SmartHome.Mediator
{
    public interface ISmartHomeMediator
    {
        void Notify(Device sender, string ev, object? data = null);
    }
}
