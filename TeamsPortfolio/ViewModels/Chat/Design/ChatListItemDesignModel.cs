namespace TeamsPortfolio
{
    /// <summary>
    /// the design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance
            => new ChatListItemDesignModel();

        #endregion

        #region constructor

        public ChatListItemDesignModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "This chat app is awesome";
            ProfilePictureHexColor = "5961B0";
        }

        #endregion
    }
}
