using CarAssetApp.Models;
using MongoDB.Driver;

namespace CarAssetApp.Services
{
    public class AssetService
    {
        private readonly IMongoCollection<Asset> _assets;

        public AssetService(MongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _assets = database.GetCollection<Asset>(settings.AssetCollectionName);
        }

        public List<Asset> Get() =>
            _assets.Find(asset => true).ToList();

        public Asset Get(string id) =>
            _assets.Find<Asset>(asset => asset.Id == id).FirstOrDefault()!;

        public Asset Create(Asset asset)
        {
            _assets.InsertOne(asset);
            return asset;
        }
    }
}
