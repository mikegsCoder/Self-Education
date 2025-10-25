namespace ImgViewCellApp
{
    public class StartPage : ContentPage
    {
        // ImageCell example:
        public StartPage()
        {
            ListView listView = new ListView();

            // set data source:
            listView.ItemsSource = new List<Language>
            {
                new Language {Name="C#", ImagePath="csharp.png", Description = "C# description ..." },
                new Language {Name="JavaScript", ImagePath="js.png", Description = "JS description ..." },
                new Language {Name="TypeScript", ImagePath="ts.png", Description = "TS description ..." },
            };

            // set data template:
            listView.ItemTemplate = new DataTemplate(() =>
            {
                ImageCell imageCell = new ImageCell
                {
                    TextColor = Color.FromArgb("#455A64"),
                    DetailColor = Color.FromArgb("#90A4AE"),
                };
                imageCell.SetBinding(ImageCell.TextProperty, "Name");
                imageCell.SetBinding(ImageCell.DetailProperty, "Description");
                imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
                
                return imageCell;
            });

            Label header = new Label { FontSize = 18, Text = "Programming languages:" };

            Content = new StackLayout { Children = { header, listView }, Padding = 7 };
        }
    }
}
