using System.Windows;
using System.Windows.Controls;

namespace TabControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Examle3();
        }

        private void Examle3()
        {
            ListBox notesList = new ListBox();

            notesList.Items.Add("Macbook Pro");
            notesList.Items.Add("HP Pavilion 5478");
            notesList.Items.Add("Acer LK-08");

            products1.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Notebooks" }, // set header
                Content = notesList // set content
            });
        }
    }
}
