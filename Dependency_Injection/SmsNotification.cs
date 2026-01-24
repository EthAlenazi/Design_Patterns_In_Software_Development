namespace Dependency_Injection
{
    public class SmsNotification : TracedDisposable, INotificationService
    {
        protected override string TypeName => "INotification(SMS)";
        public SmsNotification(ITracer tracer) : base(tracer) { }

        public void Send(string msg) => TraceUse(msg);
    }
}
