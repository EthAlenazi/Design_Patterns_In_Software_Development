using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class WorkFlow1 : IWorkflowStrategy
    {
        public void changeWorkFlow()
        {
            Console.WriteLine("test work 1 ");
        }
    }
}
