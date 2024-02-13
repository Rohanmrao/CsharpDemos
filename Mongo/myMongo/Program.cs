using System.Text.Json;
using System.Text.Json.Nodes;
using System;
using System.IO;

public class mongoConfig
{
    public string mongoconnectionString { get; set; }
}
namespace ProgramMongo
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string jsonString = File.ReadAllText("mongoConfig.json");
            mongoConfig myconfigObj = JsonSerializer.Deserialize<mongoConfig>(jsonString);

            Console.WriteLine($" The connection string is {myconfigObj.mongoconnectionString}");
        }
    }

}

