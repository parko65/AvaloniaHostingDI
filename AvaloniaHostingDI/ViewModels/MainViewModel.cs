using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaHostingDI.ViewModels;
public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _message = "DI in Avalonia with IHost works!!";
    
}
