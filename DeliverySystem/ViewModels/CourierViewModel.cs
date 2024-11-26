using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.ViewModels
{
    public class CourierViewModel: ViewModelBase
    {
        public int CourierId_;
        public string LicencePlate_;
        public int CourierId
        {
            get { return CourierId_; }
            set
            {
                CourierId_ = value;
                OnPropertyChange("CourierId");
            }
        }
        public string LicencePlate
        {
            get { return LicencePlate_; }
            set
            {
                LicencePlate_ = value;
                OnPropertyChange("LicencePlate");
            }
        }
    }
}
