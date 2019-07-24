using System;
using System.Collections.Generic;
using System.Text;

namespace JustScanItSource.Models
{
    /// <summary>
    /// Enumerations of the app differents pages
    /// </summary>
    public enum MenuItemType
    {
        Scan,
        About,
        History,
        //CellPhoneNum,
        //
        // Do the same for every new page ...
    }
    /// <summary>
    /// Constructor
    /// </summary>
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
    }
}
