namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var config1 = AppConfig.Instance;
            var config2 = AppConfig.Instance;

            Console.WriteLine(config1.Environment);
            Console.WriteLine(config2.ConnectionString);

            Console.WriteLine(
                ReferenceEquals(config1, config2)
            );
        }
    }

}
