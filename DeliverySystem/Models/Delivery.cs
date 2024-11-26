using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    [DataContract]
    internal class Delivery
    {
        [DataMember]
        public int DeliveryId { get; set; }
        [DataMember]
        public int CourierId { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        public int DeliveryAddressId { get; set; }
        [DataMember]
        public Status Status { get; set; }
    }
}