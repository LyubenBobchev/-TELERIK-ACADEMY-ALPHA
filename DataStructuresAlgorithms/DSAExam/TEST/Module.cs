using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace TEST
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessageWriter>().To<ConsoleMessageWriter>().Named("ConsoleMessageWriter");
           // this.Bind<IMessageWriter>().To<FileMessageWriter>().WhenInjectedInto<Greeting>(); if we bind an interface to more than one class//=> or
            //=>
            this.Bind<IMessageWriter>().To<FileMessageWriter>().Named("FileMessageWriter"); 
            this.Bind<IGreeting>().To<Greeting>()
                .WithConstructorArgument
                (this.Kernel.Get<IMessageWriter>("ConsoleMessageWriter"));
        }
    }
}
