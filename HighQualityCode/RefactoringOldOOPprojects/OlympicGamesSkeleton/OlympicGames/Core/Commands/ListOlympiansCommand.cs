using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string key = "firstname";
        private string order = "asc";

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            if (commandParameters.Count == 1)
            {
                this.key = commandParameters[0];
            }
            if(commandParameters.Count == 2)
            {
                this.key = commandParameters[0];
                this.order = commandParameters[1];
            }
        }

        // Use it. It works!
        public override string Execute()
        {
            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));
            if (sorted.Count >= 1)
            {


                if (this.order.ToLower().Trim() == "desc")
                {
                    sorted = this.Committee.Olympians.OrderByDescending(x =>
                    {
                        return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                    }).ToList();
                }
                else
                {
                    sorted = this.Committee.Olympians.OrderBy(x =>
                    {
                        return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                    }).ToList();
                }

                foreach (var item in sorted)
                {
                    stringBuilder.AppendLine(item.ToString());
                }

                return stringBuilder.ToString();

                }
            else
            {
                return GlobalConstants.NoOlympiansAdded;
            }
        }
    }
}
