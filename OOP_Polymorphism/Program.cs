using System.Collections.Generic;
using System;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cat();
            Animal animal2 = new Dog();

            animal1.MakeSound();
            animal2.MakeSound();

            Console.WriteLine("Done!");
        }
    }


}

