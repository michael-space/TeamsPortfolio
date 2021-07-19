using System.Windows;
using System.Windows.Input;

namespace TeamsPortfolio
{
    /// <summary>
    /// the View Model for the custom flat window
    /// </summary>
    public class CustomFlatWindowViewModel : BaseViewModel
    {
        #region private fields

        /// <summary>
        /// the window this view model controls
        /// </summary>
        private Window _window;

        /// <summary>
        /// The last known dock position
        /// </summary>
        private WindowDockPosition _dockPosition = WindowDockPosition.Undocked;

        private int chromeWindowOuterMarginSize = 10;

        #endregion

        #region public properties

        public int MinHeight { get; set; } = 288;
        public int MinWidth { get; set; } = 384;

        //public int ResizeBorderThicknessInt { get; set; } = 3;
        public int ResizeBorderThicknessInt
            => Borderless ? 0 : 3;

        public Thickness ChromeWindowResizeBorderThickness
            => new Thickness(ResizeBorderThicknessInt + ChromeWindowOuterMarginSizeInt);

        /// <summary>
        /// true if the window should be borderless because it is docked or maximized
        /// </summary>
        public bool Borderless
        {
            get
            {
                return (_window.WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked);
            }
        }

        /// <summary>
        /// the size of the resize border around the window
        /// </summary>
        //public int ResizeBorder => _window.WindowState == WindowState.Maximized ? 0 : 3;

        /// <summary>
        /// margin around the Chrome window to allow for a drop shadow. 
        /// When the window is maximized, return 0
        /// </summary>
        public int ChromeWindowOuterMarginSizeInt
        {
            get => Borderless ? 0 : chromeWindowOuterMarginSize;
            set => chromeWindowOuterMarginSize = value;
        }

        /// <summary>
        /// margin around the Chrome window to allow for a drop shadow. 
        /// When the window is maximized, return 0
        /// </summary>
        public Thickness ChromeWindowOuterMarginSizeThickness
            => new Thickness(ChromeWindowOuterMarginSizeInt);

        public int ChromeWindowHeaderHeight { get; set; } = 45;

        public GridLength ChromeWindowHeaderHeightGridLength
            => new GridLength(ChromeWindowHeaderHeight + ResizeBorderThicknessInt);

        /// <summary>
        /// the current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Chat;
        //public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion

        #region commands

        /// <summary>
        /// The command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }


        #endregion

        #region constructor

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="window"></param>
        public CustomFlatWindowViewModel(Window window)
        {
            _window = window;

            _window.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ChromeWindowResizeBorderThickness));
                OnPropertyChanged(nameof(ChromeWindowOuterMarginSizeInt));
                OnPropertyChanged(nameof(ChromeWindowOuterMarginSizeThickness));
            };

            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());

            // fixes the issue with Windows of Style <see cref="WindowStyle.None"/> covering the taskbar when it's maximized
            var resizer = new WindowResizer(_window);
        }

        #endregion
    }
}
