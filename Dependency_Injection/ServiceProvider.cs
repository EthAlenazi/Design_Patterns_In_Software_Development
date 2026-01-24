namespace Dependency_Injection
{

    public class ServiceProvider : IDisposable
    {
        private readonly Dictionary<Type, (Func<ServiceProvider, object> factory, ServiceLifetime lifetime)> _registrations;
        private readonly Dictionary<Type, object> _singletonCache;
        private readonly Dictionary<Type, object> _scopedCache;

        private readonly ITracer _tracer; // for container tracing (safe: injected externally)
        private bool _disposed;

        // Root container
        public ServiceProvider(ITracer tracer)
        {
            _tracer = tracer;

            _registrations = new();
            _singletonCache = new();
            _scopedCache = new(); // root scope cache (usually unused, but safe)

            Trace("ROOT", "Container created");
        }

        // Private ctor for scopes (shares registrations + singleton cache, new scoped cache)
        private ServiceProvider(
            Dictionary<Type, (Func<ServiceProvider, object> factory, ServiceLifetime lifetime)> regs,
            Dictionary<Type, object> singletonCache,
            ITracer tracer,
            string scopeName)
        {
            _registrations = regs;
            _singletonCache = singletonCache;
            _scopedCache = new();
            _tracer = tracer;

            Trace(scopeName, "Scope created");
        }

        // Register
        public void Register<T>(Func<ServiceProvider, T> factory, ServiceLifetime lifetime)
            where T : class
        {
            _registrations[typeof(T)] = (sp => factory(sp), lifetime);
            Trace("REG", $"{typeof(T).Name} => {lifetime}");
        }

        // Create scope
        public ServiceProvider CreateScope(string name = "SCOPE")
            => new ServiceProvider(_registrations, _singletonCache, _tracer, name);

        // Resolve
        public T Get<T>() where T : class
        {
            var type = typeof(T);

            if (!_registrations.TryGetValue(type, out var reg))
                throw new InvalidOperationException($"Service not registered: {type.Name}");

            var (factory, lifetime) = reg;
            Trace("RES", $"{type.Name} ({lifetime})");

            return lifetime switch
            {
                ServiceLifetime.Singleton => (T)GetOrCreate(_singletonCache, type, () => factory(this), "Singleton"),
                ServiceLifetime.Scoped => (T)GetOrCreate(_scopedCache, type, () => factory(this), "Scoped"),
                ServiceLifetime.Transient => (T)CreateTransient(type, factory),
                _ => throw new NotSupportedException($"Lifetime not supported: {lifetime}")
            };
        }

        private object CreateTransient(Type type, Func<ServiceProvider, object> factory)
        {
            Trace("NEW", $"{type.Name} (Transient)");
            return factory(this);
        }

        private object GetOrCreate(
            Dictionary<Type, object> cache,
            Type type,
            Func<object> create,
            string cacheName)
        {
            if (cache.TryGetValue(type, out var existing))
            {
                Trace("HIT", $"{type.Name} from {cacheName} cache");
                return existing;
            }

            Trace("MISS", $"{type.Name} -> create ({cacheName})");
            var instance = create();
            cache[type] = instance;
            return instance;
        }

        // Dispose scope (dispose scoped instances only)
        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;

            Trace("DISP", "Disposing scoped instances...");

            foreach (var obj in _scopedCache.Values)
                if (obj is IDisposable d) d.Dispose();

            _scopedCache.Clear();
        }

        private void Trace(string tag, string msg)
        {
            // Container tracing only (not service tracing)
            Console.WriteLine($"[{tag,-4}] {msg}");
        }
    }
}
