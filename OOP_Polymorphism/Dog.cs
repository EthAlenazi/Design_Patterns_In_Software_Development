using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Bark");
        }
    }


}


