using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TeamsPortfolio.Animation;

namespace TeamsPortfolio
{

    /// <summary>
    /// a base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        #region private fields

        private VM _viewModel;

        #endregion

        #region public properties

        /// <summary>
        /// the animation to play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// the animation to play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        public double SlideSeconds { get; set; } = 0.8;

        /// <summary>
        /// the viewmodel associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => _viewModel;
            set
            {
                // if nothing has changed,
                if (_viewModel == value)
                {
                    return;
                }

                // update the value
                _viewModel = value;

                // set the data contect for this page
                this.DataContext = _viewModel;
            }
        }

        #endregion

        #region constructor

        public BasePage()
        {
            // if we are animating in, hide to begin with
            if (PageLoadAnimation != PageAnimation.None)
            {
                Visibility = Visibility.Collapsed;
            }

            // listen out for the page loading
            Loaded += BasePage_Loaded;

            // create a default view model
            this.ViewModel = new VM();
        }

        #endregion

        #region animation load / unload

        /// <summary>
        /// once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            await AnimateIn();
        }

        private async Task AnimateIn()
        {
            if (PageLoadAnimation == PageAnimation.None)
            {
                return;
            }

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    await this.SlideAndFadeFromRight(this.SlideSeconds);

                    break;
            }
        }

        public async Task AnimateOut()
        {
            if (PageUnloadAnimation == PageAnimation.None)
            {
                return;
            }

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}
