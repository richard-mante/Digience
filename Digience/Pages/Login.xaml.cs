using Digience.Views;

namespace Digience.Pages;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private void  Login_Button_Clicked(object sender, EventArgs e)
    {
#if ANDROID || IOS
        Application.Current.MainPage = new MobileAppShell();
#else
        Application.Current.MainPage = new DesktopAppShell();
#endif    
    }
    private void siginup_Tapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new SignUp();
    }
}