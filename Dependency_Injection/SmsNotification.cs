using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class SmsNotification : INotificationService
    {
        public void Send(string message)
            => Console.WriteLine("SMS Notification Sent");
       
    }
}
