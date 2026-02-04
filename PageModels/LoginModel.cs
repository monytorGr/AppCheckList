using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppCheckList1.PageModels;

public partial class LoginModel : ObservableObject
{
    [ObservableProperty]
    private string fullName = string.Empty;

    [ObservableProperty]
    private string password = string.Empty;

    [RelayCommand]
    private async Task Save()
    {
        if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(password))
        {
            await Shell.Current.DisplayAlertAsync(
                "Erro",
                "Informe o nome completo.",
                "OK");
            return;
        }

        if (password.Length < 5)
        {
            await Shell.Current.DisplayAlertAsync(
                "Erro",
                "A senha deve ter pelo menos 6 caracteres.",
                "OK");
            return;
        }
     
        Preferences.Default.Set("user_name", fullName);
        Preferences.Default.Set("user_password", password);

        await Shell.Current.DisplayAlertAsync(
            "Sucesso",
            "Login realizado com sucesso!",
            "OK");

        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;


        await Shell.Current.GoToAsync("//main");
    }
}
