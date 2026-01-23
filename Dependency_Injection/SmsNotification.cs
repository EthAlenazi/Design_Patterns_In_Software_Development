namespace Dependency_Injection
{
    public class SmsNotification : INotificationService
    {
        public void Send(string message)
            => Console.WriteLine("SMS Notification Sent");
       
    }
}
