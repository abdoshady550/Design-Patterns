using Bridge.Payments.Geteway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Services
{

public abstract class Payment(IPaymentGateway gateway)
    {
    protected readonly IPaymentGateway Gateway = gateway;

        public abstract void Pay(decimal amount);
    }
}
