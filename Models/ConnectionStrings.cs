using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models
{
    public class ConnectionStrings : IDatabaseSettings
    {
        //public string CollectionName { get; set; }
        public string MongoConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IDatabaseSettings
    {
        //public string CollectionName { get; set; }
        public string MongoConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}