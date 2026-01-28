using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Multiple.Patterns.Models
{
    public record Order(string Id, decimal Amount, string CustomerName, bool IsFirstOrder);

}
