namespace without_Strategy_Pattern
{
    public class ApplePayPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} using Apple Pay");
    }

   
}
