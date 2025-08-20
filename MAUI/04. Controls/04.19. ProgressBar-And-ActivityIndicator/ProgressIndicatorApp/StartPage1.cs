namespace ProgressIndicatorApp
{
    public class StartPage1 : ContentPage
    {
        // ProgressBar example:
        public StartPage1()
        {
            StackLayout stackLayout = new StackLayout { Padding = 20 };

            Label label = new Label { Text = "ProgressBar" };
            
            ProgressBar progressBar = new ProgressBar { Progress = 0.4, ProgressColor = Colors.SeaGreen };

            stackLayout.Children.Add(label);
            stackLayout.Children.Add(progressBar);

            Content = stackLayout;
        }
    }
}
