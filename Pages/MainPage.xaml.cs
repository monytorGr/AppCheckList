//using Android.AdServices.Signals;
using AppCheckList1.Models;
using AppCheckList1.PageModels;
//using Google.Android.Material.Slider;

namespace AppCheckList1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel viewModel)
        {
            InitializeComponent();
            BindingContext = BindingContext = viewModel; 
        }
    }
}
//protected override async void OnAppearing()
//    {
//    base.OnAppearing();

//    bool isLogged = Preferences.Default.Get("is_logged", false);
//    if (!isLogged)

//    {
//        Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
//        await Shell.Current.GoToAsync("login");

//    }

//}

