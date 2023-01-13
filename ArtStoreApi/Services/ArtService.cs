using ArtStoreApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ArtStoreApi.Services;

public class ArtService
{
    private readonly IMongoCollection<Art> _artCollection;

    //provides access to appsettings.json mongo database config values
    public ArtService(
        IOptions<ArtStoreDatabaseSettings> artStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            artStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            artStoreDatabaseSettings.Value.DatabaseName);

        _artCollection = mongoDatabase.GetCollection<Art>(
            artStoreDatabaseSettings.Value.ArtCollectionName);
    }
    //find all art
    public async Task<List<Art>> GetAsync() =>
        await _artCollection.Find(_ => true).ToListAsync();
    //find one specific art
    public async Task<Art?> GetAsync(string id) =>
        await _artCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    //create new piece of art
    public async Task CreateAsync(Art newArt) => 
        await _artCollection.InsertOneAsync(newArt);
    //update a piece of art
    public async Task UpdateAsync(string id, Art updatedArt) => 
        await _artCollection.ReplaceOneAsync(x => x.Id == id, updatedArt);
    //delete a piece of art
    public async Task RemoveAsync(string id) => 
        await _artCollection.DeleteOneAsync(x => x.Id == id);
}