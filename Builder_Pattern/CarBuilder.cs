using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new();
        private readonly IBuildTracer _tracer;

        public CarBuilder(IBuildTracer tracer)
        {
            _tracer = tracer;
            Reset();
        }

        public ICarBuilder Reset()
        {
            _car = new Car();
            _tracer.Step("Reset builder (start a new Car).");
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            _car = _car with { Model = model };
            _tracer.Step($"Set Model => {model}");
            return this;
        }

        public ICarBuilder SetEngine(string engine)
        {
            _car = _car with { Engine = engine };
            _tracer.Step($"Set Engine => {engine}");
            return this;
        }

        public ICarBuilder SetGearbox(string gearbox)
        {
            _car = _car with { Gearbox = gearbox };
            _tracer.Step($"Set Gearbox => {gearbox}");
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            _car = _car with { Color = color };
            _tracer.Step($"Set Color => {color}");
            return this;
        }

        public ICarBuilder SetWheels(int wheels)
        {
            _car = _car with { Wheels = wheels };
            _tracer.Step($"Set Wheels => {wheels}");
            return this;
        }

        public ICarBuilder AddExtra(string extra)
        {
            _car.Extras.Add(extra);
            _tracer.Step($"Add Extra => {extra}");
            return this;
        }

        public Car Build()
        {
            // Basic validation to show "builder can enforce rules"
            if (string.IsNullOrWhiteSpace(_car.Model)) throw new InvalidOperationException("Model is required.");
            if (string.IsNullOrWhiteSpace(_car.Engine)) throw new InvalidOperationException("Engine is required.");
            if (string.IsNullOrWhiteSpace(_car.Gearbox)) throw new InvalidOperationException("Gearbox is required.");
            if (string.IsNullOrWhiteSpace(_car.Color)) throw new InvalidOperationException("Color is required.");
            if (_car.Wheels <= 0) throw new InvalidOperationException("Wheels must be set.");

            _tracer.Step("Build() => Final car is ready ✅");
            return _car;
        }
    }

}
