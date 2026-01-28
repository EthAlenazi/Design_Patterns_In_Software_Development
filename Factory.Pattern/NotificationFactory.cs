namespace Factory.Pattern
{


    // 3) Factory
    public static class NotificationFactory
    {
        public static INotification Create(string channel)
        {
            if (string.IsNullOrWhiteSpace(channel))
                throw new ArgumentException("Channel is required.");

            channel = channel.Trim().ToLower();

            return channel switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new NotSupportedException($"Unsupported channel: {channel}")
            };
        }
    }
}
