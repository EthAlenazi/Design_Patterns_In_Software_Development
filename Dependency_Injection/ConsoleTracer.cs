using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class ConsoleTracer: ITracer
    {
        public void New(string typeName, Guid id)
       => Console.WriteLine($"[NEW ] {typeName,-25} Id={id}");

        public void Use(string typeName, Guid id, string action)
            => Console.WriteLine($"[USE ] {typeName,-25} Id={id} :: {action}");

        public void Dispose(string typeName, Guid id)
            => Console.WriteLine($"[DISP] {typeName,-25} Id={id}");
    }
}
