using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCellApp
{
    public class CustomCell : ViewCell
    {
        Label titleLabel, detailLabel;
        Image image;

        public CustomCell()
        {
            titleLabel = new Label { FontSize = 18 };
            detailLabel = new Label();
            image = new Image();

            StackLayout cell = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(5, 8)
            };

            StackLayout titleDetailLayout = new StackLayout { Margin = 5 };
            titleDetailLayout.Children.Add(titleLabel);
            titleDetailLayout.Children.Add(detailLabel);

            cell.Children.Add(image);
            cell.Children.Add(titleDetailLayout);

            View = cell;
        }

        public static readonly BindableProperty TitleProperty =
        BindableProperty.Create("Title", typeof(string), typeof(CustomCell), "");

        public static readonly BindableProperty ImagePathProperty =
            BindableProperty.Create("ImagePath", typeof(ImageSource), typeof(CustomCell), null);

        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create("ImageWidth", typeof(int), typeof(CustomCell), 100);

        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create("ImageHeight", typeof(int), typeof(CustomCell), 100);

        public static readonly BindableProperty DetailProperty =
            BindableProperty.Create("Detail", typeof(string), typeof(CustomCell), "");

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        public string Detail
        {
            get { return (string)GetValue(DetailProperty); }
            set { SetValue(DetailProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                titleLabel.Text = Title;
                detailLabel.Text = Detail;
                image.Source = ImagePath;
                image.WidthRequest = ImageWidth;
                image.HeightRequest = ImageHeight;
            }
        }
    }
}
