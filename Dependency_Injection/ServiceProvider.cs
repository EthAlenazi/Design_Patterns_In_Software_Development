namespace Dependency_Injection
{

    public class ServiceProvider
    {
        private readonly Dictionary<Type, (Func<ServiceProvider, object> factory, ServiceLifetime lifetime)> _registrations
            = new();

        private readonly Dictionary<Type, object> _singletonCache = new();
        private readonly Dictionary<Type, object> _scopedCache = new();

        // Register factory + lifetime
        public void Register<T>(Func<ServiceProvider, T> factory, ServiceLifetime lifetime)
            where T : class
        {
            _registrations[typeof(T)] = (sp => factory(sp), lifetime);
        }

        // Create a new scope (new scoped cache, same singleton cache)
        public ServiceProvider CreateScope()
        {
            var scoped = new ServiceProvider();
            foreach (var kv in _registrations)
                scoped._registrations[kv.Key] = kv.Value;

            // share singleton cache across scopes
            foreach (var kv in _singletonCache)
                scoped._singletonCache[kv.Key] = kv.Value;

            return scoped;
        }

        // Resolve service
        public T Get<T>() where T : class
        {
            var type = typeof(T);

            if (!_registrations.TryGetValue(type, out var reg))
                throw new InvalidOperationException($"Service not registered: {type.Name}");

            var (factory, lifetime) = reg;

            return lifetime switch
            {
                ServiceLifetime.Singleton => (T)GetOrCreate(_singletonCache, type, () => factory(this)),
                ServiceLifetime.Scoped => (T)GetOrCreate(_scopedCache, type, () => factory(this)),
                ServiceLifetime.Transient => (T)factory(this),
                _ => throw new NotSupportedException()
            };
        }

        private static object GetOrCreate(Dictionary<Type, object> cache, Type type, Func<object> create)
        {
            if (!cache.TryGetValue(type, out var instance))
            {
                instance = create();
                cache[type] = instance;
            }
            return instance;
        }
    }

}
