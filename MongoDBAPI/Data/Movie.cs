using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBAPI.Data
{
    public class Movie
    {
        //Serilaized
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Summary { get; set; } = null;
        public List<string> Actors { get; set; }

    }
}
