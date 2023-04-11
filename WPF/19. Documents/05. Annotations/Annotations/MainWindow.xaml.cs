using System.IO;
using System.Windows;
using System.Windows.Annotations.Storage;
using System.Windows.Annotations;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileStream fs;
        AnnotationService anService;

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += Window_Loaded;
            this.Unloaded += Window_Unloaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // initializing AnnotationService
            anService = new AnnotationService(docViewer);

            // creating FileStream
            fs = new FileStream("storage.xml", FileMode.OpenOrCreate);

            // creating AnnotationStore
            AnnotationStore store = new XmlStreamStore(fs);
            store.AutoFlush = true;

            // eanbling AnnotationService
            anService.Enable(store);
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            if (anService != null && anService.IsEnabled)
            {
                anService.Store.Flush();
                anService.Disable();
                fs.Close();
            }
        }
    }
}
