namespace Dependency_Injection
{
    public interface IOrderProcessor
    {
       public string Type { get; }          // "Standard" or "Express"
       public void Process(string orderId); // order logic
    }
}
