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
        
        public MenuPage()
        {
            InitializeComponent();
            
            BindingContext = new MenuViewModel(ListViewMenu);

        }
    }
}