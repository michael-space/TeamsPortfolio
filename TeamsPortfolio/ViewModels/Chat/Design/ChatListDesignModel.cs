using System.Collections.Generic;

namespace TeamsPortfolio
{
    /// <summary>
    /// the design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance
            => new ChatListDesignModel();

        #endregion

        #region constructor

        public ChatListDesignModel()
        {
            ChatListItemsList = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome",
                    ProfilePictureHexColor = "5961B0",
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureHexColor = "A09C92",
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "the new server is up, got 123.232.1.3",
                    ProfilePictureHexColor = "C0A9B8",
                },new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome",
                    ProfilePictureHexColor = "5961B0",
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureHexColor = "A09C92",
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "the new server is up, got 123.232.1.3",
                    ProfilePictureHexColor = "C0A9B8",
                },new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome",
                    ProfilePictureHexColor = "5961B0",
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureHexColor = "A09C92",
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "the new server is up, got 123.232.1.3",
                    ProfilePictureHexColor = "C0A9B8",
                },new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome",
                    ProfilePictureHexColor = "5961B0",
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureHexColor = "A09C92",
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "the new server is up, got 123.232.1.3",
                    ProfilePictureHexColor = "C0A9B8",
                },new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome",
                    ProfilePictureHexColor = "5961B0",
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureHexColor = "A09C92",
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "the new server is up, got 123.232.1.3",
                    ProfilePictureHexColor = "C0A9B8",
                },
            };
        }

        #endregion
    }
}
