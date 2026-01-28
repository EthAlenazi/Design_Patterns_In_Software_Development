using OrderSystem.Multiple.Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Multiple.Patterns.Factory
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy Create(string discountType) =>
            discountType.ToLower() switch
            {
                "none" => new NoDiscount(),
                "10percent" => new PercentageDiscount(0.10m),
                "first50" => new FirstOrderDiscount(50m),
                _ => throw new NotSupportedException($"Discount '{discountType}' not supported.")
            };
    }
}
