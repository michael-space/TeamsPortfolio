namespace TeamsPortfolio
{
    /// <summary>
    /// a viewmodel for each chat list item in the overview char list
    /// </summary>
    public class ChatListItemViewModel : BaseViewModel
    {
        #region public properties

        public string Name { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        /// <summary>
        /// the RGB values (in hex) for the background color of the profile picture
        /// </summary>
        public string ProfilePictureHexColor { get; set; }

        public bool IsSelected { get; set; }

        #endregion
    }
}
