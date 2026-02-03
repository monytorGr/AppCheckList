namespace AppCheckList1.PageModels;

public class LoginModel : ContentPage
{
	public LoginModel()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Login"
				}
			}
		};
	}
}