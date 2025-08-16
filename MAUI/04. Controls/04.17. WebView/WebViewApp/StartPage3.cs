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
