using proiect_bun_android.ViewModels;
namespace proiect_bun_android.Views;

public partial class CartPage : ContentPage
{
	public CartPage(ProductViewModel productViewModel)
	{
		InitializeComponent();

        BindingContext = productViewModel;
    }
}