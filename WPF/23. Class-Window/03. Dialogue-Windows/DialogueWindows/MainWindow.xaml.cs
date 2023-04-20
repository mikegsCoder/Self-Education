using System.Windows;

namespace DialogueWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string username = "Peter";
        private string password = "123456";    

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();

            if (loginWindow.ShowDialog() == true)
            {
                if (loginWindow.Username == username && 
                    loginWindow.Password == password)
                {
                    MessageBox.Show($"Welcome {username}.");
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
            else
            {
                MessageBox.Show("You need to authenticate.");
            }
        }
    }
}
