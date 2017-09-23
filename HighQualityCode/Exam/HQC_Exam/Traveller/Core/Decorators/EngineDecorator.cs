using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Providers.Contracts;

namespace Traveller.Commands.Decorators
{
    public class EngineDecorator : IEngine
    {
        private readonly IEngine engine;

        public EngineDecorator(IEngine engine)
        {
            Guard.WhenArgument(engine, "engine").IsNull().IsNull();
            this.engine = engine;
        }

        public void Start()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("The Engine is starting...");
            stopwatch.Start();
            engine.Start();
            stopwatch.Stop();
            Console.WriteLine("The Engine worked for {0} milliseconds.", stopwatch.ElapsedMilliseconds);
        }
    }
}
