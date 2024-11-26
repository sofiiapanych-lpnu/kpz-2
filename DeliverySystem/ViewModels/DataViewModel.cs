using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            ChangeStatus_ = new Command(ChangeStatus);
        }
        private string visibleControl_ = "Delivery";

        public string VisibleControl
        {
            get { return visibleControl_; }
            set
            {
                visibleControl_ = value;
                OnPropertyChange("visibleControl");
            }
        }
        public Command ChangeStatus_ { get; set; }

        public void ChangeStatus(object args)
        {
            if (SelectedDelivery != null)
            {
                SelectedDelivery.Status = (Status)(((int)SelectedDelivery.Status + 1) % Enum.GetValues(typeof(Status)).Length);
            }
        }
        public Command SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        private CourierViewModel _SelectedCourier;
        public CourierViewModel SelectedCourier
        {
            get { return _SelectedCourier; }
            set
            {
                _SelectedCourier = value;
                OnPropertyChange("SelectedCourier");
            }
        }

        private DeliveryAddressViewModel _SelectedDeliveryAddress;
        public DeliveryAddressViewModel SelectedDeliveryAddress
        {
            get { return _SelectedDeliveryAddress; }
            set
            {
                _SelectedDeliveryAddress = value;
                OnPropertyChange("SelectedDeliveryAddress");
            }
        }

        private DeliveryViewModel _SelectedDelivery;
        public DeliveryViewModel SelectedDelivery
        {
            get { return _SelectedDelivery; }
            set
            {
                _SelectedDelivery = value;
                OnPropertyChange("SelectedDelivery");
            }
        }
        private OrderViewModel _SelectedOrder;
        public OrderViewModel SelectedOrder
        {
            get { return _SelectedOrder; }
            set
            {
                _SelectedOrder = value;
                OnPropertyChange("SelectedOrder");
            }
        }

        private ObservableCollection<CourierViewModel> _Courier;
        public ObservableCollection<CourierViewModel> Courier
        {
            get { return _Courier; }
            set
            {
                _Courier = value;
                OnPropertyChange("Courier");
            }
        }
        private ObservableCollection<DeliveryAddressViewModel> _DeliveryAddress;
        public ObservableCollection<DeliveryAddressViewModel> DeliveryAddress
        {
            get { return _DeliveryAddress; }
            set
            {
                _DeliveryAddress = value;
                OnPropertyChange("DeliveryAddress");
            }
        }
        private ObservableCollection<DeliveryViewModel> _Delivery;
        public ObservableCollection<DeliveryViewModel> Delivery
        {
            get { return _Delivery; }
            set
            {
                _Delivery = value;
                OnPropertyChange("Delivery");
            }
        }
        private ObservableCollection<OrderViewModel> _Order;
        public ObservableCollection<OrderViewModel> Order
        {
            get { return _Order; }
            set
            {
                _Order = value;
                OnPropertyChange("Order");
            }
        }
    }
}
