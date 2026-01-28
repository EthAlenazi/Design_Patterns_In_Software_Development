

namespace Factory.Pattern
{

    // 2) Concrete Products
    public class EmailNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[EMAIL] To: {to} | Message: {message}");
        }
    }
}

