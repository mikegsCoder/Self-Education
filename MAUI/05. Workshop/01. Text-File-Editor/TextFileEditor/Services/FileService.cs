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
            throw new NotImplementedException();
        }

        private void AddFilesToZip(string zipFileName, string[] strings)
        {
            throw new NotImplementedException();
        }
    }
}
