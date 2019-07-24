using JustScanItSource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JustScanItSource.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        // Instancitation dictionary which content all of the opened menu pages 
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        /// <summary>
        /// Constructor of the Main menu page
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            // Define the menu behavior to make it poping over
            MasterBehavior = MasterBehavior.Popover;

            // Add the default page to the dictionary
            MenuPages.Add((int)MenuItemType.Scan, (NavigationPage)Detail);
        }

        

        /// <summary>
        /// Method which allows the navigation on the menu
        /// </summary>
        /// <param name="id">id of the page</param>
        /// <returns></returns>
        public async Task NavigateFromMenu(int id)
        {
            // If the page is not already opened
            if (!MenuPages.ContainsKey(id))
            {
                // Select the page linked to the id
                switch (id)
                {
                    // Scan page (set by default)
                    case (int)MenuItemType.Scan:
                        // Open the Scan Page
                        MenuPages.Add(id, new NavigationPage(new ScanPage()));
                        break;
                    // About Page
                    case (int)MenuItemType.About:
                        // Open the Scan Page
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    // History page
                    case (int)MenuItemType.History:
                        // Open the Scan Page
                        MenuPages.Add(id, new NavigationPage(new HistoryPage()));
                        break;
                    //
                    // Do the same for every new page ...
                }
            }
            // Get the page
            var newPage = MenuPages[id];

            // If this new page exist and is different than the previous one
            if (newPage != null && Detail != newPage)
            {
                // Set the new page
                Detail = newPage;

                // If the smartphone is Running android
                if (Device.RuntimePlatform == Device.Android)
                    // Set a timeout
                    await Task.Delay(100);

                IsPresented = false;

            }
            
        }
    }
}
