namespace AppCheckList1.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

        Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;


    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        bool isLogged = Preferences.Default.Get("is_logged", false);

        if (!isLogged)
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
            await Shell.Current.GoToAsync("login");
        }
    }
}
