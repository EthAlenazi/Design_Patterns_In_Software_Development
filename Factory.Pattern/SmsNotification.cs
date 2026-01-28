namespace Factory.Pattern
{


    public class SmsNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[SMS] To: {to} | Message: {message}");
        }
    }
}

