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
