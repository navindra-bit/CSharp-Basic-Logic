using System.Globalization;
using System.Windows.Data;

namespace MVVM.View.Helper
{
    public class NoRadioValueConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)return false;
             if (value.ToString().ToUpper() == "NO") return true;
            else return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolvvalue)
                return boolvvalue ? "No" : "Yes";
            return "Yes";
        }
    }
}
