using Movie_DB.Commands.Contracts;
using Movie_DB.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";

        public readonly IReader reader;
        public readonly IWriter writer;
        private readonly IParser parser;

        private StringBuilder Builder = new StringBuilder();

        public Engine(IReader reader, IWriter writer, IParser parser)
        {
            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
        }

        public void Start()
        {
            writer.WriteLine("==================================================================================");
            writer.WriteLine("==================================================================================");
            writer.WriteLine(@"___                     __          ___     __       ___       __        __   ___ 
 |  |__/ |        |\/| /  \ \  / | |__     |  \  /\   |   /\  |__)  /\  /__` |__  
 |  |  \ |___     |  | \__/  \/  | |___    |__/ /~~\  |  /~~\ |__) /~~\ .__/ |___ 
                                                                                  ");
            writer.WriteLine("==================================================================================");
            writer.WriteLine("==================================================================================");
            writer.WriteLine("");
            writer.WriteLine("");
            writer.WriteLine("");
            writer.WriteLine("Enter command:...");
            writer.WriteLine("(For help type '/help')");
            writer.WriteLine("");




            while (true)
            {
                //try
                //{
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(this.Builder.ToString());
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                //}
                //catch (Exception ex)
                //{
                //    this.Builder.AppendLine(ex.Message);
                //}
            }
        }
        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var executionResult = command.Execute();
            writer.WriteLine(executionResult);

        }
    }
}
