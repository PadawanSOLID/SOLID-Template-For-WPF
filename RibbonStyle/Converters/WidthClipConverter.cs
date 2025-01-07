using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace RibbonStyle.Converters
{
    public class WidthClipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double width = (double)value;
            string path = $"M0 0 A4,4 90 0,1 4,4 V24 A4,4 90 0,0  8,28 H{width - 8} A4,4 90 0,0  {width - 4},24 V4 A4,4 90 0,1 {width},0Z";
            return path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
