using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    //Strategy Interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
