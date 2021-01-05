using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class TransportRepository : BaseMongoRepository<Transport>
    {
        public TransportRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
