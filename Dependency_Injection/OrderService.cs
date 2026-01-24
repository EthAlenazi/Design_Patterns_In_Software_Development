namespace Dependency_Injection
{
    public class OrderService : TracedDisposable
    {
        protected override string TypeName => "OrderService";

        private readonly INotificationService _notification;
        private readonly ILogger _logger;

        public OrderService(INotificationService notification, ILogger logger, ITracer tracer)
            : base(tracer)
        {
            _notification = notification;
            _logger = logger;
        }

        public void CreateOrder()
        {
            TraceUse("CreateOrder()");
            _logger.Log("Order Created");
            _notification.Send("Order Notification Sent");
        }
    }


}