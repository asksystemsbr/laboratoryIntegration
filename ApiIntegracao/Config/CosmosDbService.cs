using Microsoft.Azure.Cosmos;

namespace ApiIntegracaoLab.Config
{
    public class CosmosDbService
    {
        private CosmosClient _client;
        private Database _database;
        private Container _container;

        public CosmosDbService(string account, string key, string databaseId, string containerId)
        {
            _client = new CosmosClient(account, key);
            _database = _client.GetDatabase(databaseId);
            _container = _database.GetContainer(containerId);
        }

        public async Task AddDocumentAsync<T>(T document,string partition)
        {
           var response = await _container.CreateItemAsync(document, new PartitionKey(partition));
        }
    }
}
