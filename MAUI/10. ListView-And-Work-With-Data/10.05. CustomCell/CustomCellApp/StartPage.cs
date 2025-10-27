namespace CustomCellApp
{
    public class StartPage : ContentPage
    {
        // CustomCell example:
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

            // set data template
            listView.ItemTemplate = new DataTemplate(() =>
            {
                CustomCell customCell = new CustomCell { ImageHeight = 40, ImageWidth = 40 };
                customCell.SetBinding(CustomCell.TitleProperty, "Name");
                customCell.SetBinding(CustomCell.DetailProperty, "Description");
                customCell.SetBinding(CustomCell.ImagePathProperty, "ImagePath");
                
                return customCell;
            });

            Label header = new Label { FontSize = 18, Text = "Programming languages:" };
            
            Content = new StackLayout { Children = { header, listView }, Padding = 7 };
        }
    }
}
