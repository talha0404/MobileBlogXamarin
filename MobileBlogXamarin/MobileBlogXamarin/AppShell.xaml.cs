using MobileBlogXamarin.ViewModels;
using MobileBlogXamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBlogXamarin
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
