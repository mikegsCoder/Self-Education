using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Xps.Packaging;
using System.Windows.Xps;

namespace FixedDocument
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

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "XPS Files (*.xps)|*.xps";

            if (sfd.ShowDialog() == true)
            {
                XpsDocument doc = new XpsDocument(sfd.FileName, FileAccess.Write);
                
                XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);
                
                writer.Write(documentViewer.Document as System.Windows.Documents.FixedDocument);
                
                doc.Close();
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "XPS Files (*.xps)|*.xps";

            if (ofd.ShowDialog() == true)
            {
                XpsDocument doc = new XpsDocument(ofd.FileName, FileAccess.Read);
                
                documentViewer.Document = doc.GetFixedDocumentSequence();
            }
        }
    }
}
