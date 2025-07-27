using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarAssetApp.Models
{
    public class Asset
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ModelName")]
        public string ModelName { get; set; } = null!;

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("CarNumber")]
        public string CarNumber { get; set; } = null!;
    }
}
