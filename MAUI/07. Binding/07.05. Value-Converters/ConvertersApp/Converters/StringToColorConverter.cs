using System.Globalization;

namespace ConvertersApp.Converters
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string colorStr = value?.ToString().Trim().ToLower();

            switch (colorStr)
            {
                case "red": return Colors.Red;
                case "green": return Colors.Green;
                case "blue": return Colors.Blue;
                default: return Colors.Gray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as Color;
            var colorHex = color.ToHex();

            switch (colorHex)
            {
                case "#FF0000": return "red";
                case "#00FF00": return "green";
                case "#0000FF": return "blue";
                default: return "gray";
            }
        }
    }
}
