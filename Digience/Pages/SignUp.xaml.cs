namespace Digience.Pages;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private void Signup_Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new Login();
    }

    private void Login_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}