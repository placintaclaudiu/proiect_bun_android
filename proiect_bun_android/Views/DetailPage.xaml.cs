using proiect_bun_android.ViewModels;

namespace proiect_bun_android.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(ProductViewModel item)
	{
		InitializeComponent();

        BindingContext = item;
    }
}