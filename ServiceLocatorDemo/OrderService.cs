using ServiceLocatorDemo.Services;

namespace ServiceLocatorDemo
{
    public class OrderService
    {
        public void PlaceOrder()
        {
            var logger =
                ServiceLocator.Get<ILogger>();
    
            var payment =
                ServiceLocator.Get<IPaymentService>();
    
            var notification =
                ServiceLocator.Get<INotificationService>();
    
            logger.Log("Order Started");
    
            payment.Pay(500);
    
            notification.Send(
                "Your Order Has Been Confirmed");
    
            logger.Log("Order Completed");
        }
    }
}
