using System.Windows;

namespace DialogueWindows
{
    /// <summary>
    /// Interaction logic for PasswordWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        
        public string Username
        {
            get { return usernameBox.Text; }
        }

        public string Password
        {
            get { return passwordBox.Text; }
        }
    }
}
