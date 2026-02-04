namespace AppCheckList1.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

        Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
    }
}
