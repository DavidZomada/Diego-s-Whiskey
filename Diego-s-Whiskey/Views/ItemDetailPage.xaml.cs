using System.ComponentModel;
using Xamarin.Forms;
using Diego_s_Whiskey.ViewModels;

namespace Diego_s_Whiskey.Views
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
