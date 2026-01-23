namespace OOP_Inheritance_Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();

            // accessible ✅
            myCat.PublicMethod();

            // ❌ not accessible (protected method)
            // myCat.ProtectedMethod();

            // ❌ not accessible (private method)
            // myCat.PrivateMethod();

            Console.WriteLine("Program finished");
        }

    }
}

