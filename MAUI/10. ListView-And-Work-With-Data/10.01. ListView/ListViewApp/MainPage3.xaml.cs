namespace ListViewApp
{
    public partial class MainPage3 : ContentPage
    {
        public List<string> Users { get; set; }

        public MainPage3()
        {
            InitializeComponent();

            Users = new List<string> { "Tom", "Bob", "Sam", "Alice" };

            BindingContext = this;
        }
    }
}
