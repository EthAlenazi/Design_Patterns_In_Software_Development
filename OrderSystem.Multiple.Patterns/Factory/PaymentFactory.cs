using OrderSystem.Multiple.Patterns.Strategy;

namespace OrderSystem.Multiple.Patterns.Factory
{
    public static class PaymentFactory
    {
        public static IPaymentStrategy Create(string paymentType) =>
            paymentType.ToLower() switch
            {
                "credit" => new CreditCardPayment(),
                "applepay" => new ApplePayPayment(),
                "bank" => new BankTransferPayment(),
                _ => throw new NotSupportedException($"Payment '{paymentType}' not supported.")
            };
    }
}