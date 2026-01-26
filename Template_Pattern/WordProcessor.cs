using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    public class WordProcessor : DocumentProcessor
    {
        protected override void ProcessContent()
        {
            Console.WriteLine("Processing Word content...");
        }
    }

}
