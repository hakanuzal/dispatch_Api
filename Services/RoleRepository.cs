using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class RoleRepository : BaseMongoRepository<Role>
    {
        public RoleRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
