using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;

namespace CssStylingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //CSS styling example:
            //this.Resources.Add(StyleSheet.FromResource
            //        ("styles/mystyles.css", IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));

            //CSS styling example:
            using (var reader = new System.IO.StringReader("^contentpage { background-color: lightgray; }"))
            {
                this.Resources.Add(StyleSheet.FromReader(reader));
            }
        }
    }
}
