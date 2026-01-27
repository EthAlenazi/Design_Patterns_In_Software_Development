using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public enum CheckoutFlowType
    {
        Simple,     // Validate → Pay
        Audited     // Log → Validate → Pay → Notify
    }

}
