using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Payments.Geteway
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }

}
