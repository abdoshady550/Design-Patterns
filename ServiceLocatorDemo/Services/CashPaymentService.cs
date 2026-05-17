namespace ServiceLocatorDemo.Services
{
    public class CashPaymentService : IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using CASH");
        }
    }
}
