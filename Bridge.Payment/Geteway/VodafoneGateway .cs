using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Geteway
{
    public class VodafoneGateway : IPaymentGateway
    {
       public void ProcessPayment(decimal amount)
       {
           Console.ForegroundColor = ConsoleColor.Red;

           Console.WriteLine("Vodafone Cash Gateway");
           Console.WriteLine($"Processing payment: {amount} EGP");

           Console.ResetColor();
       }

    }
}
