namespace ListViewApp
{
    public class StartPage1 : ContentPage
    {
        // ListView example:
        public StartPage1()
        {
            Label header = new Label { Text = "User list:" };

            // ListView data:
            string[] people = new string[] { "Tom", "Bob", "Sam", "Alice" };

            ListView listView = new ListView();

            // Set ItemsSource:
            listView.ItemsSource = people;

            Content = new StackLayout { Children = { header, listView }, Padding = 7 };
        }
    }
}
