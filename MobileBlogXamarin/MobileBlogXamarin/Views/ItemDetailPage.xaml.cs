using MobileBlogXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileBlogXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}