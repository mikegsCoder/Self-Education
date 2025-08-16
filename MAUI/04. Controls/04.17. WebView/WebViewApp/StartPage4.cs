using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewApp
{
    public class StartPage4 : ContentPage
    {
        Label statusLabel = new Label() { Padding = 8, FontSize = 20 };

        // WebView navigation example:
        public StartPage4()
        {
            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = 60 });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            WebView webView = new WebView();

            webView.Source = "https://dir.bg/";
            webView.Navigated += WebView_Navigated; // add event handler

            grid.Add(statusLabel, 0, 0);
            grid.Add(webView, 0, 1);
            Content = grid;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                statusLabel.Text = "Web page loaded successfully";
            }
            else
            {
                statusLabel.Text = "An error occurred";
            }
        }
    }
}
