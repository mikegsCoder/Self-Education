using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterPropertiesApp.Converters
{
    public class StringToStatusConverter : IValueConverter
    {
        public string ApprovedStatus { get; set; } = "Approved";
        public string DeniedStatus { get; set; } = "Denied";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string username = (string)value;

            if (username == "admin") return ApprovedStatus;

            return DeniedStatus;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value.ToString();

            if (status == ApprovedStatus) return "admin";

            return "user";
        }
    }
}
