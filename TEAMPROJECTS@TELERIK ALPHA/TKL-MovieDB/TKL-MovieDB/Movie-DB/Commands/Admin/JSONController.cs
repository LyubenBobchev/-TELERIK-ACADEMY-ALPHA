using Models.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Movie_DB.Commands.Admin
{
    public class JSONController
    {
        public static void ReturnJSON(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine();
            Console.WriteLine(json, Formatting.Indented);
        }

        public static void SaveToFile(Object obj)
        {
            string url = @"D:\______SOFTDEVELOP\__TELERIK\ALPHA\SQL_DB\DB-TeamProject\TKL-MovieDB\Movie-DB\Data\saved.json";
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(url, json);
        }

        //public static Object LoadFromFile(string  url)
        //{
        //    Object objectFromFile = 
        //}

        // var json = JsonConvert.DeserializeObject(obj);

        public static Genre[] ReadGenresFromJSON()
        {
            var url = @"D:\______SOFTDEVELOP\__TELERIK\ALPHA\SQL_DB\DB-TeamProject\TKL-MovieDB\Movie-DB\Data\GenresData.json";
            var json = File.ReadAllText(url);
            var jsonObject = JObject.Parse(json);
            int count = jsonObject.Value<int>("count");
            Genre[] genres = new Genre[count];

            genres = jsonObject["genres"].Select(g => new Genre() { Name = g.Value<string>("name") }).ToArray();

            //foreach(var g in genres)
            //{
            //    Console.WriteLine(g.Name);
            //}
            return genres;
        }

        public static Person[] ReadPersonsFromJSON()
        {
            var url = @"D:\______SOFTDEVELOP\__TELERIK\ALPHA\SQL_DB\DB-TeamProject\TKL-MovieDB\Movie-DB\Data\PersonsData.json";
            var json = File.ReadAllText(url);
            var jsonObject = JObject.Parse(json);
            int count = jsonObject.Value<int>("count");
            Person[] persons = new Person[count];

            persons = jsonObject["persons"]
                .Select(p => new Person()
                { FirstName = p.Value<string>("firstName"),
                LastName = p.Value<string>("lastName"),
                    Job = p.Value<string>("job"),
                    Movie=p.Value<string>("movie")
                }).ToArray();

            //foreach(var g in genres)
            //{
            //    Console.WriteLine(g.Name);
            //}
            return persons;
        }
    }
}
