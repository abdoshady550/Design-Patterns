using Bridge.Payments.Geteway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Services
{
public class RefundPayment(IPaymentGateway gateway) : Payment(gateway)
{
        public override void Pay(decimal amount)
    {
        Console.WriteLine("Refund Payments");

        Gateway.ProcessPayment(-amount);
    }
}
}
