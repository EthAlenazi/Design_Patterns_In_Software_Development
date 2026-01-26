using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    public class ExcelProcessor : DocumentProcessor
    {
        protected override void ProcessContent()
        {
            Console.WriteLine("Processing Excel content...");
        }
    }
}
