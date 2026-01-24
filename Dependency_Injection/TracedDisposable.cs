using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public abstract class TracedDisposable : IDisposable
    {
        protected readonly ITracer Tracer;
        protected readonly Guid Id = Guid.NewGuid();
        protected abstract string TypeName { get; }

        protected TracedDisposable(ITracer tracer)
        {
            Tracer = tracer;
            Tracer.New(TypeName, Id);
        }

        protected void TraceUse(string action) => Tracer.Use(TypeName, Id, action);

        public void Dispose() => Tracer.Dispose(TypeName, Id);
    }
}
