using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    public abstract class DocumentProcessor
    {
        // Template Method
        public void ProcessDocument()
        {
            OpenDocument();
            ValidateDocument();
            ProcessContent();     // <-- varies
            SaveDocument();
            Log();
        }

        protected virtual void OpenDocument()
        {
            Console.WriteLine("Opening document...");
        }

        protected virtual void ValidateDocument()
        {
            Console.WriteLine("Validating document...");
        }

        protected abstract void ProcessContent();// here we can modifiying 

        protected virtual void SaveDocument()
        {
            Console.WriteLine("Saving document...");
        }

        protected void Log()
        {
            Console.WriteLine("Process completed.\n");
        }
    }

}
