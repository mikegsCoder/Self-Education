using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DialogueWindows
{
    public class JsonFileService : IFileService
    {
        public List<Phone> Open(string filename)
        {
            List<Phone> phones = new List<Phone>();

            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<Phone>));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                phones = jsonFormatter.ReadObject(fs) as List<Phone>;
            }

            return phones;
        }

        public void Save(string filename, List<Phone> phonesList)
        {
            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<Phone>));

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, phonesList);
            }
        }
    }
}
