namespace OOP_Inheritance_Access
{
    public class Animal
    {
        // public: accessible from anywhere
        public void PublicMethod()
        {
            Console.WriteLine("Public Method: We can access it from anywhere.");
        }

        // private: accessible only within the same class
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method: We can access it only within the class scope.");
        }

        // protected: accessible within the same class or inherited child classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method: We can access it within the class or its derived classes.");
        }

        // caller method inside the parent class to call all the above methods
        public void TestInsideBaseClass()
        {
            PublicMethod();
            PrivateMethod();
            ProtectedMethod();
        }
    }
}


