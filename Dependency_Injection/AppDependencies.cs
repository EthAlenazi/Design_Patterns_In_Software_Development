namespace Dependency_Injection
{
    public static class AppDependencies
    {
        public static ServiceProvider BuildContainer()
        {
            var container = new ServiceProvider();

            container.Register<ILogger>(_ => new ConsoleLogger(), ServiceLifetime.Singleton);

            container.Register<INotificationService>(_ => new EmailNotification(), ServiceLifetime.Transient);
            container.Register<INotificationService>(_ => new EmailNotification(), ServiceLifetime.Scoped);

            container.Register<OrderService>(sp =>
                new OrderService(sp.Get<INotificationService>(), sp.Get<ILogger>()),
                ServiceLifetime.Scoped);

            return container;
        }
    }

}

