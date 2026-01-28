using OrderSystem.Multiple.Patterns.Models;
using OrderSystem.Multiple.Patterns.Strategy;

namespace OrderSystem.Multiple.Patterns.Template
{
    public class SubscriptionOrderProcessor : OrderProcessor
    {
        public SubscriptionOrderProcessor(IPaymentStrategy payment, IDiscountStrategy discount) : base(payment, discount) { }

        protected override void ApplyBusinessRules(Order order)
            => Console.WriteLine("[Rules] Subscription: recurring billing rules + trial checks.");
    }
}
