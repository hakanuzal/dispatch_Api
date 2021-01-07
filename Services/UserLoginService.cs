using DispatchApi.Models;
using DispatchApi.Validations;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<string> LoginMethod(Authentication authentication)
        {
            /*var controls = collection.AsQueryable<Controls>()
                .Where(x => x.code == code)
                .Select(e => new { e.code, e.Items }).ToList();*/
            var validator = new UserValidator();
            var validate_result = validator.Validate(authentication);
            if (validate_result.IsValid)
            {
                var result = await _user.AsQueryable<User>()
                            .Where(e => e.Email == authentication.Email &&
                            e.Password == authentication.Password).ToListAsync();
                if (result.Count > 0)
                {
                    return "OK";
                }
                else
                {
                    return "BAD";
                }
                
            }
            else
            {
                return validate_result.Errors.FirstOrDefault().ErrorMessage;
            }
          
        }
    }
}
