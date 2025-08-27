using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileEditor.Services
{
    public class FileService : IFileService
    {
        public string ReadAllText()
        {
            if (!File.Exists(AppConstants.TxtFileName))
            {
                throw new Exception(AppConstants.TxtFileMissingMsg);
            }

            return File.ReadAllText(AppConstants.TxtFileName);
        }

        public void SaveAllText(string text)
        {
            if (!File.Exists(AppConstants.TxtFileName))
            {
                throw new Exception(AppConstants.TxtFileMissingMsg);
            }

            File.WriteAllText(AppConstants.TxtFileName, text);
        }

        public void AddToZip()
        {
            if (!File.Exists(AppConstants.TxtFileName))
            {
                throw new Exception(AppConstants.TxtFileMissingMsg);
            }

            AddFilesToZip(AppConstants.ZipFileName, new string[] { AppConstants.TxtFileName });
        }

        public void ExtractFromZip()
        {
            if (!File.Exists(AppConstants.ZipFileName))
            {
                throw new Exception(AppConstants.ZipFileMissingMsg);
            }

            ExtractFileFromZip(AppConstants.ZipFileName, AppConstants.FilePath);
        }

        private void ExtractFileFromZip(string zipFileName, string filePath)
        {
            throw new NotImplementedException();
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
