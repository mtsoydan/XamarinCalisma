using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;
using System.Globalization;

namespace Hafta3Xamarin.Data
{
    class imageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("Hafta3Xamarin.images." + value);

            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
