using Microsoft.Maui.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteLayoutApp
{
    public class AbsoluteLayoutStartPage : ContentPage
    {
        public AbsoluteLayoutStartPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            // AbsoluteLayout example:
            // define elements:
            BoxView boxView = new BoxView { Color = Colors.LightBlue };
            Label label = new Label { Text = ".NET MAUI Absolute Layout", FontSize = 20 };

            // add elements:
            absoluteLayout.Add(boxView);
            absoluteLayout.Add(label);

            // set location and size:
            absoluteLayout.SetLayoutBounds(
                boxView,
                new Rect(30, 70, 390, 100)
            );

            absoluteLayout.SetLayoutBounds(
                label,
                //new Rect(50, 100, 300, 40)
                new Rect(50, 100, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );
        }
    }
}
