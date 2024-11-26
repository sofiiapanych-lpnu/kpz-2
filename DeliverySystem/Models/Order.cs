using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    [DataContract]
    internal class Order
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public double Cost { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
