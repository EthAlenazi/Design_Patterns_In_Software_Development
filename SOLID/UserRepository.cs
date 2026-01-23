using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class UserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("Saving user to database");
        }
    }

}
