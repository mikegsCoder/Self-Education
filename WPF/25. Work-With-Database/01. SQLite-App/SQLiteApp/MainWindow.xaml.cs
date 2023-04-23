using SQLiteApp.Database.Models;
using SQLiteApp.Database;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();

        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        // on MainWindow load
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // ensure DB is created
            db.Database.EnsureCreated();

            // load data from DB
            db.Users.Load();

            // set data to data context
            DataContext = db.Users.Local.ToObservableCollection();
        }

        // add
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UserWindow UserWindow = new UserWindow(new User());

            if (UserWindow.ShowDialog() == true)
            {
                User User = UserWindow.User;

                db.Users.Add(User);
                db.SaveChanges();
            }
        }

        // edit
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // get user
            User? user = usersList.SelectedItem as User;

            // return if user is null
            if (user is null)
            {
                return;
            }

            UserWindow UserWindow = new UserWindow(new User
            {
                Id = user.Id,
                Age = user.Age,
                Name = user.Name
            });

            if (UserWindow.ShowDialog() == true)
            {
                // get user
                user = db.Users.Find(UserWindow.User.Id);

                if (user != null)
                {
                    user.Age = UserWindow.User.Age;
                    user.Name = UserWindow.User.Name;

                    db.SaveChanges();
                    usersList.Items.Refresh();
                }
            }
        }

        // delete
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // get user
            User? user = usersList.SelectedItem as User;

            // return if user is null
            if (user is null)
            {
                return;
            }

            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
