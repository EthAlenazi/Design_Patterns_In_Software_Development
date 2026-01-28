using OrderSystem.Multiple.Patterns.Models;

namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percent; // e.g. 0.10m = 10%

        public PercentageDiscount(decimal percent)
        {
            if (percent < 0 || percent > 1) throw new ArgumentOutOfRangeException(nameof(percent));
            _percent = percent;
        }

        public decimal ApplyDiscount(Order order, decimal currentAmount)
        {
            var discounted = currentAmount * (1 - _percent);
            Console.WriteLine($"[Discount] Percentage discount {_percent:P0} applied. New total: {discounted}");
            return discounted;
        }
    }

}
