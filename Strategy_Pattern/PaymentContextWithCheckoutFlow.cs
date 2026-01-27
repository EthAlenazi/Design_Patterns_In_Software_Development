namespace Strategy_Pattern
{
    public class PaymentContextWithCheckoutFlow
    {
        private IPaymentStrategy _paymentStrategy;
        private CheckoutFlowType _flowType;

        public PaymentContextWithCheckoutFlow(IPaymentStrategy strategy, CheckoutFlowType flowType)
        {
            _paymentStrategy = strategy;
            _flowType = flowType;
        }

        public void ChangeStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void ChangeFlow(CheckoutFlowType flowType)
        {
            _flowType = flowType;
        }

        public void ExecutePayment(decimal amount)
        {
            if (_flowType == CheckoutFlowType.Simple)
            {
                Validate(amount);
                _paymentStrategy.Pay(amount);
            }
            else
            {
                LogAttempt(amount);
                Validate(amount);
                _paymentStrategy.Pay(amount);
                Notify();
            }
        }

        private void Validate(decimal amount)
            => Console.WriteLine($"Validate amount: {amount}");

        private void LogAttempt(decimal amount)
            => Console.WriteLine($"Log attempt for {amount}");

        private void Notify()
            => Console.WriteLine("Notify user");
    }


}