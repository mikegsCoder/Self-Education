using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people = new List<Person>()
        {
            new Person("Tom", 38),
            new Person ("Bob", 42),
            new Person("Sam", 25)
        };

        public MainWindow()
        {
            InitializeComponent();
            
            Example1();
            Example2();
            Example3();
        }

        private void Example1()
        {
            usersList.Items.Remove("Sam");      // remove element "Sam"
            usersList.Items.RemoveAt(1);        // remove second element
            usersList.Items.Add("Kate");        // add element "Kate"
            usersList.Items.Insert(0, "Mike");  // insert element "Mike" at position 0
        }

        private void Example2() 
        {
            Person person1 = new Person("Tom", 38);
            Person person2 = new Person("Bob", 42);
            Person person3 = new Person("Sam", 25);
            Person person4 = new Person("Alice", 34);

            usersList1.Items.Add(person1);
            usersList1.Items.Add(person2);
            usersList1.Items.Add(person3);
            usersList1.Items.Add(person4);
        }

        private void Example3()
        {
            usersList2.ItemsSource = people;
        }

        // event handlers:
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            people.Add(new Person ("Mike", 29));
            usersList2.Items.Refresh();
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersList2.SelectedItem is Person person)
            {
                MessageBox.Show(person.Name);
            }
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}  Age: {Age}";
        }
    }
}
