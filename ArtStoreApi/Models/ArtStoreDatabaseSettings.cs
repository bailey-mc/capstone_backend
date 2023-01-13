namespace ArtStoreApi.Models;

public class ArtStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string ArtCollectionName { get; set; } = null!;
}