using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace RichTextBox
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

            sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";

            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);

                using (FileStream fs = File.Create(sfd.FileName))
                {
                    if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                    {
                        doc.Save(fs, DataFormats.Rtf);
                    }
                    else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                    {
                        doc.Save(fs, DataFormats.Text);
                    }
                    else
                    {
                        doc.Save(fs, DataFormats.Xaml);
                    }
                }
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                    {
                        doc.Load(fs, DataFormats.Rtf);
                    }
                    else if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                    {
                        doc.Load(fs, DataFormats.Text);
                    }
                    else
                    {
                        doc.Load(fs, DataFormats.Xaml);
                    }
                }
            }
        }
    }
}
