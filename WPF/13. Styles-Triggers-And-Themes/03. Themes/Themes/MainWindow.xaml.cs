using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Themes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<string> styles;

        public MainWindow()
        {
            InitializeComponent();

            styles = new List<string> { "light", "dark" };

            SetStyleBox();
        }

        private void SetStyleBox()
        {
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "dark";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;

            // set path to resource file
            var uri = new Uri(style + ".xaml", UriKind.Relative);

            // load resource dictionary
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            
            // clear application resources
            Application.Current.Resources.Clear();

            // add new resource dictionary
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
