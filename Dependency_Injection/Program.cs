namespace Dependency_Injection
{
    internal class Program
    {
        static void Main()
        
       {

            var orderService = AppDependencies.CreateOrderService();
            orderService.CreateOrder();
        }
    }

}
