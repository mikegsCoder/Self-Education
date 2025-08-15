using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewApp
{
    public class StartPage1 : ContentPage
    {
        // WebView example:
        public StartPage1()
        {
            WebView webView = new WebView
            {
                //Source = "https://mikegscoder.github.io/"
                Source = new UrlWebViewSource { Url = "https://mikegscoder.github.io/" },
            };

            Content = webView;
        }
    }
}
