namespace Factory.Pattern
{


        public class PushNotification : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"[PUSH] To: {to} | Message: {message}");
            }
        }
    }


