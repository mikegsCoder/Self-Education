namespace ImageApp
{
    public class StartPage1 : ContentPage
    {
        // Image FromFile example:
        public StartPage1()
        {
            // example 1:
            //Image image = new Image
            //{
            //    Source = ImageSource.FromFile("forest.jpg")
            //};

            // example 2:
            Image image = new Image { Source = "forest.jpg" };

            Content = image;
        }
    }
}
