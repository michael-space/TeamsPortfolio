using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TeamsPortfolio
{
    /// <summary>
    /// a converter that takes in a hex color such as A3B9C4 and converts it to a WPF brush
    /// </summary>
    public class StringToContentConverter : BaseValueConverter<StringToContentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new ContentControl().Content = "No Idea";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
