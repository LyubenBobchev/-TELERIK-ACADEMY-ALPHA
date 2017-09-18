using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ninject;

namespace TEST
{
    class Program
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new Module());
            var greeting = kernel.Get<IGreeting>();
            greeting.Exclaim();
            var messageWriter = kernel.Get<IMessageWriter>("FileMessageWriter");
            messageWriter.Write("I am File Writer");
        }
    }

    public class Greeting : IGreeting
    {
        private readonly IMessageWriter messageWriter;
        public Greeting(IMessageWriter messageWriter)
        {
            this.messageWriter = messageWriter;
        }

        public void Exclaim()
        {
            this.messageWriter.Write("YEAAAAAH BABY!");
        }
    }

    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class FileMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter("text.txt "))
            {
                writer.Write(message);
            }
        }
    }
}


