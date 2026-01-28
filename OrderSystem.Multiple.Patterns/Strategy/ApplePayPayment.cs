namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class ApplePayPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"[Payment] Paid {amount} using Apple Pay.");
    }
}
