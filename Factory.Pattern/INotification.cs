namespace Factory.Pattern
{
    // 1) Product (Interface)
    public interface INotification
    {
        void Send(string to, string message);
    }
}
