using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public record Car
    {
        public string Model { get; init; } = "";
        public string Engine { get; init; } = "";
        public string Gearbox { get; init; } = "";
        public string Color { get; init; } = "";
        public int Wheels { get; init; } 
        public List<string> Extras { get; init; } = new();

        public override string ToString()
            => $"Car => Model={Model}, Engine={Engine}, Gearbox={Gearbox}, Color={Color}, Wheels={Wheels}, Extras=[{string.Join(", ", Extras)}]";
    }
}
