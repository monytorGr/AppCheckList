namespace AppCheckList1.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        // Depois você coloca validação real.
        // Por enquanto: ao clicar, vai para o Dashboard.
        await Shell.Current.GoToAsync("//main");
    }
}
