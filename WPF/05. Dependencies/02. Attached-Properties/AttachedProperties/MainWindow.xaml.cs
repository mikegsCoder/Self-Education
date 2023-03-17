using System.Windows;
using System.Windows.Controls;

namespace AttachedProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetPosition();
            ShowPosition();
        }

        private void SetPosition()
        {
            Grid.SetRow(button1, 1); // second row
            Grid.SetColumn(button1, 1); // second column
        }

        private int GetRow()
        {
            return (int)button1.GetValue(Grid.RowProperty);
        }

        private int GetCol()
        {
            return (int)button1.GetValue(Grid.ColumnProperty);
        }

        private void ShowPosition()
        {
            MessageBox.Show($"Current position: row = {GetRow()}, column = {GetCol()}.");
        }
    }
}
