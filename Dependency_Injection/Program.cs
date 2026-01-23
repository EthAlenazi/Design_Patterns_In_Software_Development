namespace Dependency_Injection
{
    internal class Program
    {
        static void Main()
        {
            var container = AppDependencies.BuildContainer();

            Console.WriteLine("=== Scope #1 ===");
            var scope1 = container.CreateScope();
            var s1_a = scope1.Get<OrderService>();
            var s1_b = scope1.Get<OrderService>();
            s1_a.CreateOrder();
            s1_b.CreateOrder(); // same OrderService (Scoped)

            Console.WriteLine("\n=== Scope #2 ===");
            var scope2 = container.CreateScope();
            var s2 = scope2.Get<OrderService>();
            s2.CreateOrder(); // OrderService New (Scope New)

          
        }
    }


}
