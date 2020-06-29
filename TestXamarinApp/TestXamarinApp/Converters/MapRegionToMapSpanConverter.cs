using JoesBurgerStore.ViewModels;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestXamarinApp.Converters
{
    public class MapRegionToMapSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var mapRegionViewModel = value as MapRegionViewModel;
            return mapRegionViewModel != null ? new MapSpan(new Position(mapRegionViewModel.Latitude, mapRegionViewModel.Longitude), mapRegionViewModel.LatitudeDegrees, mapRegionViewModel.LongitudeDegrees) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
