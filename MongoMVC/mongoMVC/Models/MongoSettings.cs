using System;

namespace MongoMVC.Models
{
    class MongoSettings
    {

        public string ConnectionURI {get; set;} = "mongodb+srv://rohanAdmin:Adminkangasys@atlascluster.xwsfjaj.mongodb.net/?retryWrites=true&w=majority";
        public string DatabaseName {get; set;} = null!;
        public string CollectionName {get; set;} = null!;

        public void controllerConfig()
        {
            Console.WriteLine("You're in Controller");
        }
    }
}