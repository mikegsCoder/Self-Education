namespace TextFieldsApp
{
    public class StartPage2 : ContentPage
    {
        Label nameLabel;
        Entry nameEntry;

        // TextChanged example:
        public StartPage2()
        {
            StackLayout stackLayout = new StackLayout();

            nameEntry = new Entry { FontSize = 22 };
            nameEntry.TextChanged += nameEntry_TextChanged;
            nameLabel = new Label { FontSize = 22 };

            stackLayout.Children.Add(nameEntry);
            stackLayout.Children.Add(nameLabel);

            Content = stackLayout;
        }

        void nameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameLabel.Text = nameEntry.Text;
        }
    }
}
