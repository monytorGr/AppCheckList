using AppCheckList1.Models;
using AppCheckList1.PageModels;

namespace AppCheckList1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel viewModel)
        {
            InitializeComponent();
            BindingContext = BindingContext = viewModel; ;
        }
    }
}