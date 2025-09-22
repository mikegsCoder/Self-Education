namespace BindingApp
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Person tom = new Person { Name = "Tom", Age = 38 };

            Label nameHeaderLabel = new Label { Text = "Name" };
            Label ageHeaderLabel = new Label { Text = "Age" };
            Label nameValueLabel = new Label { FontAttributes = FontAttributes.Bold };
            Label ageValueLabel = new Label { FontAttributes = FontAttributes.Bold };


            Binding nameBinding = new Binding { Source = tom, Path = "Name" };
            Binding ageBinding = new Binding { Source = tom, Path = "Age" };

            nameValueLabel.SetBinding(Label.TextProperty, nameBinding);
            ageValueLabel.SetBinding(Label.TextProperty, ageBinding);

            Button btn = new Button { Text = "+", WidthRequest = 60, HorizontalOptions = LayoutOptions.Start };
            Label testLabel = new Label();

            btn.Clicked += (o, e) =>
            {
                tom.Age++;
                testLabel.Text = tom.Age.ToString();
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { nameHeaderLabel, nameValueLabel, ageHeaderLabel, ageValueLabel, btn, testLabel },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
