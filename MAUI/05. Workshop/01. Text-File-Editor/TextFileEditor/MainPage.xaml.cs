using TextFileEditor.Services;

namespace TextFileEditor
{
    public partial class MainPage : ContentPage
    {
        private readonly FileService fileService;

        public MainPage()
        {
            InitializeComponent();

            fileService = new FileService();
        }

        private async void ReadBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void WriteBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private async void AddToZipBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void UnzipBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
