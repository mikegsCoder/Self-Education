using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileEditor.Services
{
    public interface IFileService
    {
        public string ReadAllText();

        public void SaveAllText(string text);

        public void AddToZip();

        public void ExtractFromZip();
    }
}
