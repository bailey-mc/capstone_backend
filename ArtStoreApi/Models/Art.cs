using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

//namespace used to organize classes and control scope
namespace ArtStoreApi.Models;

public class Art
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string ArtName { get; set; } = null!;

    public string Artist { get; set; } = null!;

    public int Year { get; set; }
    
    public decimal Price { get; set; } 

    //new
    public string Image { get; set; } = null!;

    public string Collection { get; set; } = null!;
}