namespace Factory.Pattern
{

    // 4) Client (Program)
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose channel: email | sms | push");
            Console.Write("> ");
            string channel = Console.ReadLine();

            Console.Write("Send to: ");
            string to = Console.ReadLine();

            Console.Write("Message: ");
            string message = Console.ReadLine();

            // ✅ Client doesn't know concrete classes
            // ✅ No `new EmailNotification()` here
            INotification notifier = NotificationFactory.Create(channel);
            notifier.Send(to, message);

            Console.WriteLine("\nDone ✅");
        }
    }
}
