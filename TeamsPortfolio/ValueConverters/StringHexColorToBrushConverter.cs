using System;
using System.Globalization;
using System.Windows.Media;

namespace TeamsPortfolio
{
    /// <summary>
    /// a converter that takes in a hex color such as A3B9C4 and converts it to a WPF brush
    /// </summary>
    public class StringHexColorToBrushConverter : BaseValueConverter<StringHexColorToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)new BrushConverter().ConvertFrom($"#{value}");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
