namespace RadioButtonApp
{
    public class StartPage : ContentPage
    {
        Label header = new Label { Text = "Choose a technology:" };

        // RadioButton example:
        public StartPage()
        {
            string[] technologies = { "C#", "JavaScript", "TypeScript" };

            StackLayout stackLayout = new StackLayout();
            stackLayout.Add(header);

            foreach (var technology in technologies)
            {
                RadioButton langRadioButton = new RadioButton { GroupName = "technologies", Content = technology, Value = technology };
                
                langRadioButton.CheckedChanged += OnLanguageCheckedChanged;
                
                stackLayout.Add(langRadioButton);
            }

            Content = stackLayout;
        }

        private void OnLanguageCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (header != null)
            {
                header.Text = $"Your choice is: {selectedRadioButton.Value}";
            }
        }
    }
}
