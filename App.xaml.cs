namespace AppCheckList1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var shell = new AppShell();

        shell.Dispatcher.Dispatch(async () =>
        {
            await Shell.Current.GoToAsync("//login");
        });

        return new Window(shell);
    }
}
