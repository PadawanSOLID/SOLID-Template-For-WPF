using MahApps.Metro.ValueBoxes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RibbonStyle.Converters
{
    public class InverseBoolConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return BooleanBoxes.Box(!(bool)value);
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return BooleanBoxes.Box(!(bool)value);
        }

        public static InverseBoolConverter Instance { get {  return new InverseBoolConverter(); } }

    }
}
