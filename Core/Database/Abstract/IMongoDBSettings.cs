namespace MongoDbDemo.Core.Database.Abstract
{
    public interface IMongoDBSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
