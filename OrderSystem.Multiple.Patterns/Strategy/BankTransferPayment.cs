namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"[Payment] Paid {amount} using Bank Transfer.");
    }
}
