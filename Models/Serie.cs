using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TvHeaven.Models 
{
    public class Serie 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }    
        public string Title { get; set; }
    }
}