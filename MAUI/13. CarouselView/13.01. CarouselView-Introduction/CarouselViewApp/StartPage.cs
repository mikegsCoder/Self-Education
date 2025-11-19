namespace CarouselViewApp
{
    public class StartPage : ContentPage
    {
        // CarouselView example:
        public StartPage()
        {
            CarouselView carouselView = new CarouselView
            {
                VerticalOptions = LayoutOptions.Start,
            };

            carouselView.ItemsSource = new List<Product>
            {
                new Product {Name="Huawei", ImagePath="huawei.jpg", Description = "Huawei phone description ..." },
                new Product {Name="iPhone", ImagePath="iphone.jpg", Description = "iPhone phone description ..." },
                new Product {Name="Xiaomi", ImagePath="xiaomi.jpg", Description = "Xiaomi phone description ..." },
            };

            // set data template:
            carouselView.ItemTemplate = new DataTemplate(() =>
            {
                Label header = new Label
                {
                    FontAttributes = FontAttributes.Bold,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 18
                };

                header.SetBinding(Label.TextProperty, "Name");

                Image image = new Image { WidthRequest = 150, HeightRequest = 150 };
                image.SetBinding(Image.SourceProperty, "ImagePath");

                Label description = new Label { HorizontalTextAlignment = TextAlignment.Center };
                description.SetBinding(Label.TextProperty, "Description");

                StackLayout stackLayout = new StackLayout() { header, image, description };
                
                Border border = new Border();
                border.Content = stackLayout;

                return border;
            });


            Content = carouselView;
        }
    }
}
