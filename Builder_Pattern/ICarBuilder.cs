using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public interface ICarBuilder
    {
        ICarBuilder Reset();
        ICarBuilder SetModel(string model);
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetGearbox(string gearbox);
        ICarBuilder SetColor(string color);
        ICarBuilder SetWheels(int wheels);
        ICarBuilder AddExtra(string extra);

        Car Build();
    }
}
