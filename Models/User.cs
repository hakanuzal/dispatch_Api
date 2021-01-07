using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models
{
    public class User : MongoBaseModel
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
    }
}
