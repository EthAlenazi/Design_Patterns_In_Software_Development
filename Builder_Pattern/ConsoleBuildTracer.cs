using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class ConsoleBuildTracer : IBuildTracer
    {
        private int _step = 0;

        public void ResetSteps() => _step = 0;

        public void Step(string message)
        {
            _step++;
            Console.WriteLine($"[STEP {_step:00}] {message}");
        }
    }
}
