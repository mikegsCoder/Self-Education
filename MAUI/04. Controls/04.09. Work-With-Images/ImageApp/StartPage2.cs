using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApp
{
    public class StartPage2 : ContentPage
    {
        // Image FromUri example:
        public StartPage2()
        {
            // example 1:
            //Image image = new Image
            //{
            //    Source = ImageSource.FromUri(new Uri("https://images.rawpixel.com/image_png_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvdXB3azYxNzMxNjE4LXdpa2ltZWRpYS1pbWFnZS1qb2I2MjNfMi1sMXBxYmwxMy5wbmc.png"))
            //};

            // example 2:
            Image image = new Image { Source = "https://images.rawpixel.com/image_png_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvdXB3azYxNzMxNjE4LXdpa2ltZWRpYS1pbWFnZS1qb2I2MjNfMi1sMXBxYmwxMy5wbmc.png" };

            Content = image;
        }
    }
}
