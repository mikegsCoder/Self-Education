using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApp
{
    public class StartPage3 : ContentPage
    {
        // Image from uri with CacheValidity 2 days example:
        public StartPage3()
        {
            Image image = new Image();

            image.Source = new UriImageSource
            {
                Uri = new Uri("https://images.rawpixel.com/image_png_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvdXB3azYxNzMxNjE4LXdpa2ltZWRpYS1pbWFnZS1qb2I2MjNfMi1sMXBxYmwxMy5wbmc.png"),
                CacheValidity = new TimeSpan(2, 0, 0, 0)
            };

            Content = image;
        }
    }
}
