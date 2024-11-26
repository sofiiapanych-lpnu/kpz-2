using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.ViewModels
{
    public class OrderViewModel: ViewModelBase
    {
        public int OrderId_;
        public double Cost_;
        public string Description_;
        public int OrderId
        {
            get { return OrderId_; }
            set
            {
                OrderId_ = value;
                OnPropertyChange("OrderId");
            }
        }
        public double Cost
        {
            get { return Cost_; }
            set
            {
                Cost_ = value;
                OnPropertyChange("Cost");
            }
        }
        public string Description
        {
            get { return Description_; }
            set
            {
                Description_ = value;
                OnPropertyChange("Description");
            }
        }
    }
}
