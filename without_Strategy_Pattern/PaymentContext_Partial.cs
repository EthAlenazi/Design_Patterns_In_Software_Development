namespace without_Strategy_Pattern
{
    public class PaymentContext_Partial
    {
        public void ExecutePayment(PaymentType type, decimal amount)
        {
            IPaymentStrategy strategy;

            switch (type)
            {
                case PaymentType.CreditCard:
                    strategy = new CreditCardPayment();
                    break;

                case PaymentType.ApplePay:
                    strategy = new ApplePayPayment();
                    break;

                case PaymentType.StcPay:
                    strategy = new StcPayPayment();
                    break;

                default:
                    throw new NotSupportedException($"Payment type {type} is not supported.");
            }

            strategy.Pay(amount);
        }
    }

   
}
