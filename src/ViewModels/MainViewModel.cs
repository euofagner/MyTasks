using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace src.ViewModels;

public partial class MainViewModel : ObservableObject
{
    ObservableCollection<string>? items;

    [ObservableProperty]
    string? text;

    [RelayCommand]
    void  Add()
    {
        //add our item
        Text = string.Empty;
    }
}