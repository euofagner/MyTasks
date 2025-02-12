using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace src.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string>? items;

    [ObservableProperty]
    string? text;

    public MainViewModel()
    {
        Items = [];
    }

    [RelayCommand]
    void Add()
    {
        if (!string.IsNullOrWhiteSpace(Text))
            Items.Add(Text);

        //add an item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}