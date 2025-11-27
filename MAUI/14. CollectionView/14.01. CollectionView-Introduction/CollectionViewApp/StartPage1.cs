using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewApp
{
    public class StartPage1 : ContentPage
    {
        // CollectionView example:
        public StartPage1()
        {
            CollectionView collectionView = new CollectionView { Margin = 5 };
            
            collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
            
            Content = collectionView;
        }
    }
}
