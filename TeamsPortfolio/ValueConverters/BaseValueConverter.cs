using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace TeamsPortfolio
{
    /// <summary>
    /// a base value converter that allows direct XAML usage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        // MarkupExtension is used to bind this in XAML

        #region private fields

        /// <summary>
        /// a single static instance of this value converter
        /// </summary>
        private static T _converter = null;

        #endregion

        #region MarkupExtension methods 

        /// <summary>
        /// this is called when it tries to get the value in XAML.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider) 
            => _converter ?? (_converter = new T());

        #endregion

        #region value converter methods

        /// <summary>
        /// the method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// the method to convert a value back to it's source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
