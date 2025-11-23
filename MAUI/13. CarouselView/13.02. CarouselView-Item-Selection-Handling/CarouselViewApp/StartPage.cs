using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselViewApp
{
    public class StartPage : ContentPage
    {
        // CurrentItemChangedCommand example:
        public StartPage()
        {
            Label currentLbl = new Label(); 
            
            CarouselView carouselView = new CarouselView
            {
                VerticalOptions = LayoutOptions.Start
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

            // set command and parameter:
            carouselView.CurrentItemChangedCommand = new Command<Product?>(p =>
            {
                currentLbl.Text = $"You have selected: {p?.Name}";
            });

            carouselView.SetBinding(CarouselView.CurrentItemChangedCommandParameterProperty, new Binding("CurrentItem", source: RelativeBindingSource.Self));
            
            Content = new VerticalStackLayout { currentLbl, carouselView };
        }
    }
}
