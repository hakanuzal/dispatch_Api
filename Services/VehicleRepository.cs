using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class VehicleRepository : BaseMongoRepository<Vehicle>
    {
        public VehicleRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
