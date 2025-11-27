using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewApp
{
    public class StartPage2 : ContentPage
    {
        // CollectionView example:
        public StartPage2()
        {
            CollectionView collectionView = new CollectionView { Margin = 5 };
            
            // set data source:
            collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
            
            // set data template:
            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var personLbl = new Label { FontSize = 16, TextColor = Color.FromArgb("#1565C0") };
                personLbl.SetBinding(Label.TextProperty, new Binding("BindingContext", source: RelativeBindingSource.Self));
                
                return personLbl;
            });

            Content = collectionView;
        }
    }
}
