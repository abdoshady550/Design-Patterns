using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Geteway
{
public class PaypalGateway : IPaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("PayPal Gateway");
        Console.WriteLine($"Processing payment: {amount} USD");

        Console.ResetColor();
    }
}
}
