using System.Collections.Generic;

namespace TeamsPortfolio
{
    /// <summary>
    /// a viewmodel for the overbire chat list
    /// </summary>
    public class SideMenuListViewModel : BaseViewModel
    {
        #region public properties

        /// <summary>
        /// the chat list items for the list
        /// </summary>
        public List<SideMenuListItemViewModel> SideMenuItemsList { get; set; }

        #endregion
    }
}
