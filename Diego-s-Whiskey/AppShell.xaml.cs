using System;
using System.Collections.Generic;
using Diego_s_Whiskey.ViewModels;
using Diego_s_Whiskey.Views;
using Xamarin.Forms;

namespace Diego_s_Whiskey
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
