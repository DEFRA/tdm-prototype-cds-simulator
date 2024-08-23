using MongoDB.Driver;

namespace TdmPrototypeCdsSimulator.Data;

public interface IMongoDbClientFactory
{
    protected IMongoClient CreateClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}