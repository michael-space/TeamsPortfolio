using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace TeamsPortfolio
{
    /// <summary>
    /// animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// adds a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">the storyboard to add the animation to</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        public static void AddSlideFromRight(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));


            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// adds a slide to left animation to the storyboard
        /// </summary>
        /// <param name="storyboard">the storyboard to add the animation to</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        public static void AddSlideToLeft(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));


            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// adds a fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">the storyboard to add the animation to</param>
        /// <param name="seconds">the time the animation will take</param>
        public static void AddFadeIn(this Storyboard storyboard, double seconds)
        {
            // create the margin animate from right
            // DoubleAnimation is for a single value
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0, // invisible
                To = 1,   // visible
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// adds a fade out animation to the storyboard
        /// </summary>
        /// <param name="storyboard">the storyboard to add the animation to</param>
        /// <param name="seconds">the time the animation will take</param>
        public static void AddFadeOut(this Storyboard storyboard, double seconds)
        {
            // create the margin animate from right
            // DoubleAnimation is for a single value
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            storyboard.Children.Add(animation);
        }

    }
}
