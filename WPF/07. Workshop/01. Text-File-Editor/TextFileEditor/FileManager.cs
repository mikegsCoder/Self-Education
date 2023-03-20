using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows;

namespace TextFileEditor
{
    public class FileManager
    {
        private static string filePath = @"../../../";
        private string textFile = filePath + "TextFile.txt";
        private string zipFile = filePath + "TextFile.zip";

        public string ReadAllText()
        {
            if (!File.Exists(textFile))
            {
                MessageBox.Show("File does not exist. Get it from the archive.");

                return null;
            }

            return File.ReadAllText(textFile);
        }

        public void SaveAllText(string text) 
        {
            if (!File.Exists(textFile))
            {
                MessageBox.Show("File does not exist. Get it from the archive.");
                return;
            }

            File.WriteAllText(textFile, text);

            MessageBox.Show("Your text is saved successfully.");
        }

        public void AddToZip()
        {
            if (!File.Exists(textFile))
            {
                MessageBox.Show("File does not exist. Get it from the archive.");

                return;
            }

            AddFilesToZip(zipFile, new string[] { textFile });

            MessageBox.Show("TextFile added to zip successfully.");
        }

        public void ExtractFromZip()
        {
            if (!File.Exists(zipFile))
            {
                MessageBox.Show("Zip archive does not exist. Create it from the TextFile.");

                return;
            }

            ExtractFileFromZip(zipFile, filePath);

            MessageBox.Show("TextFile extracted from zip successfully.");
        }

        private void ExtractFileFromZip(string zipFile, string filePath)
        {
            if (File.Exists(textFile))
            {
                File.Delete(textFile);
            }

            ZipFile.ExtractToDirectory(zipFile, filePath);
        }

        private void AddFilesToZip(string zipFile, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using (var zipArchive = ZipFile.Open(zipFile, ZipArchiveMode.Update))
            {
                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);

                    var existing = zipArchive.Entries.FirstOrDefault(e => e.Name == fileInfo.Name);

                    if (existing != null)
                    {
                        existing.Delete();
                    }

                    zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                }
            }
        }
    }
}
