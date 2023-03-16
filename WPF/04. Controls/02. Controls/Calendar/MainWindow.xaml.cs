using System;
using System.Windows;
using System.Windows.Controls;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // event handler:
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar1.SelectedDate;

            MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        }
    }
}
