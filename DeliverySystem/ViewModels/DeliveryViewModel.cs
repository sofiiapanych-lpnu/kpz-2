using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.ViewModels
{
    public class DeliveryViewModel: ViewModelBase
    {
        public int DeliveryId_;
        public int CourierId_;
        public DateTime StartTime_;
        public DateTime EndTime_;
        public int DeliveryAddressId_;
        public Status Status_;
        public int DeliveryId
        {
            get { return DeliveryId_; }
            set
            {
                DeliveryId_ = value;
                OnPropertyChange("DeliveryId");
            }
        }
        public int CourierId
        {
            get { return CourierId_; }
            set
            {
                CourierId_ = value;
                OnPropertyChange("CourierId");
            }
        }
        public DateTime StartTime
        {
            get { return StartTime_; }
            set
            {
                StartTime_ = value;
                OnPropertyChange("StartTime");
            }
        }
        public DateTime EndTime
        {
            get { return EndTime_; }
            set
            {
                EndTime_ = value;
                OnPropertyChange("EndTime");
            }
        }
        public int DeliveryAddressId
        {
            get { return DeliveryAddressId_; }
            set
            {
                DeliveryAddressId_ = value;
                OnPropertyChange("DeliveryAddressId");
            }
        }
        public Status Status
        {
            get { return Status_; }
            set
            {
                Status_ = value;
                OnPropertyChange("Status");
            }
        }
    }
}

public enum Status
{
    ToDo,
    InProgress,
    Done
}