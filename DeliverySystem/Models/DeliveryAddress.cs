using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    [DataContract]
    internal class DeliveryAddress
    {
        [DataMember]
        public int DeliveryAddressId { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public int BuildingNumber { get; set; }
        [DataMember]
        public int ApartmentNumber { get; set; }
        [DataMember]
        public int Floor { get; set; }
    }
}
