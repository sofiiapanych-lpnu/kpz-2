﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeliverySystem.Views
{
    /// <summary>
    /// Interaction logic for DeliveryUserControl.xaml
    /// </summary>
    public partial class DeliveryUserControl : UserControl
    {
        public DeliveryUserControl()
        {
            InitializeComponent();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Image image)
            {
                Storyboard storyboard = (Storyboard)this.Resources["ImageClickAnimation"];
                storyboard.Begin(image);
            }
        }

    }
}
