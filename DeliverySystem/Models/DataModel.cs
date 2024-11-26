using DeliverySystem.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    [DataContract]
    internal class DataModel
    {
        private static string DataPath = "../data.dat";
        [DataMember]
        public IEnumerable<Courier> Courier { get; set; }
        [DataMember]
        public IEnumerable<Delivery> Delivery { get; set; }
        [DataMember]
        public IEnumerable<DeliveryAddress> DeliveryAddress { get; set; }
        [DataMember]
        public IEnumerable<Order> Order { get; set; }

        DataModel()
        {
            Courier = new List<Courier>()
            {
                new Courier() { CourierId = 1, LicencePlate = "AAAAAAAA"}
            };
            Delivery = new List<Delivery>(){
                new Delivery() { DeliveryId = 1, CourierId = 2, StartTime=DateTime.Parse("10:00:00"), EndTime=DateTime.Parse("13:00:00"), DeliveryAddressId=2, Status=Status.ToDo }
            };
            DeliveryAddress = new List<DeliveryAddress>();
            Order = new List<Order>();
        }
        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeData(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
