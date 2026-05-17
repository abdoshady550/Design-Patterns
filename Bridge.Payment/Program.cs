using Bridge.Payments.Geteway;
using Bridge.Payments.Services;


namespace Bridge.Payments;

internal class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("-- Payment System --");
        Console.WriteLine();

        // Vodafone + Normal Payment

        IPaymentGateway vodafone = new VodafoneGateway();

        Payment normalPayment =
            new NormalPayment(vodafone);

        normalPayment.Pay(1500);

        Console.WriteLine();

        // PayPal + Subscription

        IPaymentGateway paypal = new PaypalGateway();

        Payment subscription =
            new SubscriptionPayment(paypal);

        subscription.Pay(300);

        Console.WriteLine();

        // Stripe + Refund

        IPaymentGateway stripe = new StripeGateway();

        Payment refund =
            new RefundPayment(stripe);

        refund.Pay(750);

        Console.WriteLine();

        //-----------------------------------
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("-- Switching --");

        Payment payment =
            new NormalPayment(vodafone);

        payment.Pay(100);

        Console.WriteLine();

        payment = new NormalPayment(paypal);

        payment.Pay(100);

        Console.WriteLine();

        payment = new NormalPayment(stripe);

        payment.Pay(100);

        Console.ResetColor();
    }
}