namespace ImageApp
{
    public class StartPage4 : ContentPage
    {
        // Image from embedded resource example:
        public StartPage4()
        {
            Image image = new Image
            {
                Source = ImageSource.FromResource("ImageApp.Resources.Images.forest1.jpg")
            };

            Content = image;
        }
    }
}
