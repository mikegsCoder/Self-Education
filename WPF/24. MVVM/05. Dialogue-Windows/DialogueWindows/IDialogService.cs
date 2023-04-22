namespace DialogueWindows
{
    public interface IDialogService
    {
        void ShowMessage(string message);   // show message

        string FilePath { get; set; }   // file path

        bool OpenFileDialog();  // open file

        bool SaveFileDialog();  // save file
    }
}
