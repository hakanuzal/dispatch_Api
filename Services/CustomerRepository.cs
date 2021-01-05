using DispatchApi.Models;


namespace DispatchApi.Services
{
    public class CustomerRepository : BaseMongoRepository<Customer>
    {
        public CustomerRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
