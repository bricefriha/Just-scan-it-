using JustScanItSource.Models;
using JustScanItSource.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JustScanItSource.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        public MenuPage()
        {
            InitializeComponent();
            
            BindingContext = new MenuViewModel(ListViewMenu);
            //ListViewMenu.ItemSelected += async (sender, e) =>
            //{
            //    if (e.SelectedItem == null)
            //        return;

            //    var id = (int)((HomeMenuItem)e.SelectedItem).Id;
            //    await RootPage.NavigateFromMenu(id);
            //};

        }

        private async void ListViewMenu_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // 
            var lv = (ListView)sender;

            if (lv.SelectedItem == null)
                return;

            var id = (int)((HomeMenuItem)lv.SelectedItem).Id;
            await RootPage.NavigateFromMenu(id);
        }
    }
}