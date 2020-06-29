using System;
using System.Globalization;
using Xamarin.Forms;

namespace TestXamarinApp.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagePath = value.ToString();

            return Device.OnPlatform(
                    FileImageSource.FromUri(new Uri(imagePath)),
                    FileImageSource.FromUri(new Uri(imagePath)),
                    FileImageSource.FromUri(new Uri(imagePath))
                );
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
