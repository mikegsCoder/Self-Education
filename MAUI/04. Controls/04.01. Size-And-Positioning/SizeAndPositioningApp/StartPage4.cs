namespace SizeAndPositioningApp
{
    public class StartPage4 : ContentPage
    {
        public StartPage4()
        {
            // set padding top for iOS:
            Label header = new Label() { Text = "Hello from MAUI!" };

            Content = header;

            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
        }
    }
}
