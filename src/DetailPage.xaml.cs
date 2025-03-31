using src.ViewModels;

namespace src;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

        Shell.SetBackgroundColor(this, Color.FromArgb("#ffffff"));
    }
}