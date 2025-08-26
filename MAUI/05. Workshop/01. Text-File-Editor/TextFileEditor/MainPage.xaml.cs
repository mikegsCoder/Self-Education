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
            string text = "";

            try
            {
                text = fileService.ReadAllText();

                if (text.Length > 0)
                {
                    textBox.Text = text;
                }

                await DisplayAlert("Success", AppConstants.ReadTextSuccessMsg, "ОK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ОK");
            }
        }

        private async void WriteBtn_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                await DisplayAlert("Error", AppConstants.EmptyTextMsg, "ОK");

                return;
            }

            try
            {
                fileService.SaveAllText(text);

                await DisplayAlert("Success", AppConstants.WriteTextSuccessMsg, "ОK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ОK");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private async void AddToZipBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileService.AddToZip();

                await DisplayAlert("Success", AppConstants.AddToZipSuccessMsg, "ОK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ОK");
            }
        }

        private async void UnzipBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
