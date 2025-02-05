using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace src.ViewModels;

class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
