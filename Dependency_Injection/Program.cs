namespace Dependency_Injection
{
    internal class Program
    {
        static void Main()
        {
            // Build root container
            var container = AppDependencies.BuildContainer();

            Console.WriteLine("\n=== Scope #1 ===");
            using (var scope1 = container.CreateScope("S1"))
            {
                var s1_a = scope1.Get<OrderService>();
                var s1_b = scope1.Get<OrderService>();

                // Same OrderService instance (Scoped)
                s1_a.CreateOrder();
                s1_b.CreateOrder();
            }
            // Scoped services are disposed here

            Console.WriteLine("\n=== Scope #2 ===");
            using (var scope2 = container.CreateScope("S2"))
            {
                var s2 = scope2.Get<OrderService>();

                // New OrderService instance (new scope)
                s2.CreateOrder();
            }
            // Scoped services are disposed here
        }
    }


}
