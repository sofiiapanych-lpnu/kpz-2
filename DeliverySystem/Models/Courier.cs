using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    [DataContract]
    internal class Courier
    {
        [DataMember]
        public int CourierId { get; set; }
        [DataMember]
        public string LicencePlate { get; set; }
    }
}
