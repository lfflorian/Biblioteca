using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Biblioteca.Models
{
    public class ConfigDB
    {
        private MongoClient client;
        private IMongoDatabase database;

        public ConfigDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("Biblioteca");
        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }
    }
}