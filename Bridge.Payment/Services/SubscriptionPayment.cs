using Bridge.Payments.Geteway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Services
{
public class SubscriptionPayment(IPaymentGateway gateway) : Payment(gateway)
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine("Subscription Payments");
        Console.WriteLine("Monthly Plan Activated");

        Gateway.ProcessPayment(amount);
    }
}
}
