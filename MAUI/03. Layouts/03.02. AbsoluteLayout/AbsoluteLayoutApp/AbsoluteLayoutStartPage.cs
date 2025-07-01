using Microsoft.Maui.Layouts;

namespace AbsoluteLayoutApp
{
    public class AbsoluteLayoutStartPage : ContentPage
    {
        public AbsoluteLayoutStartPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            // AbsoluteLayout example:
            //// define elements:
            //BoxView boxView = new BoxView { Color = Colors.LightBlue };
            //Label label = new Label { Text = ".NET MAUI Absolute Layout", FontSize = 20 };

            //// add elements:
            //absoluteLayout.Add(boxView);
            //absoluteLayout.Add(label);

            //// set location and size:
            //absoluteLayout.SetLayoutBounds(
            //    boxView,
            //    new Rect(30, 70, 390, 100)
            //);

            //absoluteLayout.SetLayoutBounds(
            //    label,
            //    //new Rect(50, 100, 300, 40)
            //    new Rect(50, 100, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            //);

            // example with AbsoluteLayout.SetLayoutFlags():
            // define elements:
            BoxView redBox = new BoxView { BackgroundColor = Colors.Red };
            BoxView greenBox = new BoxView { BackgroundColor = Colors.Green };
            BoxView blueBox = new BoxView { BackgroundColor = Colors.Blue };

            AbsoluteLayout.SetLayoutBounds(redBox, new Rect(0.2, 0.4, 50, 80));
            // set proportional coordinates:
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(greenBox, new Rect(1, 0.2, 50, 80));
            AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(blueBox, new Rect(0.4, 0.8, 0.2, 0.2));
            // set proportional coordinates and size:
            AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);

            absoluteLayout.Children.Add(redBox);
            absoluteLayout.Children.Add(greenBox);
            absoluteLayout.Children.Add(blueBox);

            Content = absoluteLayout;
        }
    }
}
