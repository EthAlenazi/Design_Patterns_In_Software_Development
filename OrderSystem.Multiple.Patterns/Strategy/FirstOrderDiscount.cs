using OrderSystem.Multiple.Patterns.Models;

namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class FirstOrderDiscount : IDiscountStrategy
    {
        private readonly decimal _amountOff;

        public FirstOrderDiscount(decimal amountOff)
        {
            if (amountOff < 0) throw new ArgumentOutOfRangeException(nameof(amountOff));
            _amountOff = amountOff;
        }

        public decimal ApplyDiscount(Order order, decimal currentAmount)
        {
            if (!order.IsFirstOrder)
            {
                Console.WriteLine("[Discount] Not first order, no discount applied.");
                return currentAmount;
            }

            var discounted = Math.Max(0, currentAmount - _amountOff);
            Console.WriteLine($"[Discount] First order discount -{_amountOff}. New total: {discounted}");
            return discounted;
        }
    }

}
