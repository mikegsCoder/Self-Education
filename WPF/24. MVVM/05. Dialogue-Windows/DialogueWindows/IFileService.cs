using System.Collections.Generic;

namespace DialogueWindows
{
    public interface IFileService
    {
        List<Phone> Open(string filename);

        void Save(string filename, List<Phone> phonesList);
    }
}
