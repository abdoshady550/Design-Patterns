using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Geteway
{
public class StripeGateway : IPaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("Stripe Gateway");
        Console.WriteLine($"Processing payment: {amount}");

        Console.ResetColor();
    }
}
}
