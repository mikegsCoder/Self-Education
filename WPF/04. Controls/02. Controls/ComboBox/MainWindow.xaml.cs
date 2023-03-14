using System.Windows;
using System.Windows.Controls;

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Example4();
            Example5();
            Example6();
        }

        private void Example4()
        {
            peopleComboBox1.ItemsSource = new Person[]
            {
                new Person { Name = "Tom", Company = "Microsoft" },
                new Person { Name = "Bob", Company = "Google" },
                new Person { Name = "Sam", Company = "JetBrains" }
            };
        }

        private void Example5()
        {
            peopleComboBox1.ItemsSource = new Person[]
            {
                new Person { Name = "Tom", Company = "Microsoft" },
                new Person { Name = "Bob", Company = "Google" },
                new Person { Name = "Sam", Company = "JetBrains" }
            };

            peopleComboBox1.SelectedIndex = 1;   // by default second element is selected
        }

        private void Example6()
        {
            peopleComboBox2.ItemsSource = new Person[]
            {
                new Person { Name = "Tom", Company = "Microsoft" },
                new Person { Name = "Bob", Company = "Google" },
                new Person { Name = "Sam", Company = "JetBrains" }
            };

            peopleComboBox2.SelectedIndex = 1;   // by default second element is selected
        }

        // event handlers:
        private void peopleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (peopleComboBox1.SelectedItem is Person person)
            {
                selectedLabel.Text = person.Name;
            }
        }

        private void peopleComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (peopleComboBox2.SelectedValue is { }) // if != null
            {
                selectedPerson.Text = peopleComboBox2.SelectedValue.ToString();
            }

            // or like this:
            // selectedPerson.Text = peopleComboBox2.SelectedValue?.ToString();
        }
    }

    public class Person
    {
        public string Name { get; set; } = "";
        public string Company { get; set; } = "";
        public override string ToString() => $"{Name} ({Company})";
    }
}
