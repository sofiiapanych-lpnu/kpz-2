using AutoMapper;
using DeliverySystem.Models;
using DeliverySystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows;

namespace DeliverySystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _dataModel;
        private DataViewModel _dataViewModel;
        private IMapper _mapper;
        public IMapper GetMapper()
        {
            return _mapper;
        }
        public App()
        {
            InitializeAutoMapper();

            _dataModel = DataModel.Load();
            _dataViewModel = _mapper.Map<DataViewModel>(_dataModel);

            var window = new MainWindow() { DataContext = _dataViewModel };
            window.InitializeComponent();
            window.Show();

        }
        protected override void OnExit(ExitEventArgs e)
        {
            _dataModel = _mapper.Map<DataModel>(_dataViewModel);
            _dataModel.Save();
            base.OnExit(e);
        }
        private void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Courier, CourierViewModel>();
                cfg.CreateMap<CourierViewModel, Courier>();

                cfg.CreateMap<DeliveryAddress, DeliveryAddressViewModel>();
                cfg.CreateMap<DeliveryAddressViewModel, DeliveryAddress>();

                cfg.CreateMap<Delivery, DeliveryViewModel>();
                cfg.CreateMap<DeliveryViewModel, Delivery>();

                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<OrderViewModel, Order>();
            });

            _mapper = config.CreateMapper();
        }
    }
}
