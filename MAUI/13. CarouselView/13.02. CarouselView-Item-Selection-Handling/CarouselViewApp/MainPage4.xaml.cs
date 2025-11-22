using System.Windows.Input;

namespace CarouselViewApp
{
    public partial class MainPage4 : ContentPage
    {
        public ICommand SelectCommand { get; set; }

        public MainPage4()
        {
            InitializeComponent();

            SelectCommand = new Command<Product>(async p =>
            {
                await DisplayAlert("Notification", $"You have selected: {p.Name}", "ОK");
            });

            BindingContext = this;
        }
    }
}
