using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models
{
    public class Drivers : MongoBaseModel
    {
        public String Name { get; set; }
        public String SurName { get; set; }
        public String Email { get; set; }
        public int Number { get; set; }
        public int Tc_No { get; set; }
        public int Ehliyet_No { get; set; }
        
    }
}
