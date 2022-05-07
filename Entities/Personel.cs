using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbDemo.Entities
{
    public class Personel 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
    }
}
