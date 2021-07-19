using System.Collections.Generic;

namespace TeamsPortfolio
{
    /// <summary>
    /// a viewmodel for the overbire chat list
    /// </summary>
    public class ChatListViewModel : BaseViewModel
    {
        #region public properties

        /// <summary>
        /// the chat list items for the list
        /// </summary>
        public List<ChatListItemViewModel> ChatListItemsList { get; set; }

        #endregion
    }
}
