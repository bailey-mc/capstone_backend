using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

//namespace used to organize classes and control scope
namespace ArtStoreApi.Models;

public class Art
{
    [BsonId]
    //Bson id makes this property the documet's primary key
    [BsonRepresentation(BsonType.ObjectId)]
    //this allows passing the parameter as a string instead of objectId -> mongo will convert string to object id
    public string? Id { get; set; }

    [BsonElement("Name")]
    //The attribute's value of "Name" represents the property name in the MongoDB collection
    public string ArtName { get; set; } = null!;

    public string Artist { get; set; } = null!;

    public int Year { get; set; }
    
    public decimal Price { get; set; } 

    //new
    public string Image { get; set; } = null!;

    public string Collection { get; set; } = null!;
}