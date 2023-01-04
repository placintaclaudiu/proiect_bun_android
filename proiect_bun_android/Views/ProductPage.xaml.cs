using proiect_bun_android.ViewModels;


namespace proiect_bun_android.Views;

public partial class ProductPage : ContentPage
{
    readonly ProductViewModel productViewModel;
    public ProductPage()
    {
        InitializeComponent();

        productViewModel = new ProductViewModel(this.Navigation);
        BindingContext = productViewModel;
    }
}