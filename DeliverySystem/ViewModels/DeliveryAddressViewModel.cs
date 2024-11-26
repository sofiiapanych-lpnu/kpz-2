using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.ViewModels
{
    public class DeliveryAddressViewModel: ViewModelBase
    {
        public int DeliveryAddressId_;
        public string Country_;
        public string City_;
        public string Street_;
        public int BuildingNumber_;
        public int ApartmentNumber_;
        public int Floor_;

        public int DeliveryAddressId
        {
            get { return DeliveryAddressId_; }
            set
            {
                DeliveryAddressId_ = value;
                OnPropertyChange("DeliveryAddressId");
            }
        }
        public string Country
        {
            get { return Country_; }
            set
            {
                Country_ = value;
                OnPropertyChange("Country");
            }
        }
        public string City
        {
            get { return City_; }
            set
            {
                City_ = value;
                OnPropertyChange("City");
            }
        }
        public string Street
        {
            get { return Street_; }
            set
            {
                Street_ = value;
                OnPropertyChange("Street");
            }
        }
        public int BuildingNumber
        {
            get { return BuildingNumber_; }
            set
            {
                BuildingNumber_ = value;
                OnPropertyChange("BuildingNumber");
            }
        }
        public int ApartmentNumber
        {
            get { return ApartmentNumber_; }
            set
            {
                ApartmentNumber_ = value;
                OnPropertyChange("ApartmentNumber");
            }
        }
        public int Floor
        {
            get { return Floor_; }
            set
            {
                Floor_ = value;
                OnPropertyChange("Floor");
            }
        }
    }
}
