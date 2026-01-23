namespace Dependency_Injection
{
    public class OrderService
    {
        private readonly INotificationService _notification;
        private readonly ILogger _logger;

        public OrderService(INotificationService notification, ILogger logger)
        {
            _notification = notification;
            _logger = logger;
        }

        public void CreateOrder()
        {
            _logger.Log("Order Created");
            _notification.Send("Your order has been created successfully.");
        }
    }

  
}