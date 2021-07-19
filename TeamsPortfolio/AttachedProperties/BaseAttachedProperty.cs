using System;
using System.Windows;

namespace TeamsPortfolio
{
    /// <summary>
    /// a base attached property to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent">the parent class to be the attached property</typeparam>
    /// <typeparam name="Property">the type of this attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()
    {
        #region public events

        /// <summary>
        /// triggered when the value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion

        #region public properties

        /// <summary>
        /// a singleton instance of our parent class
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region attached property definitions

        public static readonly DependencyProperty ValueProperty
            = DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachedProperty<Parent, Property>), new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));

        /// <summary>
        /// the callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">the ui element that had it's property changed</param>
        /// <param name="e">the arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // call the parent function
            Instance.OnValueChanged(d, e);

            // call event listner
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// gets the attached property
        /// </summary>
        /// <param name="d">the element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d)
        {
            return (Property)d.GetValue(ValueProperty);
        }

        /// <summary>
        /// sets the attached property
        /// </summary>
        /// <param name="d">the element to get the property from</param>
        /// <param name="value">the value to set the property to</param>
        public static void SetValue(DependencyObject d, Property value)
        {
            d.SetValue(ValueProperty, value);
        }

        #endregion

        #region event methods

        /// <summary>
        /// the method that is called when any attached property of this type is changed
        /// </summary>
        /// <param name="sender">the ui element that this property was changed for</param>
        /// <param name="e">the arguments for this event</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion

    }
}
