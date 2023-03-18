using System.Windows;

namespace CustomProperties
{
    public class Phone : DependencyObject
    {
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PriceProperty;

        // static constructor:
        static Phone()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Phone));

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Phone), metadata,
                new ValidateValueCallback(ValidateValue));
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;

            if (currentValue > 1000)
            {
                return 1000;
            }

            return currentValue;
        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;

            if (currentValue >= 0)
            {
                return true;
            }

            return false;
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
    }
}
