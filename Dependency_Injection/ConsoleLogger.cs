namespace Dependency_Injection
{
    public class ConsoleLogger : TracedDisposable, ILogger
    {
        protected override string TypeName => "ILogger(ConsoleLogger)";
        public ConsoleLogger(ITracer tracer) : base(tracer) { }

        public void Log(string message) => TraceUse(message);
    }

}
