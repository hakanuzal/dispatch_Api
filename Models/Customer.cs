using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models
{
    public class Customer : MongoBaseModel
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Tc_No { get; set; }
        public String Email { get; set; }
        public String Company_Name { get; set; }
        public String City { get; set; }
        public String Number { get; set; }

    }
}
