using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public static class AppDependencies
    {
        // Create and wire up all dependencies here
        public static OrderService CreateOrderService()
        {
            ILogger logger = new ConsoleLogger();
            INotificationService notification = new EmailNotification();

          return new OrderService(notification, logger);
        }
    }
}

