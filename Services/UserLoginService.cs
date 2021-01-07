using DispatchApi.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DispatchApi.Services
{
    public class UserLoginService
    {
        private readonly IMongoCollection<User> _user;
        //private readonly IMongoCollection<ArtType> _articletype;
        public UserLoginService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.MongoConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _user = database.GetCollection<User>("user");
            
        }
        public async Task<List<User>> LoginMethod(String _Email, String _Password)
        {
            /*var controls = collection.AsQueryable<Controls>()
                .Where(x => x.code == code)
                .Select(e => new { e.code, e.Items }).ToList();*/

            var result = await _user.AsQueryable<User>()
                .Where(e => e.Email == _Email && e.Password == _Password).ToListAsync(); 
                
            return result;
        }
    }
}
