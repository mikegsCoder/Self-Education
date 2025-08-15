using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewApp
{
    public class StartPage3 : ContentPage
    {
        // WebView load local HTML file example:
        public StartPage3()
        {
            WebView webView = new WebView();

            webView.Source = "index.html";

            Content = webView;
        }
    }
}
