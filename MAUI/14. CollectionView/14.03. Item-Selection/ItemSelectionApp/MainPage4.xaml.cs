using System.Windows.Input;

namespace ItemSelectionApp
{
    public partial class MainPage4 : ContentPage
    {
        public ICommand SelectCommand { get; set; }

        public MainPage4()
        {
            InitializeComponent();

            SelectCommand = new Command<IList<object>>(people =>
            {
                string text = "Selected: ";

                foreach (var p in people)
                {
                    if (p is Person person) text = $"{text} {person.Name},";
                }

                selectedLabel.Text = text;
            });

            BindingContext = this;
        }
    }
}
