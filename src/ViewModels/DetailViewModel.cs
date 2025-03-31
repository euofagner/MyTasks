using CommunityToolkit.Mvvm.ComponentModel;

namespace src.ViewModels;

[QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
}
