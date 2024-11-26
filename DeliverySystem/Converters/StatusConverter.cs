using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DeliverySystem.Converters
{
    public class StatusConverter : IValueConverter
    {
        Dictionary<Status, BitmapImage> cache = new Dictionary<Status, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Status)value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"D:\uni\3 course\1 sem\kpz\DeliverySystem\DeliverySystem\Images\status_{0}.png", status.ToString().ToLower()), UriKind.Absolute);
                cache.Add(status, new BitmapImage(uri));
            }

            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
