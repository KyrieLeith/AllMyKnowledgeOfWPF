using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace lab9.Converters
{
    [ValueConversion(typeof(bool), typeof(string))]
    public class SplitStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            bool booleanValue = (bool)value;
            return booleanValue ? "Отправлено" : "Не отправлено";
        }
        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return null;
        }
    }
}
