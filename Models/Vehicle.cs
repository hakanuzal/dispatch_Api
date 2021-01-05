using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchApi.Models
{
    public class Vehicle : MongoBaseModel
    {
        public String Marka { get; set; }
        public String Plaka { get; set; }
        public int Model { get; set; }
        public String chassis_Number { get; set; }
        public String Engine_Number { get; set; }
    }
}
