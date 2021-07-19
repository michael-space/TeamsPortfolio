using System.Collections.Generic;
using System.Windows.Controls;

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
                    Icon = "{StaticResource FontAwesomeBellIcon}",
                    Name = "Luke",
                    Indicator = false,
                },
                new SideMenuListItemViewModel
                {
                    Icon = "{StaticResource FontAwesomeBellIcon}",
                    Name = "Jesse",
                    Indicator = false,
                },
                new SideMenuListItemViewModel
                {
                    Icon = "{StaticResource FontAwesomeBellIcon}",
                    Name = "Parnell",
                    Indicator = false,
                },
                //new SideMenuListItemViewModel
                //{
                //    Icon = t,
                //    Name = "Luke",
                //    Indicator = false,
                //},
                //new SideMenuListItemViewModel
                //{
                //    Icon = t,
                //    Name = "Jesse",
                //    Indicator = false,
                //},
                //new SideMenuListItemViewModel
                //{
                //    Icon = t,
                //    Name = "Parnell",
                //    Indicator = false,
                //},
            };
        }

        #endregion
    }
}
