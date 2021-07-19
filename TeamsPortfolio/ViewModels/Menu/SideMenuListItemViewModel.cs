using System.Windows;

namespace TeamsPortfolio
{
    /// <summary>
    /// a viewmodel for each chat list item in the overview char list
    /// </summary>
    public class SideMenuListItemViewModel : BaseViewModel
    {
        #region public properties

        public string Icon { get; set; }

        public string Name { get; set; }

        public bool Indicator { get; set; }

        public int Grid { get; set; }

        public Thickness Margin { get; set; }

        #endregion
    }
}
