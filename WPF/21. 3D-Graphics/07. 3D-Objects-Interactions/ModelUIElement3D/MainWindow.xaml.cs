using System.Windows;
using System.Windows.Input;

namespace ModelUIElement3D
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

        private void ModelUIElement3D_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse clicked.");
        }
    }
}
