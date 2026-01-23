using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class EmailNotification : INotificationService
    {
        public void Send(string message)
            => Console.WriteLine($"Email Sent: {message}");
    }

    //public class EmailNotification
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("Email Notification Sent");
    //    }
    //}
}
