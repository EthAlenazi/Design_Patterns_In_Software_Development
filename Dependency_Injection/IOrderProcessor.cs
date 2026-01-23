using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IOrderProcessor
    {
       public string Type { get; }          // "Standard" or "Express"
       public void Process(string orderId); // order logic
    }
}
