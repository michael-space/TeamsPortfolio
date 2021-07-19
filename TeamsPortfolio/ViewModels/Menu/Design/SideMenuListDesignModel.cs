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
                    Indicator = false,
                    Grid = 0,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Comment",
                    Name = "Chat",
                    Indicator = false,
                    Grid = 1,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Users",
                    Name = "Teams",
                    Indicator = false,
                    Grid = 2,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_CalendarAlt",
                    Name = "Calendar",
                    Indicator = false,
                    Grid = 3,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Phone",
                    Name = "Phone",
                    Indicator = false,
                    Grid = 4,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_File",
                    Name = "Files",
                    Indicator = false,
                    Grid = 5,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_EllipsisH",
                    Name = "",
                    Indicator = false,
                    Grid = 6,
                    Margin = new Thickness(19, 19, 19, 0),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Solid_Store",
                    Name = "Apps",
                    Indicator = false,
                    Grid = 8,
                    Margin = new Thickness(10, 10, 10, 5),
                },
                new SideMenuListItemViewModel
                {
                    Icon = "Regular_QuestionCircle",
                    Name = "Help",
                    Indicator = false,
                    Grid = 9,
                    Margin = new Thickness(10, 10, 10, 5),
                },
            };
        }

        #endregion
    }
}
