namespace Digience.Pages;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private void  Login_Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }

    private void siginup_Tapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new SignUp();
    }
}