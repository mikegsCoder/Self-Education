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
            throw new NotImplementedException();
        }

        public void AddToZip()
        {
            throw new NotImplementedException();
        }

        public void ExtractFromZip()
        {
            throw new NotImplementedException();
        }
    }
}
