using System.Windows;

namespace DialogueWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext =
                new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());
        }
    }
}
