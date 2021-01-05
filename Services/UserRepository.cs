using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class UserRepository : BaseMongoRepository<User>
    {
        public UserRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
