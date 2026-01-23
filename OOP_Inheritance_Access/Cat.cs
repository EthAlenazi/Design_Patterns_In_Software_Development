using OOP_Inheritance_Access;

public class Cat : Animal
{
    public void TestInsideDerivedClass()
    {
        // accessible ✅
        PublicMethod();

        // accessible ✅
        ProtectedMethod();

        // ❌ not accessible (private method)
       // PrivateMethod();
    }
}
