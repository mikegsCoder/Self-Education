using System.Windows.Input;

namespace ItemSelectionApp
{
    public partial class MainPage3 : ContentPage
    {
        public ICommand SelectCommand { get; set; }

        public MainPage3()
        {
            InitializeComponent();

            SelectCommand = new Command<Person?>(p =>
            {
                selectedLabel.Text = $"Selected: {p?.Name}";
            });

            BindingContext = this;
        }
    }
}
