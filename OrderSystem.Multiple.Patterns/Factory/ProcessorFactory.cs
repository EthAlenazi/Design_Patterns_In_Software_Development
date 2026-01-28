using OrderSystem.Multiple.Patterns.Strategy;
using OrderSystem.Multiple.Patterns.Template;

namespace OrderSystem.Multiple.Patterns.Factory
{
    public static class ProcessorFactory
    {
        public static OrderProcessor Create(string orderType, IPaymentStrategy payment, IDiscountStrategy discount) =>
            orderType.ToLower() switch
            {
                "online" => new OnlineOrderProcessor(payment, discount),
                "store" => new StoreOrderProcessor(payment, discount),
                "subscription" => new SubscriptionOrderProcessor(payment, discount),
                _ => throw new NotSupportedException($"Order type '{orderType}' not supported.")
            };
    }
}