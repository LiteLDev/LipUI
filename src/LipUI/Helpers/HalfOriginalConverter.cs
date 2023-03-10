using System;
using System.Globalization;
using System.Windows.Data;

namespace LipUI.Helpers
{
    internal class HalfOriginalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double original)
                throw new ArgumentException("ExceptionHalfOriginalConverterValueMustBeADouble");
            return original / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double half)
                throw new ArgumentException("ExceptionHalfOriginalConverterValueMustBeADouble");
            return half * 2;
        }
    }
}
