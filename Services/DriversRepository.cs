using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class DriversRepository : BaseMongoRepository<Drivers>
    {
        public DriversRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
