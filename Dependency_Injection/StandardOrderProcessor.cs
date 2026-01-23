namespace Dependency_Injection
{
    public class StandardOrderProcessor: IOrderProcessor
    {
        public string Type => "Standard";

        public void Process(string orderId)
            => Console.WriteLine($"Processing STANDARD order: {orderId}");
    }
}

