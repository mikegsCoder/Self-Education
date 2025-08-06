using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepperAndSliderApp
{
    public class StartPage1 : ContentPage
    {
        Label header;

        // Stepper example:
        public StartPage1()
        {
            header = new Label { FontSize = 18, Margin = 5 };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 0.1,
                VerticalOptions = LayoutOptions.Start
            };

            stepper.ValueChanged += OnStepperValueChanged;

            Content = new StackLayout { Children = { stepper, header }, Orientation = StackOrientation.Horizontal };
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            header.Text = $"Your choice is: {e.NewValue:F1}";
        }
    }
}
