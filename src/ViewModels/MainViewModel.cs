using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace src.ViewModels;

public partial class MainViewModel : ObservableObject
{
    IConnectivity connectivity;

    [ObservableProperty]
    ObservableCollection<string>? items;

    [ObservableProperty]
    string? text;

    public MainViewModel(IConnectivity connectivity)
    {
        Items = [];
        this.connectivity = connectivity;
    }

    [RelayCommand]
    public async Task Add()
    {
        if (!string.IsNullOrWhiteSpace(Text))
            Items.Add(Text);

        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {  
            await Shell.Current.DisplayAlert("No internet", "You are not conected", "Ok");
            return;
        }

        //add an item
        Text = string.Empty;
    }

    [RelayCommand]
    public void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    [RelayCommand]
    public async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
}