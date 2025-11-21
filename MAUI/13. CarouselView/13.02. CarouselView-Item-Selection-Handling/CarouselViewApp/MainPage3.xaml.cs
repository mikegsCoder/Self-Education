using System.Windows.Input;

namespace CarouselViewApp
{
    public partial class MainPage3 : ContentPage
    {
        public ICommand SelectCommand { get; set; }

        public MainPage3()
        {
            InitializeComponent();

            SelectCommand = new Command<Product?>(p =>
            {
                header.Text = $"You have selected: {p?.Name}";
            });

            BindingContext = this;
        }
    }
}
