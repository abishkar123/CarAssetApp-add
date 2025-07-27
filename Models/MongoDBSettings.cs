namespace CarAssetApp.Models
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string AssetCollectionName { get; set; } = null!;
    }
}
