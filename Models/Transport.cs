using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models 
{ 
    public class Transport : MongoBaseModel
    {
        public String Loading_Address { get; set; }
        public String Unloading_Address { get; set; }
        public DateTime Loading_Tarihi { get; set; }
        public DateTime Unloading_Tarihi { get; set; }
        public String Transport_Vehicle { get; set; }
        public String Customer { get; set; }
        public String Driver { get; set; }
    }
}
