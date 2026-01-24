namespace Dependency_Injection
{
    public static class AppDependencies
    {
        public static ServiceProvider BuildContainer()
        {
            // tracer instance one object we will use it for all 
            var tracer = new ConsoleTracer();

            var container = new ServiceProvider(tracer);

            // Register same tracer instance as Singleton
            container.Register<ITracer>(_ => tracer, ServiceLifetime.Singleton);

            container.Register<ILogger>(sp => new ConsoleLogger(sp.Get<ITracer>()), ServiceLifetime.Singleton);

            // Registering the same interface twice will override the previous one
            // container.Register<INotificationService>(sp => new EmailNotification(sp.Get<ITracer>()), ServiceLifetime.Transient);
            container.Register<INotificationService>(sp => new SmsNotification(sp.Get<ITracer>()), ServiceLifetime.Scoped);

            container.Register<OrderService>(sp =>
                new OrderService(
                    sp.Get<INotificationService>(),
                    sp.Get<ILogger>(),
                    sp.Get<ITracer>()),
                ServiceLifetime.Scoped);

            return container;
        }
    }

}




