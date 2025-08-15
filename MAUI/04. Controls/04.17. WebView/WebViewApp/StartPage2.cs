using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewApp
{
    public class StartPage2 : ContentPage
    {
        // WebView load local HTML example:
        public StartPage2()
        {
            WebView webView = new WebView();

            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"
                      <h1>Hello World!</h1>
                      <p>Hello .NET MAUI!</p>
                      ";

            webView.Source = htmlSource;

            Content = webView;
        }
    }
}
