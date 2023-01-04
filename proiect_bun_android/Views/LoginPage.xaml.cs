using proiect_bun_android.ViewModels;

namespace proiect_bun_android.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

        this.BindingContext = new LoginViewModel(this.Navigation);
    }
}