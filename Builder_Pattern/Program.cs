namespace Builder_Pattern
{
    internal class Program
    {
        static void Main()
        {
            var tracer = new ConsoleBuildTracer();
            var builder = new CarBuilder(tracer);

            try
            {
                var car = CarWizard.Run(builder, tracer);

                Console.WriteLine("\n=== RESULT ===");
                Console.WriteLine(car);

                Console.WriteLine("\n(Notice how the output shows the exact build steps + the final object.)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERROR] {ex.Message}");
            }
        }
    }
}
