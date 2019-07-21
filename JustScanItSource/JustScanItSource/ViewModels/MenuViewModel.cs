using JustScanItSource.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustScanItSource.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private List<HomeMenuItem> menuItems;
        public List<HomeMenuItem> MenuItems
        {
            get { return menuItems; }

            set
            {
                menuItems = value;
                OnPropertyChanged();
            }
        }
        // Constructor
        public MenuViewModel()
        {
            // Menu instanciation
            this.menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Scan, Title="Scan"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About"},
            };
        }

    }
}
