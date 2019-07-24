using JustScanItSource.Models;
using JustScanItSource.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JustScanItSource.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
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
        public MenuViewModel(ListView lv)
        {
            // Menu instanciation
            this.menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Scan, Title="Scan"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About"},
                new HomeMenuItem {Id = MenuItemType.History, Title="History"},
            };

            #region Listview settings
            // Set items source
            lv.ItemsSource = menuItems;

            // Set the selected item
            lv.SelectedItem = menuItems[0];

            // Beheviour when a new item is selected
            lv.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
            #endregion
        }

    }
}
