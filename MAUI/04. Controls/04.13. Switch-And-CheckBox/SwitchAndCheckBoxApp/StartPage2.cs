using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndCheckBoxApp
{
    public class StartPage2 : ContentPage
    {
        Label statusLabel;

        // CheckBox example:
        public StartPage2()
        {
            CheckBox statusCheckBox = new CheckBox { IsChecked = false };

            statusCheckBox.CheckedChanged += CheckBox_CheckedChanged;

            Label statusHeaderLabel = new Label { FontSize = 16, Text = "On/Off", Margin = 4 };
            
            StackLayout checkboxStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { statusCheckBox, statusHeaderLabel }
            };

            statusLabel = new Label
            {
                FontSize = 18,
                Text = "Status: Off"
            };

            Content = new StackLayout { Children = { statusLabel, checkboxStack }, Padding = 8 };
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            statusLabel.Text = $"Status: {(e.Value ? "On" : "Off")}";
        }
    }
}
