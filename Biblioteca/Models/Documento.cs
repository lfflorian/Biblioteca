using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Documento
    {
        IMongoCollection<Documento> collection;
        ConfigDB conf;

        [BsonElement("Id")]
        public int Id { get; set; }
        [BsonElement("Nombre")]
        public string Nombre { get; set; }
        [BsonElement("Descripcion")]
        public string Descripcion { get; set; }
        
        public Documento()
        {
            conf = new ConfigDB();
            collection = conf.GetDatabase().GetCollection<Documento>("Documento");
        }

        public void Guardar()
        {
            collection.InsertOneAsync(this);
        }

        public Documento BuscarDocumento()
        {
            var rrr = collection.Find(x => x.Id == this.Id).ToListAsync();
            return collection.Find(x => x.Id == this.Id).ToList()[0];
        }

        public void DevolverDocumentos()
        {
            var collectddion = conf.GetDatabase().GetCollection<BsonDocument>("Documento");
            var raas = 0;
        }
    }
}