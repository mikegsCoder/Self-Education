using SQLiteApp.Database.Models;
using System.Windows;

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public User User { get; private set; }

        public UserWindow(User user)
        {
            InitializeComponent();

            User = user;

            DataContext = User;
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
