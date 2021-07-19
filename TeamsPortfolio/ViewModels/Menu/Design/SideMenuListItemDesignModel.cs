using System.Windows.Controls;

namespace TeamsPortfolio
{
    /// <summary>
    /// the design-time data for a <see cref="SideMenuListItemViewModel"/>
    /// </summary>
    public class SideMenuListItemDesignModel : SideMenuListItemViewModel
    {
        #region singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static SideMenuListItemDesignModel Instance
            => new SideMenuListItemDesignModel();

        #endregion

        #region constructor

        

        public SideMenuListItemDesignModel()
        {
            Icon = "{StaticResource FontAwesomeBellIcon}";            
            Name = "Activity";
            Indicator = false;
        }

        #endregion
    }
}
