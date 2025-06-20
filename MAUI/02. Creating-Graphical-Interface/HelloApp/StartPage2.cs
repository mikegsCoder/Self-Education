using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class StartPage2 : ContentPage
    {
        string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                    "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n" +
                    "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                    "x:Class=\"HelloApp.StartPage\">\n" +
                    //"<Label Text=\"Hello from .NET MAUI!\" FontSize=\"22\" />" +
                    "<Label x:Name=\"header\" Text=\"Hello from .NET MAUI!\" FontSize=\"22\" />" +
                    "</ContentPage>";
        public StartPage2()
        {
            this.LoadFromXaml(pageXAML);

            // FindByName example:
            Label header = this.FindByName<Label>("header");
            header.Text = ".NET MAUI Hello again!";
        }
    }
}
