namespace ArtStoreApi.Models;

public class ArtStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string ArtCollectionName { get; set; } = null!;
}

//the ArtStoreDatabaseSettings class is used to store the ArtStoreDatabase property values from appsettings.json . the C# and JSON property names are identical to ease mapping process