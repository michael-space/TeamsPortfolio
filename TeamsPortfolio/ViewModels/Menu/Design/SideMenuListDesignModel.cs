using System.Collections.Generic;
using System.Windows;

namespace TeamsPortfolio
{
    /// <summary>
    /// the design-time data for a <see cref="SideMenuListViewModel"/>
    /// </summary>
    public class SideMenuListDesignModel : SideMenuListViewModel
    {
        #region singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static SideMenuListDesignModel Instance
            => new SideMenuListDesignModel();

        #endregion

        #region constructor

        public SideMenuListDesignModel()
        {
            SideMenuItemsList = new List<SideMenuListItemViewModel>
            {
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Bell",
                    Name = "Activity",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 0,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Comment",
                    Name = "Chat",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = true,
                    Grid = 1,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Users",
                    Name = "Teams",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 2,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_CalendarAlt",
                    Name = "Calendar",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 3,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Phone",
                    Name = "Phone",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 4,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_File",
                    Name = "Files",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 5,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_EllipsisH",
                    Name = "",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 6,
                    Margin = new Thickness(19, 19, 19, 0),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Store",
                    Name = "Apps",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 8,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_QuestionCircle",
                    Name = "Help",
                    ImgSource = "/Images/Others/Badge_1.png",
                    IsNewActivityReceived = false,
                    Grid = 9,
                    Margin = new Thickness(10, 10, 10, 5),
                },
            };
        }

        #endregion
    }
}
