using SOLID_Liskov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov
{
    public class Eagle : Bird, IFlyable
    {
        public  void Fly()
        {
            Console.WriteLine("Eagle is flying high!");
        }
    }

}
