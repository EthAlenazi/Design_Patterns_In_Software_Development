using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface ITracer
    {
        void New(string typeName, Guid id);
        void Use(string typeName, Guid id, string action);
        void Dispose(string typeName, Guid id);
    }
}
